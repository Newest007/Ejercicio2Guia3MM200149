
namespace Ejercicio2___Guía3_MM200149
{
    partial class Form1
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
            this.gbxnuevoalum = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcalificaciones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmateria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcarnet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxlistado = new System.Windows.Forms.GroupBox();
            this.gbxreporte = new System.Windows.Forms.GroupBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnlistado = new System.Windows.Forms.Button();
            this.btnreporte = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgestudiantes = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.dtgreporte = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.gbxnuevoalum.SuspendLayout();
            this.gbxlistado.SuspendLayout();
            this.gbxreporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgestudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgreporte)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxnuevoalum
            // 
            this.gbxnuevoalum.Controls.Add(this.button2);
            this.gbxnuevoalum.Controls.Add(this.button1);
            this.gbxnuevoalum.Controls.Add(this.txtcalificaciones);
            this.gbxnuevoalum.Controls.Add(this.label5);
            this.gbxnuevoalum.Controls.Add(this.txtmateria);
            this.gbxnuevoalum.Controls.Add(this.label4);
            this.gbxnuevoalum.Controls.Add(this.txtcarnet);
            this.gbxnuevoalum.Controls.Add(this.label3);
            this.gbxnuevoalum.Controls.Add(this.txtapellido);
            this.gbxnuevoalum.Controls.Add(this.label2);
            this.gbxnuevoalum.Controls.Add(this.txtnombre);
            this.gbxnuevoalum.Controls.Add(this.label1);
            this.gbxnuevoalum.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxnuevoalum.Location = new System.Drawing.Point(20, 108);
            this.gbxnuevoalum.Name = "gbxnuevoalum";
            this.gbxnuevoalum.Size = new System.Drawing.Size(259, 452);
            this.gbxnuevoalum.TabIndex = 0;
            this.gbxnuevoalum.TabStop = false;
            this.gbxnuevoalum.Text = "Ingresar un nuevo estudiante";
            this.gbxnuevoalum.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ocultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtcalificaciones
            // 
            this.txtcalificaciones.Location = new System.Drawing.Point(55, 358);
            this.txtcalificaciones.MaxLength = 4;
            this.txtcalificaciones.Name = "txtcalificaciones";
            this.txtcalificaciones.Size = new System.Drawing.Size(127, 30);
            this.txtcalificaciones.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Calificacion final";
            // 
            // txtmateria
            // 
            this.txtmateria.Location = new System.Drawing.Point(55, 284);
            this.txtmateria.MaxLength = 15;
            this.txtmateria.Name = "txtmateria";
            this.txtmateria.Size = new System.Drawing.Size(127, 30);
            this.txtmateria.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Materia cursada (Utilize el acronimo)";
            // 
            // txtcarnet
            // 
            this.txtcarnet.Location = new System.Drawing.Point(55, 63);
            this.txtcarnet.MaxLength = 9;
            this.txtcarnet.Name = "txtcarnet";
            this.txtcarnet.Size = new System.Drawing.Size(127, 30);
            this.txtcarnet.TabIndex = 5;
            this.txtcarnet.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Carnet del alumno";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(55, 208);
            this.txtapellido.MaxLength = 10;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(127, 30);
            this.txtapellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido del alumno";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(55, 134);
            this.txtnombre.MaxLength = 10;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(127, 30);
            this.txtnombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del alumno";
            // 
            // gbxlistado
            // 
            this.gbxlistado.AutoSize = true;
            this.gbxlistado.Controls.Add(this.button3);
            this.gbxlistado.Controls.Add(this.dtgestudiantes);
            this.gbxlistado.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxlistado.Location = new System.Drawing.Point(291, 128);
            this.gbxlistado.Name = "gbxlistado";
            this.gbxlistado.Size = new System.Drawing.Size(273, 394);
            this.gbxlistado.TabIndex = 1;
            this.gbxlistado.TabStop = false;
            this.gbxlistado.Text = "Listado de estudiantes Inscritos";
            this.gbxlistado.Visible = false;
            this.gbxlistado.Enter += new System.EventHandler(this.gbxlistado_Enter);
            // 
            // gbxreporte
            // 
            this.gbxreporte.Controls.Add(this.button4);
            this.gbxreporte.Controls.Add(this.dtgreporte);
            this.gbxreporte.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxreporte.Location = new System.Drawing.Point(570, 128);
            this.gbxreporte.Name = "gbxreporte";
            this.gbxreporte.Size = new System.Drawing.Size(259, 394);
            this.gbxreporte.TabIndex = 2;
            this.gbxreporte.TabStop = false;
            this.gbxreporte.Text = "Reporte de estudiantes";
            this.gbxreporte.Visible = false;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Location = new System.Drawing.Point(44, 69);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(216, 33);
            this.btnnuevo.TabIndex = 3;
            this.btnnuevo.Text = "Ingresar un nuevo alumno";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnlistado
            // 
            this.btnlistado.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistado.Location = new System.Drawing.Point(314, 89);
            this.btnlistado.Name = "btnlistado";
            this.btnlistado.Size = new System.Drawing.Size(216, 33);
            this.btnlistado.TabIndex = 4;
            this.btnlistado.Text = "Ver listado de estudiantes";
            this.btnlistado.UseVisualStyleBackColor = true;
            this.btnlistado.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnreporte
            // 
            this.btnreporte.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreporte.Location = new System.Drawing.Point(585, 89);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(216, 33);
            this.btnreporte.TabIndex = 5;
            this.btnreporte.Text = "Reporte estudiantes";
            this.btnreporte.UseVisualStyleBackColor = true;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(298, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 33);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ejercicio 2 MM200149";
            // 
            // dtgestudiantes
            // 
            this.dtgestudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgestudiantes.Enabled = false;
            this.dtgestudiantes.Location = new System.Drawing.Point(15, 29);
            this.dtgestudiantes.Name = "dtgestudiantes";
            this.dtgestudiantes.ReadOnly = true;
            this.dtgestudiantes.Size = new System.Drawing.Size(239, 286);
            this.dtgestudiantes.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 41);
            this.button2.TabIndex = 11;
            this.button2.Text = "Ingresar datos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtgreporte
            // 
            this.dtgreporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgreporte.Location = new System.Drawing.Point(17, 32);
            this.dtgreporte.Name = "dtgreporte";
            this.dtgreporte.Size = new System.Drawing.Size(228, 286);
            this.dtgreporte.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(83, 334);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 31);
            this.button3.TabIndex = 11;
            this.button3.Text = "Ocultar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(74, 338);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 31);
            this.button4.TabIndex = 12;
            this.button4.Text = "Ocultar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 592);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnreporte);
            this.Controls.Add(this.btnlistado);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.gbxreporte);
            this.Controls.Add(this.gbxlistado);
            this.Controls.Add(this.gbxnuevoalum);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ejercicio 2 - Guía3 MM200149";
            this.gbxnuevoalum.ResumeLayout(false);
            this.gbxnuevoalum.PerformLayout();
            this.gbxlistado.ResumeLayout(false);
            this.gbxreporte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgestudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgreporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxnuevoalum;
        private System.Windows.Forms.TextBox txtcarnet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxlistado;
        private System.Windows.Forms.GroupBox gbxreporte;
        private System.Windows.Forms.TextBox txtcalificaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmateria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnlistado;
        private System.Windows.Forms.Button btnreporte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtgestudiantes;
        private System.Windows.Forms.DataGridView dtgreporte;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

