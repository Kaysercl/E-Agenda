namespace E_Agenda.WinApp.Telas
{
    partial class TelaCadastroItens
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.ComboBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.Descricao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ListItens = new System.Windows.Forms.ListBox();
            this.tarefaselecionada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 23);
            this.textBox2.TabIndex = 1;
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Pendente ",
            "Concluido"});
            this.status.Location = new System.Drawing.Point(12, 153);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(140, 23);
            this.status.TabIndex = 2;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Location = new System.Drawing.Point(73, 14);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(37, 15);
            this.Titulo.TabIndex = 3;
            this.Titulo.Text = "Titulo";
            this.Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Descricao
            // 
            this.Descricao.AutoSize = true;
            this.Descricao.Location = new System.Drawing.Point(62, 71);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(58, 15);
            this.Descricao.TabIndex = 4;
            this.Descricao.Text = "Descrição";
            this.Descricao.Click += new System.EventHandler(this.Descricao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Status";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(201, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Gravar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(201, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ListItens
            // 
            this.ListItens.FormattingEnabled = true;
            this.ListItens.ItemHeight = 15;
            this.ListItens.Location = new System.Drawing.Point(12, 200);
            this.ListItens.Name = "ListItens";
            this.ListItens.Size = new System.Drawing.Size(136, 139);
            this.ListItens.TabIndex = 9;
            // 
            // tarefaselecionada
            // 
            this.tarefaselecionada.AutoSize = true;
            this.tarefaselecionada.Location = new System.Drawing.Point(201, 249);
            this.tarefaselecionada.Name = "tarefaselecionada";
            this.tarefaselecionada.Size = new System.Drawing.Size(38, 15);
            this.tarefaselecionada.TabIndex = 10;
            this.tarefaselecionada.Text = "label2";
            // 
            // TelaCadastroItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 364);
            this.Controls.Add(this.tarefaselecionada);
            this.Controls.Add(this.ListItens);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Descricao);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.status);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "TelaCadastroItens";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox ListItens;
        private System.Windows.Forms.Label tarefaselecionada;
    }
}