namespace PLANILLA_LOVERS
{
    partial class NuevoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoUsuario));
            NewContratxt = new TextBox();
            NewUsertxt = new TextBox();
            Agregarbtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            RepNewContratxt = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // NewContratxt
            // 
            NewContratxt.Location = new Point(351, 245);
            NewContratxt.Name = "NewContratxt";
            NewContratxt.Size = new Size(260, 27);
            NewContratxt.TabIndex = 12;
            // 
            // NewUsertxt
            // 
            NewUsertxt.Location = new Point(351, 185);
            NewUsertxt.Name = "NewUsertxt";
            NewUsertxt.Size = new Size(260, 27);
            NewUsertxt.TabIndex = 11;
            // 
            // Agregarbtn
            // 
            Agregarbtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Agregarbtn.Location = new Point(310, 396);
            Agregarbtn.Name = "Agregarbtn";
            Agregarbtn.Size = new Size(188, 29);
            Agregarbtn.TabIndex = 10;
            Agregarbtn.Text = "AGREGAR";
            Agregarbtn.UseVisualStyleBackColor = true;
            Agregarbtn.Click += Agregarbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(185, 250);
            label3.Name = "label3";
            label3.Size = new Size(141, 22);
            label3.TabIndex = 9;
            label3.Text = "CONTRASEÑA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(185, 187);
            label2.Name = "label2";
            label2.Size = new Size(94, 22);
            label2.TabIndex = 8;
            label2.Text = "USUARIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 22.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(214, 71);
            label1.Name = "label1";
            label1.Size = new Size(373, 45);
            label1.TabIndex = 7;
            label1.Text = "NUEVO USUARIO";
            // 
            // RepNewContratxt
            // 
            RepNewContratxt.Location = new Point(351, 309);
            RepNewContratxt.Multiline = true;
            RepNewContratxt.Name = "RepNewContratxt";
            RepNewContratxt.Size = new Size(260, 27);
            RepNewContratxt.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(185, 305);
            label4.Name = "label4";
            label4.Size = new Size(141, 44);
            label4.TabIndex = 13;
            label4.Text = "REPETIR \r\nCONTRASEÑA";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NuevoUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(RepNewContratxt);
            Controls.Add(label4);
            Controls.Add(NewContratxt);
            Controls.Add(NewUsertxt);
            Controls.Add(Agregarbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NuevoUsuario";
            Text = "Nuevo Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NewContratxt;
        private TextBox NewUsertxt;
        private Button Agregarbtn;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox RepNewContratxt;
        private Label label4;
    }
}