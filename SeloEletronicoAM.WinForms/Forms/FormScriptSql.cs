using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SeloEletronicoAM.WinForms.Forms
{
    public partial class FormScriptSql : Form
    {
        public FormScriptSql()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string dtInicial = dtpDataInicial.Value.ToString("yyyy-MM-dd");
            string dtFinal = dtpDataFinal.Value.ToString("yyyy-MM-dd");

            string sql = $@"SELECT 
	                        SelNumero AS codSelo,
	                        SelValorAto AS emolumento,
	                        SelValorFunjeanextrajudicial AS funetj,
	                        SelValorFundpam AS fundpam, 
	                        SelValorFundpge AS fundpge, 
	                        SelValorFunjeanrcpnsd AS farpam,
	                        SelValorIssqn AS iss,
	                        SelValorSelo AS valorSelo,
	                        SelIsento AS isento
                        FROM SelSelo
                        WHERE SelDataUtilizacao BETWEEN CONVERT(datetime, '{dtInicial}', 102)
                        AND CONVERT(datetime, '{dtInicial}', 102)";

            txtResultado.Text = sql;
        }
    }
}
