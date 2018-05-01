using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProbabilidad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }
        Boolean []activoPicas = new Boolean[14];
        Boolean[] activoDiamantes = new Boolean[14];
        Boolean[] activoTrebol = new Boolean[14];
        Boolean[] activoCorazon = new Boolean[14];
        float cartasSeleccionadas = new int();
        float total = new float();
        //Incio de los corazones
        private void CorazonesNegros_Click(object sender, EventArgs e)
        {

            if (activoPicas[0] == false)
            {
                activoPicas[0] = true;
                if (cartasSeleccionadas>=0) {
                    cartasSeleccionadas += 1;
                   
                }
                else {
                    //nada
                }
                
 
                CorazonesNegros.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoPicas[0] = false;
                CorazonesNegros.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text=total.ToString();
        }

        private void CorazonesNegros2_Click(object sender, EventArgs e)
        {
            if (activoPicas[1] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoPicas[1] = true;
                CorazonesNegros2.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoPicas[1] = false;
                CorazonesNegros2.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void CorazonesNegros3_Click(object sender, EventArgs e)
        {
            if (activoPicas[2] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoPicas[2] = true;
             
                CorazonesNegros3.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoPicas[2] = false;
               
                CorazonesNegros3.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString()  ;
        }

        private void CorazonesNegros4_Click(object sender, EventArgs e)
        {
            if (activoPicas[3] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoPicas[3] = true;
                CorazonesNegros4.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoPicas[3] = false;
                CorazonesNegros4.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void CorazonesNegros5_Click(object sender, EventArgs e)
        {
            if (activoPicas[4] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoPicas[4] = true;
                CorazonesNegros5.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoPicas[4] = false;
                CorazonesNegros5.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }
    
        private void CorazonesNegros6_Click_1(object sender, EventArgs e)
        {
            if (activoPicas[5] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoPicas[5] = true;
                CorazonesNegros6.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoPicas[5] = false;
                CorazonesNegros6.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void CorazonesNegros7_Click(object sender, EventArgs e)
        {
            if (activoPicas[6] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoPicas[6] = true;
                CorazonesNegros7.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoPicas[6] = false;
                CorazonesNegros7.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void CorazonesNegros8_Click(object sender, EventArgs e)
        {
            if (activoPicas[7] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoPicas[7] = true;
                CorazonesNegros8.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoPicas[7] = false;
                CorazonesNegros8.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void CorazonesNegros9_Click(object sender, EventArgs e)
        {
            if (activoPicas[8] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoPicas[8] = true;
                CorazonesNegros9.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }

                activoPicas[8] = false;
                CorazonesNegros9.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void CorazonesNegrosJ_Click(object sender, EventArgs e)
        {
            if (activoPicas[9] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoPicas[9] = true;
                CorazonesNegrosJ.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoPicas[9] = false;
                CorazonesNegrosJ.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void CorazonesNegrosQ_Click(object sender, EventArgs e)
        {
            if (activoPicas[10] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoPicas[10] = true;
                CorazonesNegrosQ.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }

                activoPicas[10] = false;
                CorazonesNegrosQ.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void CorazonesNegrosK_Click(object sender, EventArgs e)
        {
            if (activoPicas[11] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoPicas[11] = true;
                CorazonesNegrosK.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoPicas[11] = false;
                CorazonesNegrosK.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            if (activoPicas[12] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoPicas[12] = true;
                bunifuImageButton11.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoPicas[12] = false;
                bunifuImageButton11.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }
        //Inicio de los diamantes

        private void DiamantesRojos_Click(object sender, EventArgs e)
        {
            if (activoDiamantes[0] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoDiamantes[0] = true;
                DiamantesRojos.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }

                activoDiamantes[0] = false;
                DiamantesRojos.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void DiamantesRojos2_Click(object sender, EventArgs e)
        {

            if (activoDiamantes[1] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoDiamantes[1] = true;
                DiamantesRojos2.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoDiamantes[1] = false;
                DiamantesRojos2.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void DiamantesRojos3_Click(object sender, EventArgs e)
        {
            if (activoDiamantes[2] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoDiamantes[2] = true;
                DiamantesRojos3.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoDiamantes[2] = false;
                DiamantesRojos3.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void DiamantesRojos4_Click(object sender, EventArgs e)
        {
            if (activoDiamantes[3] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoDiamantes[3] = true;
                DiamantesRojos4.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoDiamantes[3] = false;
                DiamantesRojos4.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void DiamantesRojos5_Click(object sender, EventArgs e)
        {
            if (activoDiamantes[4] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoDiamantes[4] = true;
                DiamantesRojos5.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoDiamantes[4] = false;
                DiamantesRojos5.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void DiamantesRojos6_Click(object sender, EventArgs e)
        {
            if (activoDiamantes[5] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoDiamantes[5] = true;
                DiamantesRojos6.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }

                activoDiamantes[5] = false;
                DiamantesRojos6.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void DiamantesRojos7_Click(object sender, EventArgs e)
        {
            if (activoDiamantes[6] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoDiamantes[6] = true;
                DiamantesRojos7.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoDiamantes[6] = false;
                DiamantesRojos7.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void DiamantesRojos8_Click(object sender, EventArgs e)
        {
            if (activoDiamantes[7] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoDiamantes[7] = true;
                DiamantesRojos8.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoDiamantes[7] = false;
                DiamantesRojos8.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void DiamantesRojos9_Click(object sender, EventArgs e)
        {
            if (activoDiamantes[8] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoDiamantes[8] = true;
                DiamantesRojos9.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoDiamantes[8] = false;
                DiamantesRojos9.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void DiamantesRojosJ_Click(object sender, EventArgs e)
        {
            if (activoDiamantes[9] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoDiamantes[9] = true;
                DiamantesRojosJ.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoDiamantes[9] = false;
                DiamantesRojosJ.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void DiamantesRojosQ_Click(object sender, EventArgs e)
        {
            if (activoDiamantes[10] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoDiamantes[10] = true;
                DiamantesRojosQ.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoDiamantes[10] = false;
                DiamantesRojosQ.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void DiamantesRojosK_Click(object sender, EventArgs e)
        {
            if (activoDiamantes[11] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoDiamantes[11] = true;
                DiamantesRojosK.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoDiamantes[11] = false;
                DiamantesRojosK.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void DiamantesRojosA_Click(object sender, EventArgs e)
        {
            if (activoDiamantes[12] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoDiamantes[12] = true;
                DiamantesRojosA.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {

                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoDiamantes[12] = false;
                DiamantesRojosA.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }
        //Inicio Treboles
        private void TrebolNegro_Click(object sender, EventArgs e)
        {
            if (activoTrebol[0] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoTrebol[0] = true;
                TrebolNegro.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoTrebol[0] = false;
                TrebolNegro.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void TrebolNegro2_Click(object sender, EventArgs e)
        {
            if (activoTrebol[1] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoTrebol[1] = true;
                TrebolNegro2.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoTrebol[1] = false;
                TrebolNegro2.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void TrebolNegro3_Click(object sender, EventArgs e)
        {
            if (activoTrebol[2] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoTrebol[2] = true;
                TrebolNegro3.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoTrebol[2] = false;
                TrebolNegro3.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void TrebolNegro4_Click(object sender, EventArgs e)
        {
            if (activoTrebol[3] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoTrebol[3] = true;
                TrebolNegro4.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }

                activoTrebol[3] = false;
                TrebolNegro4.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void TrebolNegro5_Click(object sender, EventArgs e)
        {
            if (activoTrebol[4] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoTrebol[4] = true;
                TrebolNegro5.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoTrebol[4] = false;
                TrebolNegro5.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void TrebolNegro6_Click(object sender, EventArgs e)
        {
            if (activoTrebol[5] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoTrebol[5] = true;
                TrebolNegro6.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoTrebol[5] = false;
                TrebolNegro6.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void TrebolNegro7_Click(object sender, EventArgs e)
        {
            if (activoTrebol[6] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoTrebol[6] = true;
                TrebolNegro7.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoTrebol[6] = false;
                TrebolNegro7.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void TrebolNegro8_Click(object sender, EventArgs e)
        {
            if (activoTrebol[7] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoTrebol[7] = true;
                TrebolNegro8.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoTrebol[7] = false;
                TrebolNegro8.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void TrebolNegro9_Click(object sender, EventArgs e)
        {
            if (activoTrebol[8] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoTrebol[8] = true;
                TrebolNegro9.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoTrebol[8] = false;
                TrebolNegro9.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void TrebolNegroJ_Click(object sender, EventArgs e)
        {
            if (activoTrebol[9] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoTrebol[9] = true;
                TrebolNegroJ.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoTrebol[9] = false;
                TrebolNegroJ.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void TrebolNegroQ_Click(object sender, EventArgs e)
        {
            if (activoTrebol[10] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoTrebol[10] = true;
                TrebolNegroQ.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoTrebol[10] = false;
                TrebolNegroQ.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void TrebolNegroK_Click(object sender, EventArgs e)
        {
            if (activoTrebol[11] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoTrebol[11] = true;
                TrebolNegroK.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoTrebol[11] = false;
                TrebolNegroK.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void TrebolNegroA_Click(object sender, EventArgs e)
        {
            if (activoTrebol[12] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoTrebol[12] = true;
                TrebolNegroA.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoTrebol[12] = false;
                TrebolNegroA.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }
        //Inicio de los corazones rojos
        private void CorazonesRojos_Click(object sender, EventArgs e)
        {
            if (activoCorazon[0] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoCorazon[0] = true;
                CorazonesRojos.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoCorazon[0] = false;
                CorazonesRojos.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void CorazonesRojos2_Click(object sender, EventArgs e)
        {
            if (activoCorazon[1] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoCorazon[1] = true;
                CorazonesRojos2.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }

                activoCorazon[1] = false;
                CorazonesRojos2.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void CorazonesRojos3_Click(object sender, EventArgs e)
        {
            if (activoCorazon[2] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoCorazon[2] = true;
                CorazonesRojos3.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoCorazon[2] = false;
                CorazonesRojos3.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void CorazonesRojos4_Click(object sender, EventArgs e)
        {
            if (activoCorazon[3] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoCorazon[3] = true;
                CorazonesRojos4.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoCorazon[3] = false;
                CorazonesRojos4.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }
        private void bunifuImageButton36_Click(object sender, EventArgs e)
        {
            if (activoCorazon[4] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoCorazon[4] = true;
                CorazonesRojos5.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoCorazon[4] = false;
                CorazonesRojos5.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void CorazonesRojos6_Click(object sender, EventArgs e)
        {
            if (activoCorazon[5] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoCorazon[5] = true;
                CorazonesRojos6.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoCorazon[5] = false;
                CorazonesRojos6.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void CorazonesRojos7_Click(object sender, EventArgs e)
        {
            if (activoCorazon[6] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoCorazon[6] = true;
                CorazonesRojos7.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoCorazon[6] = false;
                CorazonesRojos7.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void CorazonesRojos8_Click(object sender, EventArgs e)
        {
            if (activoCorazon[7] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoCorazon[7] = true;
                CorazonesRojos8.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoCorazon[7] = false;
                CorazonesRojos8.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void CorazonesRojos9_Click(object sender, EventArgs e)
        {
            if (activoCorazon[8] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoCorazon[8] = true;
                CorazonesRojos9.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoCorazon[8] = false;
                CorazonesRojos9.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void CorazonesRojosJ_Click(object sender, EventArgs e)
        {
            if (activoCorazon[9] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoCorazon[9] = true;
                CorazonesRojosJ.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoCorazon[9] = false;
                CorazonesRojosJ.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void CorazonesRojosQ_Click(object sender, EventArgs e)
        {
            if (activoCorazon[10] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoCorazon[10] = true;
                CorazonesRojosQ.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoCorazon[10] = false;
                CorazonesRojosQ.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void CorazonesRojosK_Click(object sender, EventArgs e)
        {
            if (activoCorazon[11] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoCorazon[11] = true;
                CorazonesRojosK.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoCorazon[11] = false;
                CorazonesRojosK.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void CorazonesRojosA_Click(object sender, EventArgs e)
        {
            if (activoCorazon[12] == false)
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas += 1;
                }
                else
                {
                    //nada
                }
                activoCorazon[12] = true;
                CorazonesRojosA.BorderStyle = BorderStyle.FixedSingle;

            }
            else
            {
                if (cartasSeleccionadas >= 0)
                {
                    cartasSeleccionadas -= 1;
                }
                else
                {
                    //nada
                }
                activoCorazon[12] = false;
                CorazonesRojosA.BorderStyle = BorderStyle.None;

            }
            total = (cartasSeleccionadas / 52);
            probabilidadDisplay.ResetText();
            probabilidadDisplay.Text = total.ToString() ;
        }

        private void blimpiar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 14; i++) {
                cartasSeleccionadas = 0;
                activoCorazon[i] = false;
                activoDiamantes[i] = false;
                activoPicas[i] = false;
                activoTrebol[i] = false;
                probabilidadDisplay.ResetText();
                //corazones rojos
                CorazonesRojos.BorderStyle = BorderStyle.None;
                CorazonesRojos2.BorderStyle = BorderStyle.None;
                CorazonesRojos3.BorderStyle = BorderStyle.None;
                CorazonesRojos4.BorderStyle = BorderStyle.None;
                CorazonesRojos5.BorderStyle = BorderStyle.None;
                CorazonesRojos6.BorderStyle = BorderStyle.None;
                CorazonesRojos7.BorderStyle = BorderStyle.None;
                CorazonesRojos8.BorderStyle = BorderStyle.None;
                CorazonesRojos9.BorderStyle = BorderStyle.None;
                CorazonesRojosA.BorderStyle = BorderStyle.None;
                CorazonesRojosJ.BorderStyle = BorderStyle.None;
                CorazonesRojosQ.BorderStyle = BorderStyle.None;
                CorazonesRojosK.BorderStyle = BorderStyle.None;
                //corazones negros
                CorazonesNegros.BorderStyle = BorderStyle.None;
                CorazonesNegros2.BorderStyle = BorderStyle.None;
                CorazonesNegros3.BorderStyle = BorderStyle.None;
                CorazonesNegros4.BorderStyle = BorderStyle.None;
                CorazonesNegros5.BorderStyle = BorderStyle.None;
                CorazonesNegros6.BorderStyle = BorderStyle.None;
                CorazonesNegros7.BorderStyle = BorderStyle.None;
                CorazonesNegros8.BorderStyle = BorderStyle.None;
                CorazonesNegros9.BorderStyle = BorderStyle.None;
                bunifuImageButton11.BorderStyle = BorderStyle.None;
                CorazonesNegrosJ.BorderStyle = BorderStyle.None;
                CorazonesNegrosQ.BorderStyle = BorderStyle.None;
                CorazonesNegrosK.BorderStyle = BorderStyle.None;
                //diamantes
                DiamantesRojos.BorderStyle = BorderStyle.None;
                DiamantesRojos2.BorderStyle = BorderStyle.None;
                DiamantesRojos3.BorderStyle = BorderStyle.None;
                DiamantesRojos4.BorderStyle = BorderStyle.None;
                DiamantesRojos5.BorderStyle = BorderStyle.None;
                DiamantesRojos6.BorderStyle = BorderStyle.None;
                DiamantesRojos7.BorderStyle = BorderStyle.None;
                DiamantesRojos8.BorderStyle = BorderStyle.None;
                DiamantesRojos9.BorderStyle = BorderStyle.None;
                DiamantesRojosA.BorderStyle = BorderStyle.None;
                DiamantesRojosJ.BorderStyle = BorderStyle.None;
                DiamantesRojosQ.BorderStyle = BorderStyle.None;
                DiamantesRojosK.BorderStyle = BorderStyle.None;
                //trebol
                TrebolNegro.BorderStyle = BorderStyle.None;
                TrebolNegro2.BorderStyle = BorderStyle.None;
                TrebolNegro3.BorderStyle = BorderStyle.None;
                TrebolNegro4.BorderStyle = BorderStyle.None;
                TrebolNegro5.BorderStyle = BorderStyle.None;
                TrebolNegro6.BorderStyle = BorderStyle.None;
                TrebolNegro7.BorderStyle = BorderStyle.None;
                TrebolNegro8.BorderStyle = BorderStyle.None;
                TrebolNegro9.BorderStyle = BorderStyle.None;
                TrebolNegroA.BorderStyle = BorderStyle.None;
                TrebolNegroQ.BorderStyle = BorderStyle.None;
                TrebolNegroJ.BorderStyle = BorderStyle.None;
                TrebolNegroK.BorderStyle = BorderStyle.None;
               
            }
        }
    }
}
