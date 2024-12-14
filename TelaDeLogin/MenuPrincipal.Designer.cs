namespace TelaDeLogin
{
    partial class MenuPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem medicamentosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem pagamentosToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem relatoriosToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private Button btnMedicamento;
        private Button btnSair;
        

        private void InitializeComponent()
        {
            this.menuStrip1 = new MenuStrip();
            this.cadastroToolStripMenuItem = new ToolStripMenuItem();
            this.medicamentosToolStripMenuItem = new ToolStripMenuItem();
            this.clientesToolStripMenuItem = new ToolStripMenuItem();
            this.pagamentosToolStripMenuItem = new ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new ToolStripMenuItem();
            this.vendasToolStripMenuItem = new ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new ToolStripMenuItem();
            this.btnMedicamento = new Button();
            this.btnSair = new Button();

            // MenuStrip
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
                this.cadastroToolStripMenuItem,
                this.relatoriosToolStripMenuItem
            });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);

            // Cadastro
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                this.medicamentosToolStripMenuItem,
                this.clientesToolStripMenuItem,
                this.pagamentosToolStripMenuItem,
                this.usuarioToolStripMenuItem
            });
            this.cadastroToolStripMenuItem.Text = "Cadastro";

            // Medicamentos
            this.medicamentosToolStripMenuItem.Text = "Medicamentos";

            // Clientes
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new EventHandler(this.clientesToolStripMenuItem_Click);

            // Meio de Pagamento
            this.pagamentosToolStripMenuItem.Text = "Meio de Pagamento";

            // Usuario
            this.usuarioToolStripMenuItem.Text = "Usuário";

            // Relatórios
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                this.vendasToolStripMenuItem,
                this.estoqueToolStripMenuItem
            });
            this.relatoriosToolStripMenuItem.Text = "Relatórios";

            // Vendas
            this.vendasToolStripMenuItem.Text = "Vendas";

            // Estoque
            this.estoqueToolStripMenuItem.Text = "Estoque";

            // Botão Sair
            this.btnSair.Location = new System.Drawing.Point(10, 400);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 30);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new EventHandler(this.btnSair_Click);

            // MenuPrincipal
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSair);
            this.MainMenuStrip = this.menuStrip1;
            this.Text = "Menu Principal";
            this.ClientSize = new System.Drawing.Size(800, 450);
        }
    }
}
