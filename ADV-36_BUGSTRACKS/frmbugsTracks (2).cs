using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADV_36_BUGSTRACKS
{
    public partial class frmbugsTracks : Form
    {
        /// <summary>
        /// abstract: não permite nova instancia, apenas ser herdadas 
        /// </summary>
       
        public frmbugsTracks()
        {
            InitializeComponent();
        }



        // cria uma nova instancia da classe setor 
        private Setor setor = new Setor();

        // cria um nova instancia da classe Computadores 
        private Computador computador = new Computador();

        // cria uma nova instancia da classe usuario 
        private Usuario usuario = new Usuario();


        private void frmbugsTracks_Load(object sender, EventArgs e)
        {
            try
            {
                // preencha a combox  (setores) 
                this.setor.GetSetores(this.bugstracksDataSet); 

                // preenche os setores o combox (computadores) 
                this.computador.GetComputadores(bugstracksDataSet);

                // prencher o combox (usuarios)
                this.usuario.GetUsuarios(bugstracksDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbComputadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cmbComputadores.Items[cmbComputadores.SelectedIndex].ToString());
        }
    }
}
