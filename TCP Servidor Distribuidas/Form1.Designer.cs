
namespace TCP_Servidor_Distribuidas
{
    partial class Servidor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtMensage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lstClienteIP = new System.Windows.Forms.ListBox();
            this.LabelServidor = new System.Windows.Forms.Label();
            this.lbClientesConectados = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtIP.Location = new System.Drawing.Point(94, 12);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(220, 26);
            this.txtIP.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEnviar.Location = new System.Drawing.Point(109, 232);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(84, 30);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtInfo.Location = new System.Drawing.Point(94, 39);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(220, 156);
            this.txtInfo.TabIndex = 3;
            // 
            // txtMensage
            // 
            this.txtMensage.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtMensage.Location = new System.Drawing.Point(94, 200);
            this.txtMensage.Name = "txtMensage";
            this.txtMensage.Size = new System.Drawing.Size(220, 26);
            this.txtMensage.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(11, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mensaje";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnIniciar.Location = new System.Drawing.Point(213, 232);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(84, 30);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lstClienteIP
            // 
            this.lstClienteIP.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClienteIP.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lstClienteIP.FormattingEnabled = true;
            this.lstClienteIP.ItemHeight = 19;
            this.lstClienteIP.Location = new System.Drawing.Point(342, 39);
            this.lstClienteIP.Name = "lstClienteIP";
            this.lstClienteIP.Size = new System.Drawing.Size(240, 156);
            this.lstClienteIP.TabIndex = 7;
            // 
            // LabelServidor
            // 
            this.LabelServidor.AutoSize = true;
            this.LabelServidor.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelServidor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LabelServidor.Location = new System.Drawing.Point(13, 14);
            this.LabelServidor.Name = "LabelServidor";
            this.LabelServidor.Size = new System.Drawing.Size(75, 19);
            this.LabelServidor.TabIndex = 0;
            this.LabelServidor.Text = "Servidor";
            // 
            // lbClientesConectados
            // 
            this.lbClientesConectados.AutoSize = true;
            this.lbClientesConectados.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClientesConectados.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbClientesConectados.Location = new System.Drawing.Point(342, 14);
            this.lbClientesConectados.Name = "lbClientesConectados";
            this.lbClientesConectados.Size = new System.Drawing.Size(297, 19);
            this.lbClientesConectados.TabIndex = 8;
            this.lbClientesConectados.Text = "Numero De  Clientes IP Conectados:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(588, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Servidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(196)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(764, 271);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbClientesConectados);
            this.Controls.Add(this.lstClienteIP);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtMensage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.LabelServidor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Servidor";
            this.Text = "Servidor TCP";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtMensage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ListBox lstClienteIP;
        private System.Windows.Forms.Label LabelServidor;
        private System.Windows.Forms.Label lbClientesConectados;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

