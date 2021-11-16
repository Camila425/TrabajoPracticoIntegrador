
namespace TrabajoPracticoLibro.Windows
{
    partial class FrmLibrosEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.NombreDelLibrotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EditorialcomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TemacomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PaginastextBox = new System.Windows.Forms.TextBox();
            this.ISBNtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AutortextBox = new System.Windows.Forms.TextBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.AyudaToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Del Libro";
            // 
            // NombreDelLibrotextBox
            // 
            this.NombreDelLibrotextBox.Location = new System.Drawing.Point(126, 43);
            this.NombreDelLibrotextBox.Name = "NombreDelLibrotextBox";
            this.NombreDelLibrotextBox.Size = new System.Drawing.Size(100, 20);
            this.NombreDelLibrotextBox.TabIndex = 1;
            this.AyudaToolTip.SetToolTip(this.NombreDelLibrotextBox, "Ingrese el Nombre Del Libro");
            this.NombreDelLibrotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreDelLibrotextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Editorial";
            // 
            // EditorialcomboBox
            // 
            this.EditorialcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditorialcomboBox.FormattingEnabled = true;
            this.EditorialcomboBox.Location = new System.Drawing.Point(126, 78);
            this.EditorialcomboBox.Name = "EditorialcomboBox";
            this.EditorialcomboBox.Size = new System.Drawing.Size(121, 21);
            this.EditorialcomboBox.TabIndex = 3;
            this.AyudaToolTip.SetToolTip(this.EditorialcomboBox, "Seleccione Una Editorial");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tema";
            // 
            // TemacomboBox
            // 
            this.TemacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TemacomboBox.FormattingEnabled = true;
            this.TemacomboBox.Location = new System.Drawing.Point(126, 117);
            this.TemacomboBox.Name = "TemacomboBox";
            this.TemacomboBox.Size = new System.Drawing.Size(121, 21);
            this.TemacomboBox.TabIndex = 5;
            this.AyudaToolTip.SetToolTip(this.TemacomboBox, "Seleccione Un Tema");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Paginas";
            // 
            // PaginastextBox
            // 
            this.PaginastextBox.Location = new System.Drawing.Point(126, 151);
            this.PaginastextBox.Name = "PaginastextBox";
            this.PaginastextBox.Size = new System.Drawing.Size(100, 20);
            this.PaginastextBox.TabIndex = 7;
            this.AyudaToolTip.SetToolTip(this.PaginastextBox, "Ingrese Las Paginas Del Libro");
            this.PaginastextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PaginastextBox_KeyPress);
            // 
            // ISBNtextBox
            // 
            this.ISBNtextBox.Location = new System.Drawing.Point(126, 194);
            this.ISBNtextBox.Name = "ISBNtextBox";
            this.ISBNtextBox.Size = new System.Drawing.Size(100, 20);
            this.ISBNtextBox.TabIndex = 9;
            this.AyudaToolTip.SetToolTip(this.ISBNtextBox, "Ingrese El ISBN");
            this.ISBNtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ISBNtextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ISBN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Autor";
            // 
            // AutortextBox
            // 
            this.AutortextBox.Location = new System.Drawing.Point(126, 243);
            this.AutortextBox.Name = "AutortextBox";
            this.AutortextBox.Size = new System.Drawing.Size(100, 20);
            this.AutortextBox.TabIndex = 12;
            this.AyudaToolTip.SetToolTip(this.AutortextBox, "Ingrese El Autor Del Libro");
            this.AutortextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AutortextBox_KeyPress);
            // 
            // OKbutton
            // 
            this.OKbutton.Image = global::TrabajoPracticoLibro.Windows.Properties.Resources.ok_36px;
            this.OKbutton.Location = new System.Drawing.Point(33, 284);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 65);
            this.OKbutton.TabIndex = 13;
            this.OKbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Image = global::TrabajoPracticoLibro.Windows.Properties.Resources.cancel_64px;
            this.Cancelarbutton.Location = new System.Drawing.Point(160, 284);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(75, 65);
            this.Cancelarbutton.TabIndex = 14;
            this.Cancelarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmLibrosEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 361);
            this.ControlBox = false;
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.AutortextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ISBNtextBox);
            this.Controls.Add(this.PaginastextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TemacomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EditorialcomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreDelLibrotextBox);
            this.Controls.Add(this.label1);
            this.Name = "FrmLibrosEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libros";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreDelLibrotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox EditorialcomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TemacomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PaginastextBox;
        private System.Windows.Forms.TextBox ISBNtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AutortextBox;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip AyudaToolTip;
    }
}