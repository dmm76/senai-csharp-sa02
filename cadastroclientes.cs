using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class cadastroclientes : System.Windows.Forms.Form
    {
        public cadastroclientes()
        {
            InitializeComponent();
        }

        private void cadastroclientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbaCastroClienteDataSet.tbclientes'. Você pode movê-la ou removê-la conforme necessário.
            this.tbclientesTableAdapter.Fill(this.dbaCastroClienteDataSet.tbclientes);

        }

        private void tbclientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbclientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbaCastroClienteDataSet);

        }

        private void telefoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
