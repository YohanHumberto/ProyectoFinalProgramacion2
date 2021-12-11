
namespace WinFormsApp1.TiposEntidadesCRUD
{
    partial class FrmAddAndEditTiposEntidades
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
            this.LblTituloUser = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnRegGuardar = new System.Windows.Forms.Button();
            this.BtnRegCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.CbxEstado = new System.Windows.Forms.ComboBox();
            this.TbxComentario = new System.Windows.Forms.TextBox();
            this.CkbNoEliminable = new System.Windows.Forms.CheckBox();
            this.TbxIdTipoEntidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.TbxDescripcion = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTituloUser
            // 
            this.LblTituloUser.AutoSize = true;
            this.LblTituloUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LblTituloUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTituloUser.Font = new System.Drawing.Font("Segoe UI", 24.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LblTituloUser.Location = new System.Drawing.Point(60, 0);
            this.LblTituloUser.Name = "LblTituloUser";
            this.LblTituloUser.Size = new System.Drawing.Size(598, 73);
            this.LblTituloUser.TabIndex = 2;
            this.LblTituloUser.Text = "Tipos Entidades";
            this.LblTituloUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.BtnRegGuardar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnRegCancelar, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(60, 462);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(598, 69);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // BtnRegGuardar
            // 
            this.BtnRegGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRegGuardar.Location = new System.Drawing.Point(3, 3);
            this.BtnRegGuardar.Name = "BtnRegGuardar";
            this.BtnRegGuardar.Size = new System.Drawing.Size(592, 28);
            this.BtnRegGuardar.TabIndex = 0;
            this.BtnRegGuardar.Text = "Guardar";
            this.BtnRegGuardar.UseVisualStyleBackColor = true;
            this.BtnRegGuardar.Click += new System.EventHandler(this.BtnRegGuardar_Click);
            // 
            // BtnRegCancelar
            // 
            this.BtnRegCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRegCancelar.Location = new System.Drawing.Point(3, 37);
            this.BtnRegCancelar.Name = "BtnRegCancelar";
            this.BtnRegCancelar.Size = new System.Drawing.Size(592, 29);
            this.BtnRegCancelar.TabIndex = 0;
            this.BtnRegCancelar.Text = "Cancelar";
            this.BtnRegCancelar.UseVisualStyleBackColor = true;
            this.BtnRegCancelar.Click += new System.EventHandler(this.BtnRegCancelar_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.09524F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.90476F));
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.CbxEstado, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.TbxComentario, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.CkbNoEliminable, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.TbxIdTipoEntidad, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblLastName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TbxDescripcion, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(60, 76);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(598, 380);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Right;
            this.label15.Location = new System.Drawing.Point(215, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 76);
            this.label15.TabIndex = 52;
            this.label15.Text = "Estado:";
            // 
            // CbxEstado
            // 
            this.CbxEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CbxEstado.FormattingEnabled = true;
            this.CbxEstado.Location = new System.Drawing.Point(278, 231);
            this.CbxEstado.Name = "CbxEstado";
            this.CbxEstado.Size = new System.Drawing.Size(317, 28);
            this.CbxEstado.TabIndex = 53;
            // 
            // TbxComentario
            // 
            this.TbxComentario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbxComentario.Location = new System.Drawing.Point(278, 155);
            this.TbxComentario.Name = "TbxComentario";
            this.TbxComentario.Size = new System.Drawing.Size(317, 27);
            this.TbxComentario.TabIndex = 30;
            // 
            // CkbNoEliminable
            // 
            this.CkbNoEliminable.AutoSize = true;
            this.CkbNoEliminable.Location = new System.Drawing.Point(278, 307);
            this.CkbNoEliminable.Name = "CkbNoEliminable";
            this.CkbNoEliminable.Size = new System.Drawing.Size(121, 24);
            this.CkbNoEliminable.TabIndex = 0;
            this.CkbNoEliminable.Text = "NoEliminable";
            this.CkbNoEliminable.UseVisualStyleBackColor = true;
            this.CkbNoEliminable.CheckedChanged += new System.EventHandler(this.ChNoEliminable_CheckedChanged);
            // 
            // TbxIdTipoEntidad
            // 
            this.TbxIdTipoEntidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbxIdTipoEntidad.Location = new System.Drawing.Point(278, 79);
            this.TbxIdTipoEntidad.Name = "TbxIdTipoEntidad";
            this.TbxIdTipoEntidad.Size = new System.Drawing.Size(317, 27);
            this.TbxIdTipoEntidad.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Right;
            this.label10.Location = new System.Drawing.Point(168, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 76);
            this.label10.TabIndex = 16;
            this.label10.Text = "GrupoEntidad:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Right;
            this.label14.Location = new System.Drawing.Point(182, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 76);
            this.label14.TabIndex = 20;
            this.label14.Text = "Comentario:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLastName.Location = new System.Drawing.Point(182, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 76);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Descripcion:";
            // 
            // TbxDescripcion
            // 
            this.TbxDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbxDescripcion.Location = new System.Drawing.Point(278, 3);
            this.TbxDescripcion.Name = "TbxDescripcion";
            this.TbxDescripcion.Size = new System.Drawing.Size(317, 27);
            this.TbxDescripcion.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.759954F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.24004F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblTituloUser, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.90414F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.09586F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(753, 534);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.VisibleChanged += new System.EventHandler(this.tableLayoutPanel1_VisibleChanged);
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // FrmAddAndEditTiposEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 534);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmAddAndEditTiposEntidades";
            this.Text = "FrmAddAndEditTiposEntidades";
            this.Resize += new System.EventHandler(this.FrmAddAndEditTiposEntidades_Resize);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTituloUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnRegGuardar;
        private System.Windows.Forms.Button BtnRegCancelar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox TbxComentario;
        private System.Windows.Forms.TextBox TbxIdTipoEntidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox TbxDescripcion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox CkbNoEliminable;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CbxEstado;
    }
}