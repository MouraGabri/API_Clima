import sys
from pymongo import MongoClient
import matplotlib.pyplot as plt
import matplotlib
from pathlib import Path
matplotlib.use("Agg")

cidade = sys.argv[1]
# cidade = "Canoas, RS"

client = MongoClient("mongodb://localhost:27017/")
db = client["api_tempo1"]
collection = db["consultas_clima"]
documento = collection.find_one({"results.city": cidade})

if not documento:
    print(f"Nenhum resultado encontrado para {cidade}")
    sys.exit()

forecast = documento["results"]["forecast"]

datas    = [f["date"] for f in forecast]
maximas  = [f["max"] for f in forecast]
minimas  = [f["min"] for f in forecast]
chuva    = [f["rain_probability"] for f in forecast]

# Criação da FIG
fig, (ax1, ax2) = plt.subplots(2, 1, figsize=(8, 6))
fig.suptitle(f"Previsão do tempo — {cidade}", fontsize=13, fontweight='bold')
# Variação da Temperatura
ax1.plot(datas, maximas, marker='o', color='tomato', label='Máxima')
ax1.plot(datas, minimas, marker='o', color='steelblue', label='Mínima')
ax1.set_ylabel("Temperatura (°C)")
ax1.set_title("Temperatura Máxima e Mínima")
ax1.legend() 
ax1.grid(True, linestyle='--', alpha=0.5)
# Probabilidade de chuva
ax2.bar(datas, chuva, color='cornflowerblue')
ax2.set_ylabel("Probabilidade (%)")
ax2.set_title("Probabilidade de Chuva")
ax2.set_ylim(0, 110)
ax2.grid(True, linestyle='--', alpha=0.5)

plt.tight_layout()

# Cria o repositório se não existir

path_arquivo = Path(r"C:\Temp")
path_arquivo.mkdir(parents=True, exist_ok=True)

# Salva o png no caminho fornecido
plt.savefig(r"C:\Temp\grafico.png")
plt.close()

print("ok")




