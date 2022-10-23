﻿using ProyectoAutomotriz.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAutomotriz.Presentacion
{
    public partial class FrmConsulta7 : Form
    {
        

        public FrmConsulta7()
        {
            InitializeComponent();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txtAnio.Text,out _))
            {
                MessageBox.Show("No puede ingresar letras como año", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtAnio.Text.Length != 4)
            {
                MessageBox.Show("Debe ingresar un año de 4 digitos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string sp = "SP_VENDEDORES_DEBAJO_PROMEDIO";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro ("@Anio", txtAnio.Text));
            dgvConsulta7.Rows.Clear();
            DataTable DT = HelperDB.ObtenerInstancia().ConsultarSp(sp, lst);
            
            foreach(DataRow fila in DT.Rows)
            {
                dgvConsulta7.Rows.Add(new object[] { fila["FACTURA NRO"].ToString(),
                fila["LEGAJO"].ToString(),
                fila["NOMBRE"].ToString(),
                fila["FECHA"].ToString(),
                fila["IMPORTE TOTAL"].ToString(),
                fila["PROMEDIO ANUAL GENERAL"].ToString()}) ;
            }
        }

        private void FrmConsulta7_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvConsulta7.Rows.Clear();
            txtAnio.Text = string.Empty;
        }
    }
}
