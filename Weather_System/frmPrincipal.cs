using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weather_System.Models;
using Weather_System.Repositories;
using Weather_System.Service;

namespace Weather_System
{
    public partial class frmPrincipal : Form
    {
        WebService webService = new WebService();
        Root_Model objectWeather;
        bool CliqueMouse;
        Point PontoClicado;
        private Root_Model json;

        public frmPrincipal()
        {
            InitializeComponent();
            FillName();
            Application.DoEvents();
            button2.Enabled = false;
            button3.Enabled = false;
            //objectWeather = webService.GetData("Canoas","RS");
            //FillDataGrid();
        }

        private void FillName()
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            txboxUser.Text = textInfo.ToTitleCase(Environment.UserName.Replace('.', ' '));
        }

        private void FillDataGrid(Root_Model objectJson)
        {
            try
            {
                if (objectJson == null)
                {
                    MessageBox.Show("Houve um erro ao retornar os dados da API. Por favor, entre em contato com o suporte");
                    dataGridView1.Rows?.Clear();
                    return;
                }

                json = objectJson;
                dataGridView1.Rows?.Clear();

                foreach (Forecast_Model weather in objectJson.results.forecast)
                {
                    dataGridView1.Rows.Add(weather.date, weather.min, weather.max, weather.description, weather.rain_probability + "%");
                }

                dataGridView1.ClearSelection();
            }
            catch (Exception)
            {

                throw;
            }

        }

        #region Movimentar a janela

        private void MouseDownn(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            CliqueMouse = true;
            PontoClicado = e.Location;
        }

        private void MouseMovee(object sender, MouseEventArgs e)
        {
            if (CliqueMouse)
            {
                this.Location = new Point(Cursor.Position.X - PontoClicado.X, Cursor.Position.Y - PontoClicado.Y);
            }
        }

        private void MouseUpp(object sender, MouseEventArgs e)
        {
            CliqueMouse = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string SelectedCity = cmBoxCity.SelectedItem?.ToString();

                if (string.IsNullOrWhiteSpace(SelectedCity))
                {
                    dataGridView1.Rows?.Clear();
                    return;
                }


                string[] dataSelected = SelectedCity.Split(',');

                Root_Model json = webService.GetData(dataSelected[0], dataSelected[1]);
                FillDataGrid(json);


            }
            catch (Exception)
            {

                throw;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string cidade = cmBoxCity.SelectedItem?.ToString();
                //Farroupilha, RS

                if (string.IsNullOrWhiteSpace(cidade))
                {
                    MessageBox.Show("Selecione uma cidade antes de gerar o gráfico.");
                    return;
                }



                // Procura a pasta "Scripts" no diretório atual e em todos os diretórios
                string pasta = Application.StartupPath;

                while (!Directory.Exists(Path.Combine(pasta, "Scripts")))
                {
                    var pai = Directory.GetParent(pasta);

                    if (pai == null)
                        throw new Exception("Pasta Scripts não encontrada.");

                    pasta = pai.FullName;
                }

                string scriptPath = Path.Combine(pasta, "Scripts", "grafico.py");

                // após isso monta o caminho para usar de referência
                // string scriptPath = @"C:\Users\gabriel.moura\Downloads\grafico.py"; Caso não funcione, rodar 
                // na pasta Downloads local

                string imagemPath = @"C:\Temp\grafico.png";

                var psi = new ProcessStartInfo
                {
                    FileName = "python",
                    Arguments = $"\"{scriptPath}\" \"{cidade}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var processo = Process.Start(psi))
                {
                    string output = processo.StandardOutput.ReadToEnd();
                    string error = processo.StandardError.ReadToEnd();

                    processo.WaitForExit();

                    output = output.Trim();
                    error = error.Trim();

                    // validação do Python

                    if (output.Contains("ok") && File.Exists(imagemPath))
                    {
                        Form2 telaGrafico = new Form2(imagemPath);
                        telaGrafico.ShowDialog();
                    }
                    else
                    {

                        MessageBox.Show("Erro ao gerar gráfico.\n\nOUTPUT: " + output + "\nERROR: " + error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no C#: " + ex.Message);
            }
        }
        


        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Não há dados para gravar. Por favor, selecione uma cidade e gere os dados antes de gravar.");
                return;
            }


            string cidade = cmBoxCity.SelectedItem?.ToString();
            //Farroupilha, RS

            if (string.IsNullOrWhiteSpace(cidade))
            {
                MessageBox.Show("Selecione uma cidade antes de gravar as informações.");
                return;
            }

            Mongo mongo = new Mongo();

            mongo.Insert(json);
            MessageBox.Show("Dados gravados com sucesso no MongoDB!");

            if (dataGridView1.Rows.Count != 0)
            {
                button2.Enabled = true;
                button3.Enabled = true;
            }

            else
            {
                button2.Enabled = false;
                button3.Enabled = false;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string cidade = cmBoxCity.SelectedItem?.ToString(); 
                string scriptPath = @"C:\Users\gabriel.moura\Downloads\consultasDB.py";

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "python";
                psi.Arguments = $"\"{scriptPath}\" \"{cidade}\"";
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;

                Process processo = Process.Start(psi);
                string output = processo.StandardOutput.ReadToEnd();
                processo.WaitForExit();


                if (string.IsNullOrWhiteSpace(output)) return;


                double mediaTemp = double.Parse(output, System.Globalization.CultureInfo.InvariantCulture);
                label4.Text = $"Média de temperatura em {cidade}: {mediaTemp}°C";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}

#endregion
