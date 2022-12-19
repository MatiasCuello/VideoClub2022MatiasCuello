
namespace VideoClub.Windows
{
    partial class frmPeliculasAE
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PeliculaLabel = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GenerosComboBox = new System.Windows.Forms.ComboBox();
            this.DuracionTextBox = new System.Windows.Forms.TextBox();
            this.TituloTextBox = new System.Windows.Forms.TextBox();
            this.FechaIncorporacionLabel = new System.Windows.Forms.Label();
            this.GenerosLabel = new System.Windows.Forms.Label();
            this.DuracionLabel = new System.Windows.Forms.Label();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.EstadosComboBox = new System.Windows.Forms.ComboBox();
            this.EstadosLabel = new System.Windows.Forms.Label();
            this.SoportesComboBox = new System.Windows.Forms.ComboBox();
            this.CalificacionesComboBox = new System.Windows.Forms.ComboBox();
            this.SoportesLabel = new System.Windows.Forms.Label();
            this.CalificacionLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.OkButton);
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.PeliculaLabel);
            this.panel1.Location = new System.Drawing.Point(422, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 258);
            this.panel1.TabIndex = 213;
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.White;
            this.OkButton.Image = global::VideoClub.Windows.Properties.Resources.OK;
            this.OkButton.Location = new System.Drawing.Point(18, 127);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(94, 64);
            this.OkButton.TabIndex = 8;
            this.OkButton.Text = "OK";
            this.OkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.White;
            this.CancelButton.Image = global::VideoClub.Windows.Properties.Resources.Cancelar;
            this.CancelButton.Location = new System.Drawing.Point(140, 127);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 64);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PeliculaLabel
            // 
            this.PeliculaLabel.AutoSize = true;
            this.PeliculaLabel.Font = new System.Drawing.Font("Elephant", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeliculaLabel.Location = new System.Drawing.Point(14, 30);
            this.PeliculaLabel.Name = "PeliculaLabel";
            this.PeliculaLabel.Size = new System.Drawing.Size(226, 20);
            this.PeliculaLabel.TabIndex = 183;
            this.PeliculaLabel.Text = "DATOS DE LA PELICULA";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Location = new System.Drawing.Point(138, 74);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(250, 20);
            this.FechaDateTimePicker.TabIndex = 212;
            // 
            // GenerosComboBox
            // 
            this.GenerosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenerosComboBox.FormattingEnabled = true;
            this.GenerosComboBox.Location = new System.Drawing.Point(138, 46);
            this.GenerosComboBox.Name = "GenerosComboBox";
            this.GenerosComboBox.Size = new System.Drawing.Size(250, 21);
            this.GenerosComboBox.TabIndex = 197;
            // 
            // DuracionTextBox
            // 
            this.DuracionTextBox.Location = new System.Drawing.Point(138, 127);
            this.DuracionTextBox.MaxLength = 100;
            this.DuracionTextBox.Name = "DuracionTextBox";
            this.DuracionTextBox.Size = new System.Drawing.Size(250, 20);
            this.DuracionTextBox.TabIndex = 198;
            // 
            // TituloTextBox
            // 
            this.TituloTextBox.Location = new System.Drawing.Point(150, 41);
            this.TituloTextBox.MaxLength = 100;
            this.TituloTextBox.Name = "TituloTextBox";
            this.TituloTextBox.Size = new System.Drawing.Size(250, 20);
            this.TituloTextBox.TabIndex = 195;
            // 
            // FechaIncorporacionLabel
            // 
            this.FechaIncorporacionLabel.AutoSize = true;
            this.FechaIncorporacionLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.FechaIncorporacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaIncorporacionLabel.Location = new System.Drawing.Point(28, 78);
            this.FechaIncorporacionLabel.Name = "FechaIncorporacionLabel";
            this.FechaIncorporacionLabel.Size = new System.Drawing.Size(97, 16);
            this.FechaIncorporacionLabel.TabIndex = 201;
            this.FechaIncorporacionLabel.Text = "Fecha Incor.:";
            // 
            // GenerosLabel
            // 
            this.GenerosLabel.AutoSize = true;
            this.GenerosLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.GenerosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerosLabel.Location = new System.Drawing.Point(28, 51);
            this.GenerosLabel.Name = "GenerosLabel";
            this.GenerosLabel.Size = new System.Drawing.Size(63, 16);
            this.GenerosLabel.TabIndex = 202;
            this.GenerosLabel.Text = "Genero:";
            // 
            // DuracionLabel
            // 
            this.DuracionLabel.AutoSize = true;
            this.DuracionLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.DuracionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DuracionLabel.Location = new System.Drawing.Point(28, 131);
            this.DuracionLabel.Name = "DuracionLabel";
            this.DuracionLabel.Size = new System.Drawing.Size(108, 16);
            this.DuracionLabel.TabIndex = 200;
            this.DuracionLabel.Text = "Duracion(min):";
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.TituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.Location = new System.Drawing.Point(28, 20);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(51, 16);
            this.TituloLabel.TabIndex = 205;
            this.TituloLabel.Text = "Titulo:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.ActivoCheckBox);
            this.panel2.Controls.Add(this.EstadosComboBox);
            this.panel2.Controls.Add(this.EstadosLabel);
            this.panel2.Controls.Add(this.DuracionTextBox);
            this.panel2.Controls.Add(this.DuracionLabel);
            this.panel2.Controls.Add(this.FechaDateTimePicker);
            this.panel2.Controls.Add(this.GenerosComboBox);
            this.panel2.Controls.Add(this.SoportesComboBox);
            this.panel2.Controls.Add(this.CalificacionesComboBox);
            this.panel2.Controls.Add(this.TituloLabel);
            this.panel2.Controls.Add(this.FechaIncorporacionLabel);
            this.panel2.Controls.Add(this.SoportesLabel);
            this.panel2.Controls.Add(this.CalificacionLabel);
            this.panel2.Controls.Add(this.GenerosLabel);
            this.panel2.Location = new System.Drawing.Point(12, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 258);
            this.panel2.TabIndex = 214;
            // 
            // ActivoCheckBox
            // 
            this.ActivoCheckBox.AutoSize = true;
            this.ActivoCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ActivoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivoCheckBox.Location = new System.Drawing.Point(25, 217);
            this.ActivoCheckBox.Name = "ActivoCheckBox";
            this.ActivoCheckBox.Size = new System.Drawing.Size(70, 20);
            this.ActivoCheckBox.TabIndex = 215;
            this.ActivoCheckBox.Text = "Activo";
            this.ActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // EstadosComboBox
            // 
            this.EstadosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstadosComboBox.FormattingEnabled = true;
            this.EstadosComboBox.Location = new System.Drawing.Point(138, 100);
            this.EstadosComboBox.Name = "EstadosComboBox";
            this.EstadosComboBox.Size = new System.Drawing.Size(250, 21);
            this.EstadosComboBox.TabIndex = 213;
            // 
            // EstadosLabel
            // 
            this.EstadosLabel.AutoSize = true;
            this.EstadosLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.EstadosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadosLabel.Location = new System.Drawing.Point(28, 105);
            this.EstadosLabel.Name = "EstadosLabel";
            this.EstadosLabel.Size = new System.Drawing.Size(61, 16);
            this.EstadosLabel.TabIndex = 214;
            this.EstadosLabel.Text = "Estado:";
            // 
            // SoportesComboBox
            // 
            this.SoportesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SoportesComboBox.FormattingEnabled = true;
            this.SoportesComboBox.Location = new System.Drawing.Point(138, 182);
            this.SoportesComboBox.Name = "SoportesComboBox";
            this.SoportesComboBox.Size = new System.Drawing.Size(250, 21);
            this.SoportesComboBox.TabIndex = 5;
            // 
            // CalificacionesComboBox
            // 
            this.CalificacionesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CalificacionesComboBox.FormattingEnabled = true;
            this.CalificacionesComboBox.Location = new System.Drawing.Point(138, 153);
            this.CalificacionesComboBox.Name = "CalificacionesComboBox";
            this.CalificacionesComboBox.Size = new System.Drawing.Size(250, 21);
            this.CalificacionesComboBox.TabIndex = 5;
            // 
            // SoportesLabel
            // 
            this.SoportesLabel.AutoSize = true;
            this.SoportesLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.SoportesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoportesLabel.Location = new System.Drawing.Point(28, 187);
            this.SoportesLabel.Name = "SoportesLabel";
            this.SoportesLabel.Size = new System.Drawing.Size(67, 16);
            this.SoportesLabel.TabIndex = 182;
            this.SoportesLabel.Text = "Soporte:";
            // 
            // CalificacionLabel
            // 
            this.CalificacionLabel.AutoSize = true;
            this.CalificacionLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.CalificacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalificacionLabel.Location = new System.Drawing.Point(28, 158);
            this.CalificacionLabel.Name = "CalificacionLabel";
            this.CalificacionLabel.Size = new System.Drawing.Size(93, 16);
            this.CalificacionLabel.TabIndex = 182;
            this.CalificacionLabel.Text = "Calificacion:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPeliculasAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 291);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TituloTextBox);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(700, 330);
            this.MinimumSize = new System.Drawing.Size(700, 330);
            this.Name = "frmPeliculasAE";
            this.Text = "frmPeliculasAE";
            this.Load += new System.EventHandler(this.frmPeliculasAE_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label PeliculaLabel;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.ComboBox GenerosComboBox;
        private System.Windows.Forms.TextBox DuracionTextBox;
        private System.Windows.Forms.TextBox TituloTextBox;
        private System.Windows.Forms.Label FechaIncorporacionLabel;
        private System.Windows.Forms.Label GenerosLabel;
        private System.Windows.Forms.Label DuracionLabel;
        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CalificacionesComboBox;
        private System.Windows.Forms.Label CalificacionLabel;
        private System.Windows.Forms.ComboBox EstadosComboBox;
        private System.Windows.Forms.Label EstadosLabel;
        private System.Windows.Forms.ComboBox SoportesComboBox;
        private System.Windows.Forms.Label SoportesLabel;
        private System.Windows.Forms.CheckBox ActivoCheckBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}