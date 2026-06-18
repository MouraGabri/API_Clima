using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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


                string[] dataSelected = SelectedCity.Split('-');

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
                
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Mongo mongo = new Mongo();

            mongo.Insert(json);
        }
    }
}
#endregion
