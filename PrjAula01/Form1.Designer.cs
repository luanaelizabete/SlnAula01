namespace PrjAula01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            checkBox1 = new CheckBox();
            message = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtLogin
            // 
            txtLogin.BackColor = SystemColors.ButtonFace;
            txtLogin.Location = new Point(323, 116);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(100, 23);
            txtLogin.TabIndex = 1;
            txtLogin.TextChanged += textBox1_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.ButtonFace;
            txtSenha.Location = new Point(323, 186);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 2;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.SlateBlue;
            button1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.InfoText;
            button1.Location = new Point(339, 260);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateBlue;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Forte", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(311, 27);
            label1.Name = "label1";
            label1.Size = new Size(112, 43);
            label1.TabIndex = 4;
            label1.Text = "Login ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSlateBlue;
            label2.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(211, 116);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 5;
            label2.Text = "Usuário: \r\n";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkSlateBlue;
            label3.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(225, 186);
            label3.Name = "label3";
            label3.Size = new Size(77, 23);
            label3.TabIndex = 6;
            label3.Text = "Senha: ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackgroundImageLayout = ImageLayout.Stretch;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Indeterminate;
            checkBox1.Cursor = Cursors.IBeam;
            checkBox1.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(12, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(88, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Cadastre-se";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // message
            // 
            message.AutoSize = true;
            message.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            message.ForeColor = Color.Indigo;
            message.Location = new Point(339, 333);
            message.Name = "message";
            message.Size = new Size(77, 15);
            message.TabIndex = 8;
            message.Text = "Mensagem";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(message);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Name = "Form1";
            Text = "Hello World 2";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ErrorProvider errorProvider1;
        private CheckBox checkBox1;
        private Label message;
    }
}