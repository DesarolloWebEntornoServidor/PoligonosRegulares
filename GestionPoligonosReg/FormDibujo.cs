using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPoligonosReg
{
    public partial class FormDibujo : Form
    {
        public FormDibujo()
        {
            InitializeComponent();

            trackRadio.Value = 100;
            txtRadio.Text = trackRadio.Value.ToString();
            trackGiro.Value = 0;
            txtGiro.Text = trackGiro.Value.ToString();

            lbColor.BackColor = Color.Black;
            nudNumLados.Value = 5;

            trackX.Value = 250;
            trackY.Value = 250;

        }


        private void rbNegro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNegro.Checked)
                lbColor.BackColor = Color.Black;
            if (rbVerde.Checked)
                lbColor.BackColor = Color.Green;
            if (rbRojo.Checked)
                lbColor.BackColor = Color.Red;
            if (rbAzul.Checked)
                lbColor.BackColor = Color.Blue;

        }

        private void FormDibujo_Load(object sender, EventArgs e)
        {
            for (int i = 2; i < 9; i++)
            {
                cbGrosor.Items.Add(i / 2F);
            }

            cbGrosor.SelectedIndex = 2;
        }



        private void panelDibujo_MouseClick(object sender, MouseEventArgs e)
        {
            trackX.Value = e.X;
            trackY.Value = 500 - e.Y;

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();

            auxColor = lbColor.BackColor;

            lbColor.BackColor = colorDialog.Color;
            if (colorDialog.Color != auxColor)
            {
                rbAzul.Checked = false;
                rbNegro.Checked = false;
                rbRojo.Checked = false;
                rbVerde.Checked = false;
                btnColor.Focus();
            }

        }

        Graphics grafico;
        int radio = 0;
        double angBase = 0;
        Color auxColor;

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            Point[] puntos = new Point[(int)nudNumLados.Value];

            grafico = panelDibujo.CreateGraphics();

            radio = (trackRadio.Value);

            int xCentro = trackX.Value;
            int yCentro = 500 - trackY.Value;

            angBase = (2 * Math.PI) / (double)nudNumLados.Value;


            for (int i = 0; i < nudNumLados.Value; i++)
            {
                int x = xCentro + (int)(radio * Math.Cos((trackGiro.Value * Math.PI / 180) + i * angBase));
                int y = yCentro + (int)(radio * Math.Sin((trackGiro.Value * Math.PI / 180) + i * angBase));

                puntos[i] = new Point(x,y);

            }


            Pen pen = new Pen(lbColor.BackColor, (float)(cbGrosor.SelectedItem));

            grafico.DrawPolygon(pen, puntos);
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Point[] puntos = new Point[(int)nudNumLados.Value];

            grafico = panelDibujo.CreateGraphics();

            radio = (trackRadio.Value);

            int xCentro = trackX.Value;
            int yCentro = 500 - trackY.Value;

            angBase = (2 * Math.PI) / (double)nudNumLados.Value;



            for (int i = 0; i < nudNumLados.Value; i++)
            {
                int x = xCentro + (int)(radio * Math.Cos((trackGiro.Value * Math.PI / 180) + i * angBase));
                int y = yCentro + (int)(radio * Math.Sin((trackGiro.Value * Math.PI / 180) + i * angBase));

                puntos[i] = new Point(x, y);

            }



            Pen pen = new Pen(lbColor.BackColor, (float)(cbGrosor.SelectedItem));

            grafico.DrawPolygon(pen, puntos);

            for (int i = 0; i < nudNumLados.Value; i++)
            {
                for (int j = 0; j < nudNumLados.Value; j++)
                {
                    grafico.DrawLine(pen,puntos[i], puntos[j]);
                }

            }


        }

        private void txtRadio_TextChanged(object sender, EventArgs e)
        {

            if (txtRadio.Text != "")
            {
                if (Convert.ToInt32(txtRadio.Text) > 250)
                {
                    MessageBox.Show("Será fijado el valor máximo permitido ", "Erro, Valor mayor que el permitido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRadio.Text = "250";

                }

                trackRadio.Value = Convert.ToInt32(txtRadio.Text);

            } else
                txtRadio.Text = "0";

        }

        private void trackRadio_Scroll(object sender, EventArgs e)
        {
            txtRadio.Text = trackRadio.Value.ToString();

        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            Point[] puntos = new Point[(int)nudNumLados.Value];

            grafico = panelDibujo.CreateGraphics();

            radio = (trackRadio.Value);

            int xCentro = trackX.Value;
            int yCentro = 500 - trackY.Value;

            angBase = (2 * Math.PI) / (double)nudNumLados.Value;



            for (int i = 0; i < nudNumLados.Value; i++)
            {
                int x = xCentro + (int)(radio * Math.Cos((trackGiro.Value * Math.PI / 180) + i * angBase));
                int y = yCentro + (int)(radio * Math.Sin((trackGiro.Value * Math.PI / 180) + i * angBase));

                puntos[i] = new Point(x, y);

            }

            SolidBrush color = new SolidBrush(lbColor.BackColor);
            grafico.FillPolygon(color, puntos);

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("¿Estás Seguro que lo Quieres Borrar?", "", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                grafico = panelDibujo.CreateGraphics();
                grafico.Clear(panelDibujo.BackColor);

                txtGiro.Text = "0";
                trackGiro.Value = 0;
            }

        }

        private void txtGiro_TextChanged(object sender, EventArgs e)
        {
            if (txtGiro.Text != "")
            {
                if (Convert.ToInt32(txtGiro.Text) > 90)
                {
                    MessageBox.Show("Será fijado el valor máximo permitido ", "Erro, Valor mayor que el permitido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGiro.Text = "90";

                }

                trackGiro.Value = Convert.ToInt32(txtGiro.Text);

            }
            else
                txtGiro.Text = "0";
        }

        private void trackGiro_Scroll(object sender, EventArgs e)
        {
            txtGiro.Text = trackGiro.Value.ToString();

        }
    }
}
