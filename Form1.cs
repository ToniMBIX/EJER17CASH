using EJER17CASH.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace EJER17CASH
{
    
    public partial class FunWithJoeAndBob : Form
    {
        Guy[] arrayGuys = new Guy[] {
            new Guy { Name = "Joe", Cash = 50 },
            new Guy { Name = "Bob", Cash = 100 },
            new Guy { Name = "Bank", Cash = 100 }
        };

        public void ActualizaForm()
        {
            Guy joe = arrayGuys[0];
            Guy bob = arrayGuys[1];
            Guy bank = arrayGuys[2];
            lblJoeCash.Text= joe.Name +" tiene "+joe.Cash + " euros.";
            lblBobCash.Text = bob.Name + " tiene " + bob.Cash + " euros.";
            lblBankCash.Text = "La banca tiene: " + bank.Cash + " euros.";
        }
        public FunWithJoeAndBob()
        {
            Guy joe = arrayGuys[0];
            Guy bob = arrayGuys[1];
            Guy bank = arrayGuys[2];
            InitializeComponent();
        }

        private void buttonDar10Joe_Click(object sender, EventArgs e)
        {
            Guy joe = arrayGuys[0];
            Guy bob = arrayGuys[1];
            Guy bank = arrayGuys[2];
            if (bank.Cash>=10)
            {
                joe.RecieveCash(10);
                bank.GiveCash(10);
                ActualizaForm();
            }
            else
            {
                string mensaje = "Estamos en BANCA ROTA.";
                string titulo = "ALERTA DEL BANCO";
                MessageBox.Show(mensaje, titulo);
            }
        }

        private void buttonJoe10Bob_Click(object sender, EventArgs e)
        {
            Guy joe = arrayGuys[0];
            Guy bob = arrayGuys[1];
            Guy bank = arrayGuys[2];
            if (joe.Cash >= 10)
            {
                bob.RecieveCash(10);
                joe.GiveCash(10);
                ActualizaForm();
            }
            else
            {
                string mensaje = "No tengo saldo suficiente como para darte 10";
                string titulo = "Joe dice...";
                MessageBox.Show(mensaje, titulo);
            }
        }

        private void buttonRecibir5Bob_Click(object sender, EventArgs e)
        {
            Guy joe = arrayGuys[0];
            Guy bob = arrayGuys[1];
            Guy bank = arrayGuys[2];
            if (bob.Cash >= 5)
            {
                bank.RecieveCash(5);
                bob.GiveCash(5);
                ActualizaForm();
            }
            else
            {
                string mensaje = "No tengo saldo suficiente como para ingresar 5";
                string titulo = "Bob dice...";
                MessageBox.Show(mensaje, titulo);
            }
        }

        private void buttonBob5Joe_Click(object sender, EventArgs e)
        {
            Guy joe = arrayGuys[0];
            Guy bob = arrayGuys[1];
            Guy bank = arrayGuys[2];
            if (bob.Cash >= 5)
            {
                joe.RecieveCash(5);
                bob.GiveCash(5);
                ActualizaForm();
            }
            else
            {
                string mensaje = "No tengo saldo suficiente como para darte 5";
                string titulo = "Bob dice...";
                MessageBox.Show(mensaje, titulo);
            }
        }
    }
}
