namespace PLANILLA_LOVERS
{
    partial class InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            iniciobtn = new Button();
            usuariotxt = new TextBox();
            contratxt = new TextBox();
            nuevousuariobtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 22.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(195, 29);
            label1.Name = "label1";
            label1.Size = new Size(410, 45);
            label1.TabIndex = 0;
            label1.Text = "INICIO DE SESIÓN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(174, 145);
            label2.Name = "label2";
            label2.Size = new Size(94, 22);
            label2.TabIndex = 1;
            label2.Text = "USUARIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(174, 208);
            label3.Name = "label3";
            label3.Size = new Size(141, 22);
            label3.TabIndex = 2;
            label3.Text = "CONTRASEÑA";
            // 
            // iniciobtn
            // 
            iniciobtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iniciobtn.Location = new Point(174, 308);
            iniciobtn.Name = "iniciobtn";
            iniciobtn.Size = new Size(94, 29);
            iniciobtn.TabIndex = 3;
            iniciobtn.Text = "INICIO";
            iniciobtn.UseVisualStyleBackColor = true;
            iniciobtn.Click += iniciobtn_Click;
            // 
            // usuariotxt
            // 
            usuariotxt.Location = new Point(340, 143);
            usuariotxt.Name = "usuariotxt";
            usuariotxt.Size = new Size(260, 27);
            usuariotxt.TabIndex = 5;
            // 
            // contratxt
            // 
            contratxt.Location = new Point(340, 203);
            contratxt.Name = "contratxt";
            contratxt.Size = new Size(260, 27);
            contratxt.TabIndex = 6;
            // 
            // nuevousuariobtn
            // 
            nuevousuariobtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nuevousuariobtn.Location = new Point(412, 308);
            nuevousuariobtn.Name = "nuevousuariobtn";
            nuevousuariobtn.Size = new Size(188, 29);
            nuevousuariobtn.TabIndex = 4;
            nuevousuariobtn.Text = "NUEVO USUARIO";
            nuevousuariobtn.UseVisualStyleBackColor = true;
            nuevousuariobtn.Click += nuevousuariobtn_Click;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(contratxt);
            Controls.Add(usuariotxt);
            Controls.Add(nuevousuariobtn);
            Controls.Add(iniciobtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InicioSesion";
            Text = "INICIO DE SESIÓN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button iniciobtn;
        private TextBox usuariotxt;
        private TextBox contratxt;
        private Button nuevousuariobtn;
    }
}
