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
using Weather_System.Service;

namespace Weather_System
{
    public partial class frmPrincipal : Form
    {
        WebService webService = new WebService();
        Root_Model objectWeather;
        bool CliqueMouse;
        Point PontoClicado;

        public frmPrincipal()
        {
            InitializeComponent();
            FillName();
            Application.DoEvents();
            objectWeather = webService.GetData();
            FillDataGrid();
        }

        private void FillName()
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            txboxUser.Text = textInfo.ToTitleCase(Environment.UserName.Replace('.', ' '));
        }

        private void FillDataGrid()
        {
            try
            {
                dataGridView1.Rows?.Clear();

                foreach (Forecast_Model weather in objectWeather.results.forecast)
                {
                    dataGridView1.Rows.Add(weather.date,weather.min, weather.max, weather.description, weather.rain_probability);
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
            FillDataGrid();
        }
    }
}
#endregion
