namespace KalkulusTrokus.UI.WinForms
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.UxTxtPrecoProduto = new System.Windows.Forms.TextBox();
			this.UxTxtValorPago = new System.Windows.Forms.TextBox();
			this.UxLblPrecoProduto = new System.Windows.Forms.Label();
			this.UxLblValorPago = new System.Windows.Forms.Label();
			this.UxLblTrocoDetalhado = new System.Windows.Forms.Label();
			this.UxTxtTrocoTotal = new System.Windows.Forms.TextBox();
			this.UxBtnKalkular = new System.Windows.Forms.Button();
			this.UxLstTrocoDetalhado = new System.Windows.Forms.ListBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.UxLblTrocoTotal = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// UxTxtPrecoProduto
			// 
			this.UxTxtPrecoProduto.Location = new System.Drawing.Point(26, 71);
			this.UxTxtPrecoProduto.Name = "UxTxtPrecoProduto";
			this.UxTxtPrecoProduto.Size = new System.Drawing.Size(169, 26);
			this.UxTxtPrecoProduto.TabIndex = 0;
			this.UxTxtPrecoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowOnlyDigits_OnKeyPress);
			// 
			// UxTxtValorPago
			// 
			this.UxTxtValorPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.UxTxtValorPago.Location = new System.Drawing.Point(235, 71);
			this.UxTxtValorPago.Name = "UxTxtValorPago";
			this.UxTxtValorPago.Size = new System.Drawing.Size(160, 26);
			this.UxTxtValorPago.TabIndex = 1;
			this.UxTxtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowOnlyDigits_OnKeyPress);
			// 
			// UxLblPrecoProduto
			// 
			this.UxLblPrecoProduto.AutoSize = true;
			this.UxLblPrecoProduto.Location = new System.Drawing.Point(22, 48);
			this.UxLblPrecoProduto.Name = "UxLblPrecoProduto";
			this.UxLblPrecoProduto.Size = new System.Drawing.Size(132, 20);
			this.UxLblPrecoProduto.TabIndex = 3;
			this.UxLblPrecoProduto.Text = "Preço do Produto";
			// 
			// UxLblValorPago
			// 
			this.UxLblValorPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.UxLblValorPago.AutoSize = true;
			this.UxLblValorPago.Location = new System.Drawing.Point(231, 48);
			this.UxLblValorPago.Name = "UxLblValorPago";
			this.UxLblValorPago.Size = new System.Drawing.Size(87, 20);
			this.UxLblValorPago.TabIndex = 3;
			this.UxLblValorPago.Text = "Valor Pago";
			// 
			// UxLblTrocoDetalhado
			// 
			this.UxLblTrocoDetalhado.AutoSize = true;
			this.UxLblTrocoDetalhado.Location = new System.Drawing.Point(22, 192);
			this.UxLblTrocoDetalhado.Name = "UxLblTrocoDetalhado";
			this.UxLblTrocoDetalhado.Size = new System.Drawing.Size(127, 20);
			this.UxLblTrocoDetalhado.TabIndex = 5;
			this.UxLblTrocoDetalhado.Text = "Troco Detalhado";
			// 
			// UxTxtTrocoTotal
			// 
			this.UxTxtTrocoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UxTxtTrocoTotal.Location = new System.Drawing.Point(26, 455);
			this.UxTxtTrocoTotal.Name = "UxTxtTrocoTotal";
			this.UxTxtTrocoTotal.ReadOnly = true;
			this.UxTxtTrocoTotal.Size = new System.Drawing.Size(369, 26);
			this.UxTxtTrocoTotal.TabIndex = 5;
			// 
			// UxBtnKalkular
			// 
			this.UxBtnKalkular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UxBtnKalkular.Location = new System.Drawing.Point(26, 126);
			this.UxBtnKalkular.Name = "UxBtnKalkular";
			this.UxBtnKalkular.Size = new System.Drawing.Size(369, 39);
			this.UxBtnKalkular.TabIndex = 2;
			this.UxBtnKalkular.Text = "Kalkulus Trokus";
			this.UxBtnKalkular.UseVisualStyleBackColor = true;
			this.UxBtnKalkular.Click += new System.EventHandler(this.UxBtnKalkular_Click);
			// 
			// UxLstTrocoDetalhado
			// 
			this.UxLstTrocoDetalhado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UxLstTrocoDetalhado.FormattingEnabled = true;
			this.UxLstTrocoDetalhado.ItemHeight = 20;
			this.UxLstTrocoDetalhado.Location = new System.Drawing.Point(26, 215);
			this.UxLstTrocoDetalhado.Name = "UxLstTrocoDetalhado";
			this.UxLstTrocoDetalhado.Size = new System.Drawing.Size(369, 204);
			this.UxLstTrocoDetalhado.TabIndex = 4;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.ajudaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(425, 33);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
			this.aboutToolStripMenuItem.Text = "&Arquivo";
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(126, 30);
			this.sairToolStripMenuItem.Text = "&Sair";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
			// 
			// ajudaToolStripMenuItem
			// 
			this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
			this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
			this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
			this.ajudaToolStripMenuItem.Text = "A&juda";
			// 
			// sobreToolStripMenuItem
			// 
			this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
			this.sobreToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
			this.sobreToolStripMenuItem.Text = "&Sobre...";
			this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
			// 
			// UxLblTrocoTotal
			// 
			this.UxLblTrocoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.UxLblTrocoTotal.AutoSize = true;
			this.UxLblTrocoTotal.Location = new System.Drawing.Point(22, 432);
			this.UxLblTrocoTotal.Name = "UxLblTrocoTotal";
			this.UxLblTrocoTotal.Size = new System.Drawing.Size(88, 20);
			this.UxLblTrocoTotal.TabIndex = 9;
			this.UxLblTrocoTotal.Text = "Troco Total";
			// 
			// Main
			// 
			this.AcceptButton = this.UxBtnKalkular;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(425, 515);
			this.Controls.Add(this.UxLblTrocoTotal);
			this.Controls.Add(this.UxLstTrocoDetalhado);
			this.Controls.Add(this.UxBtnKalkular);
			this.Controls.Add(this.UxLblTrocoDetalhado);
			this.Controls.Add(this.UxTxtTrocoTotal);
			this.Controls.Add(this.UxLblValorPago);
			this.Controls.Add(this.UxLblPrecoProduto);
			this.Controls.Add(this.UxTxtValorPago);
			this.Controls.Add(this.UxTxtPrecoProduto);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(951, 709);
			this.MinimumSize = new System.Drawing.Size(447, 571);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kalkulus Trokus";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox UxTxtPrecoProduto;
		private System.Windows.Forms.TextBox UxTxtValorPago;
		private System.Windows.Forms.Label UxLblPrecoProduto;
		private System.Windows.Forms.Label UxLblValorPago;
		private System.Windows.Forms.Label UxLblTrocoDetalhado;
		private System.Windows.Forms.TextBox UxTxtTrocoTotal;
		private System.Windows.Forms.Button UxBtnKalkular;
		private System.Windows.Forms.ListBox UxLstTrocoDetalhado;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
		private System.Windows.Forms.Label UxLblTrocoTotal;
	}
}

