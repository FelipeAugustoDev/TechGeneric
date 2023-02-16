using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechGeneric
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=WINDOWS10H2\\SQLEXPRESS;Initial Catalog=TECHGENERIC;Integrated Security=True");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txbCod.Enabled = false;
            comando.Connection = conn;
            LoadList();
            txbNome.Text = "felipe";
            txbEndereco.Text = "moro em casa";
            txbSexo.Text = "Masculino";
            txbSalario.Text = "3.000";
        }
        public void LoadList()
        {
            conn.Open();
            comando.CommandText = "select * from FUNCIONARIOS";
            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    lboCodigo.Items.Add(dr[0].ToString());
                    lboNome.Items.Add(dr[1].ToString());
                    lboEndereco.Items.Add(dr[2].ToString());
                    lboSexo.Items.Add(dr[3].ToString());
                    lboSalario.Items.Add(dr[4].ToString());
                }
                conn.Close();
            }
        }
        public void ClearList()
        {
            lboCodigo.Items.Clear();
            lboNome.Items.Clear();
            lboEndereco.Items.Clear();
            lboSexo.Items.Clear();
            lboSalario.Items.Clear();
        }
        public void SelectElements(object sender)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                lboCodigo.SelectedIndex = l.SelectedIndex;
                lboNome.SelectedIndex = l.SelectedIndex;
                lboEndereco.SelectedIndex = l.SelectedIndex;
                lboSexo.SelectedIndex = l.SelectedIndex;
                lboSalario.SelectedIndex = l.SelectedIndex;

                txbCod.Text = lboCodigo.SelectedItem.ToString();
                txbNome.Text = lboNome.SelectedItem.ToString();
                txbEndereco.Text = lboEndereco.SelectedItem.ToString();
                txbSexo.Text = lboSexo.SelectedItem.ToString();
                txbSalario.Text = lboSalario.SelectedItem.ToString();
            }
        }



        private void BtnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "insert into FUNCIONARIOS(nome, endereco, sexo, salario) values ('" + txbNome.Text + "','" + txbEndereco.Text + "','" + txbSexo.Text.ToUpper() + "','" + txbSalario.Text.Replace(",", ",") + "')";
           // comando.CommandText = "insert into FUNCIONARIOS(nome='" + txbNome.Text + "','" + txbEndereco.Text + "','" + txbSexo.Text + "','" + txbSalario.Text + "' where codigo='" + lboCodigo.Text.ToString();
            comando.ExecuteReader();
            conn.Close();
            ClearList();
            LoadList();
                       
           //USAR AQUELE TRATAMENTO PARA RECEBER O LOCAL DO SEXO PARA ARMAZENAR E CRIAR A MÉDIA
        }
        public void Elements()
        {
            //manipular dados para fazer a média e descobrir se é 10%, 15% ou 20%
        }

        private void lboCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectElements(sender);
        }
    }
}
