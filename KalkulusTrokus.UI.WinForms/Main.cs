using KalkulusTrokus.Core;
using KalkulusTrokus.Core.Request;
using KalkulusTrokus.Core.Response;
using KalkulusTrokus.UI.WinForms.Model;
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

namespace KalkulusTrokus.UI.WinForms
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Sobre sobre = new Sobre();
			sobre.ShowDialog();
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void UxBtnKalkular_Click(object sender, EventArgs e)
		{
			try
			{
				long productAmount = long.Parse(UxTxtPrecoProduto.Text);
				long paidAmount = long.Parse(UxTxtValorPago.Text);

				KalkulusTrokusManager kalkulusTrokusManagerInstance = new KalkulusTrokusManager();

				CalculateTrokusRequest calculateTrokusRequest = new CalculateTrokusRequest(productAmount, paidAmount);

				CalculateTrokusResponse response = kalkulusTrokusManagerInstance.CalculateTrokus(calculateTrokusRequest);

				if (response.IsValid == false)
				{
					ClearControls();

					foreach (Report rep in response.Reports)
					{
						UxLstTrocoDetalhado.Items.Add("Message: " + rep.Message + ". Regarding field: " + rep.Field);
					}
				}
				else
				{
					Change change = response.Change;

					ClearControls();

					foreach (ItemWithMonetaryValueWithQtd item in GroupItens(change.ItemWithMonetaryValueCollection))
					{
						UxLstTrocoDetalhado.Items.Add(string.Format("{0} {1}, {2}", item.Qnt, item.Name, FormatValue(item.Value)));
					}

					UxTxtTrocoTotal.Text = FormatValue(change.ChangeAmount);
				}
			}
			catch (Exception) //Todo: Melhorar
			{
				//Todo: Melhorar
				MessageBox.Show("Valores inválidos!", "Erro");
				ClearControls();
			}
		}

		private IEnumerable<ItemWithMonetaryValueWithQtd> GroupItens(IEnumerable<ItemWithMonetaryValue> itemWithMonetaryValueCollection)
		{
			return from c in itemWithMonetaryValueCollection
				   group c by new { c.Name, c.AmountInCents } into g
				   select new ItemWithMonetaryValueWithQtd { Qnt = g.Count(), Value = g.Key.AmountInCents, Name= g.Key.Name };
		}

		private void ClearControls()
		{
			UxLstTrocoDetalhado.Items.Clear();
			UxTxtTrocoTotal.Text = "";
		}

		private string FormatValue(long value)
		{
			return (value / (decimal)100).ToString("C", new CultureInfo("pt-BR"));
		}

		private void AllowOnlyDigits_OnKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = ((e.KeyChar == '\b' || e.KeyChar == '-' || char.IsDigit(e.KeyChar) == true) == false);
		}

		private void UxTxtValorPago_KeyUp(object sender, KeyEventArgs e)
		{

		}
	}
}

