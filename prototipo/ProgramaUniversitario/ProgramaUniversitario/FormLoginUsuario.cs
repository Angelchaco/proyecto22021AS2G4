﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProgramaUniversitario
{
    public partial class FormLoginUsuario : Form
    {
        public FormLoginUsuario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string servidor = "server=den1.mysql2.gear.host; database=pruebauni; Uid=pruebauni; pwd=Sl00JJ~~iznm";
            MySqlConnection conexionBD = new MySqlConnection(servidor);
            conexionBD.Open();

            String consulta = "select Usuario, Pass from usuarios where Usuario='" + txtUsuario.Text + "' and Pass = '" + txtPass.Text + "'";
            MySqlCommand comando = new MySqlCommand(consulta, conexionBD);

            MySqlDataReader registros = comando.ExecuteReader();

            if (registros.Read())
            {
                MessageBox.Show(" Bienvenido " + txtUsuario.Text);
                Form frm = new Form3MenuAdministrador();
                frm.Show();
            }
            else
            {
                MessageBox.Show("¡Usuario o datos no existentes!");
            }


        }
    }
}
