namespace Reconocimiento_facial
{
    partial class Registrar
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.btn_detectar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_loadImgsBD = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lblNumeroDetect = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_close = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_minimize = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(12, 34);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(400, 300);
            this.imageBoxFrameGrabber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxFrameGrabber.TabIndex = 27;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.White;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_agregar.Location = new System.Drawing.Point(6, 430);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(208, 35);
            this.btn_agregar.TabIndex = 29;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Matricula:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_nombre.Location = new System.Drawing.Point(81, 375);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(133, 23);
            this.txt_nombre.TabIndex = 32;
            // 
            // txt_codigo
            // 
            this.txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_codigo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_codigo.Location = new System.Drawing.Point(81, 404);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(133, 23);
            this.txt_codigo.TabIndex = 33;
            // 
            // btn_detectar
            // 
            this.btn_detectar.BackColor = System.Drawing.Color.White;
            this.btn_detectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_detectar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detectar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_detectar.Location = new System.Drawing.Point(12, 340);
            this.btn_detectar.Name = "btn_detectar";
            this.btn_detectar.Size = new System.Drawing.Size(208, 35);
            this.btn_detectar.TabIndex = 34;
            this.btn_detectar.Text = "Detectar";
            this.btn_detectar.UseVisualStyleBackColor = false;
            this.btn_detectar.Click += new System.EventHandler(this.btn_detectar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.imageBox2);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 517);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "label4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ultimo);
            this.groupBox2.Controls.Add(this.btn_loadImgsBD);
            this.groupBox2.Controls.Add(this.btn_anterior);
            this.groupBox2.Controls.Add(this.btn_siguiente);
            this.groupBox2.Controls.Add(this.btn_primero);
            this.groupBox2.Location = new System.Drawing.Point(6, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 41);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.BackColor = System.Drawing.Color.Transparent;
            this.btn_ultimo.FlatAppearance.BorderSize = 0;
            this.btn_ultimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ultimo.ForeColor = System.Drawing.Color.White;
            this.btn_ultimo.Location = new System.Drawing.Point(166, 11);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(35, 23);
            this.btn_ultimo.TabIndex = 38;
            this.btn_ultimo.Text = ">>I";
            this.btn_ultimo.UseVisualStyleBackColor = false;
            this.btn_ultimo.Click += new System.EventHandler(this.btn_ultimo_Click);
            // 
            // btn_loadImgsBD
            // 
            this.btn_loadImgsBD.FlatAppearance.BorderSize = 0;
            this.btn_loadImgsBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadImgsBD.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadImgsBD.Location = new System.Drawing.Point(86, 11);
            this.btn_loadImgsBD.Name = "btn_loadImgsBD";
            this.btn_loadImgsBD.Size = new System.Drawing.Size(35, 23);
            this.btn_loadImgsBD.TabIndex = 39;
            this.btn_loadImgsBD.Text = "...";
            this.btn_loadImgsBD.UseVisualStyleBackColor = true;
            this.btn_loadImgsBD.Click += new System.EventHandler(this.btn_loadImgsBD_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.BackColor = System.Drawing.Color.Transparent;
            this.btn_anterior.FlatAppearance.BorderSize = 0;
            this.btn_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anterior.ForeColor = System.Drawing.Color.White;
            this.btn_anterior.Location = new System.Drawing.Point(46, 11);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(35, 23);
            this.btn_anterior.TabIndex = 38;
            this.btn_anterior.Text = "<<";
            this.btn_anterior.UseVisualStyleBackColor = false;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.BackColor = System.Drawing.Color.Transparent;
            this.btn_siguiente.FlatAppearance.BorderSize = 0;
            this.btn_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_siguiente.ForeColor = System.Drawing.Color.White;
            this.btn_siguiente.Location = new System.Drawing.Point(126, 11);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(35, 23);
            this.btn_siguiente.TabIndex = 38;
            this.btn_siguiente.Text = ">>";
            this.btn_siguiente.UseVisualStyleBackColor = false;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_primero
            // 
            this.btn_primero.BackColor = System.Drawing.Color.Transparent;
            this.btn_primero.FlatAppearance.BorderSize = 0;
            this.btn_primero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_primero.ForeColor = System.Drawing.Color.White;
            this.btn_primero.Location = new System.Drawing.Point(6, 11);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(35, 23);
            this.btn_primero.TabIndex = 38;
            this.btn_primero.Text = "I<<";
            this.btn_primero.UseVisualStyleBackColor = false;
            this.btn_primero.Click += new System.EventHandler(this.btn_primero_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(6, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.BackColor = System.Drawing.Color.White;
            this.imageBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox2.Location = new System.Drawing.Point(6, 22);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(208, 150);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox2.TabIndex = 36;
            this.imageBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(6, 471);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 35);
            this.button3.TabIndex = 34;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblNumeroDetect
            // 
            this.lblNumeroDetect.AutoSize = true;
            this.lblNumeroDetect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblNumeroDetect.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDetect.ForeColor = System.Drawing.Color.White;
            this.lblNumeroDetect.Location = new System.Drawing.Point(145, 319);
            this.lblNumeroDetect.Name = "lblNumeroDetect";
            this.lblNumeroDetect.Size = new System.Drawing.Size(15, 17);
            this.lblNumeroDetect.TabIndex = 37;
            this.lblNumeroDetect.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Rostros detectados:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(12, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 35);
            this.button1.TabIndex = 42;
            this.button1.Text = "Desconectar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Navy;
            this.menuStrip1.Font = new System.Drawing.Font("Webdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_close,
            this.btn_minimize});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(668, 27);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // btn_close
            // 
            this.btn_close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_close.ForeColor = System.Drawing.Color.LightYellow;
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(33, 23);
            this.btn_close.Text = "r";
            this.btn_close.ToolTipText = "Cerrar";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_minimize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_minimize.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_minimize.ForeColor = System.Drawing.Color.LightYellow;
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(34, 23);
            this.btn_minimize.Text = "0";
            this.btn_minimize.ToolTipText = "Minimizar";
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Navy;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Reconocimiento Facial Estufiantil";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(447, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 517);
            this.panel1.TabIndex = 58;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(276, 29);
            this.button2.TabIndex = 59;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(668, 544);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumeroDetect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.imageBoxFrameGrabber);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_detectar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.Resgistrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Button btn_detectar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumeroDetect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.Button btn_loadImgsBD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_close;
        private System.Windows.Forms.ToolStripMenuItem btn_minimize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}

