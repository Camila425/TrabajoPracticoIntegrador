
namespace TrabajoPracticoLibro.Windows
{
    partial class FrmPrincipal
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
            this.BorrarHerramientastoolStrip = new System.Windows.Forms.ToolStrip();
            this.NuevotoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FiltrartoolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.temaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TematoolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.editorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditorialtoolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.OrdenartoolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ascPorPaginasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ActualizartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SalirtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DatosdataGridView = new System.Windows.Forms.DataGridView();
            this.ColNombreDelLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEditorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPaginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDeRegistroslabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BorrarHerramientastoolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BorrarHerramientastoolStrip
            // 
            this.BorrarHerramientastoolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevotoolStripButton,
            this.BorrartoolStripButton,
            this.EditartoolStripButton,
            this.toolStripSeparator1,
            this.FiltrartoolStripButton,
            this.OrdenartoolStripButton,
            this.toolStripSeparator2,
            this.ActualizartoolStripButton,
            this.SalirtoolStripButton});
            this.BorrarHerramientastoolStrip.Location = new System.Drawing.Point(0, 0);
            this.BorrarHerramientastoolStrip.Name = "BorrarHerramientastoolStrip";
            this.BorrarHerramientastoolStrip.Size = new System.Drawing.Size(800, 58);
            this.BorrarHerramientastoolStrip.TabIndex = 0;
            this.BorrarHerramientastoolStrip.Text = "toolStrip1";
            // 
            // NuevotoolStripButton
            // 
            this.NuevotoolStripButton.Image = global::TrabajoPracticoLibro.Windows.Properties.Resources.create_36px;
            this.NuevotoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevotoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevotoolStripButton.Name = "NuevotoolStripButton";
            this.NuevotoolStripButton.Size = new System.Drawing.Size(46, 55);
            this.NuevotoolStripButton.Text = "Nuevo";
            this.NuevotoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevotoolStripButton.Click += new System.EventHandler(this.NuevotoolStripButton_Click);
            // 
            // BorrartoolStripButton
            // 
            this.BorrartoolStripButton.Image = global::TrabajoPracticoLibro.Windows.Properties.Resources.delete_36px;
            this.BorrartoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrartoolStripButton.Name = "BorrartoolStripButton";
            this.BorrartoolStripButton.Size = new System.Drawing.Size(43, 55);
            this.BorrartoolStripButton.Text = "Borrar";
            this.BorrartoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrartoolStripButton.Click += new System.EventHandler(this.BorrartoolStripButton_Click);
            // 
            // EditartoolStripButton
            // 
            this.EditartoolStripButton.Image = global::TrabajoPracticoLibro.Windows.Properties.Resources.edit_36px;
            this.EditartoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditartoolStripButton.Name = "EditartoolStripButton";
            this.EditartoolStripButton.Size = new System.Drawing.Size(41, 55);
            this.EditartoolStripButton.Text = "Editar";
            this.EditartoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditartoolStripButton.Click += new System.EventHandler(this.EditartoolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // FiltrartoolStripButton
            // 
            this.FiltrartoolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temaToolStripMenuItem,
            this.editorialToolStripMenuItem});
            this.FiltrartoolStripButton.Image = global::TrabajoPracticoLibro.Windows.Properties.Resources.filter_36px;
            this.FiltrartoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FiltrartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiltrartoolStripButton.Name = "FiltrartoolStripButton";
            this.FiltrartoolStripButton.Size = new System.Drawing.Size(50, 55);
            this.FiltrartoolStripButton.Text = "Filtrar";
            this.FiltrartoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // temaToolStripMenuItem
            // 
            this.temaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TematoolStripComboBox});
            this.temaToolStripMenuItem.Name = "temaToolStripMenuItem";
            this.temaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.temaToolStripMenuItem.Text = "Tema";
            // 
            // TematoolStripComboBox
            // 
            this.TematoolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TematoolStripComboBox.Name = "TematoolStripComboBox";
            this.TematoolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.TematoolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.TematoolStripComboBox_SelectedIndexChanged);
            // 
            // editorialToolStripMenuItem
            // 
            this.editorialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditorialtoolStripComboBox});
            this.editorialToolStripMenuItem.Name = "editorialToolStripMenuItem";
            this.editorialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editorialToolStripMenuItem.Text = "Editorial";
            // 
            // EditorialtoolStripComboBox
            // 
            this.EditorialtoolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditorialtoolStripComboBox.Name = "EditorialtoolStripComboBox";
            this.EditorialtoolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.EditorialtoolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.EditorialtoolStripComboBox_SelectedIndexChanged);
            // 
            // OrdenartoolStripButton
            // 
            this.OrdenartoolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascPorPaginasToolStripMenuItem,
            this.descToolStripMenuItem});
            this.OrdenartoolStripButton.Image = global::TrabajoPracticoLibro.Windows.Properties.Resources.todo_list_36px;
            this.OrdenartoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OrdenartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OrdenartoolStripButton.Name = "OrdenartoolStripButton";
            this.OrdenartoolStripButton.Size = new System.Drawing.Size(63, 55);
            this.OrdenartoolStripButton.Text = "Ordenar";
            this.OrdenartoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ascPorPaginasToolStripMenuItem
            // 
            this.ascPorPaginasToolStripMenuItem.Name = "ascPorPaginasToolStripMenuItem";
            this.ascPorPaginasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ascPorPaginasToolStripMenuItem.Text = "Asc por  Paginas";
            this.ascPorPaginasToolStripMenuItem.Click += new System.EventHandler(this.ascPorPaginasToolStripMenuItem_Click);
            // 
            // descToolStripMenuItem
            // 
            this.descToolStripMenuItem.Name = "descToolStripMenuItem";
            this.descToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.descToolStripMenuItem.Text = "Desc por Paginas";
            this.descToolStripMenuItem.Click += new System.EventHandler(this.descToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // ActualizartoolStripButton
            // 
            this.ActualizartoolStripButton.Image = global::TrabajoPracticoLibro.Windows.Properties.Resources.update_36px;
            this.ActualizartoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ActualizartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActualizartoolStripButton.Name = "ActualizartoolStripButton";
            this.ActualizartoolStripButton.Size = new System.Drawing.Size(40, 55);
            this.ActualizartoolStripButton.Text = " ";
            this.ActualizartoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ActualizartoolStripButton.Click += new System.EventHandler(this.ActualizartoolStripButton_Click);
            // 
            // SalirtoolStripButton
            // 
            this.SalirtoolStripButton.Image = global::TrabajoPracticoLibro.Windows.Properties.Resources.exit_36px;
            this.SalirtoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SalirtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirtoolStripButton.Name = "SalirtoolStripButton";
            this.SalirtoolStripButton.Size = new System.Drawing.Size(40, 55);
            this.SalirtoolStripButton.Text = "Salir";
            this.SalirtoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalirtoolStripButton.Click += new System.EventHandler(this.SalirtoolStripButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 58);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DatosdataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CantidadDeRegistroslabel);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 392);
            this.splitContainer1.SplitterDistance = 296;
            this.splitContainer1.TabIndex = 1;
            // 
            // DatosdataGridView
            // 
            this.DatosdataGridView.AllowUserToAddRows = false;
            this.DatosdataGridView.AllowUserToDeleteRows = false;
            this.DatosdataGridView.AllowUserToResizeColumns = false;
            this.DatosdataGridView.AllowUserToResizeRows = false;
            this.DatosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombreDelLibro,
            this.ColEditorial,
            this.ColTema,
            this.ColPaginas,
            this.ColISBN,
            this.ColAutor});
            this.DatosdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosdataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosdataGridView.MultiSelect = false;
            this.DatosdataGridView.Name = "DatosdataGridView";
            this.DatosdataGridView.ReadOnly = true;
            this.DatosdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosdataGridView.Size = new System.Drawing.Size(800, 296);
            this.DatosdataGridView.TabIndex = 0;
            // 
            // ColNombreDelLibro
            // 
            this.ColNombreDelLibro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNombreDelLibro.HeaderText = "Nombre Del Libro";
            this.ColNombreDelLibro.Name = "ColNombreDelLibro";
            this.ColNombreDelLibro.ReadOnly = true;
            this.ColNombreDelLibro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColEditorial
            // 
            this.ColEditorial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColEditorial.HeaderText = "Editorial";
            this.ColEditorial.Name = "ColEditorial";
            this.ColEditorial.ReadOnly = true;
            this.ColEditorial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColTema
            // 
            this.ColTema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTema.HeaderText = "Tema";
            this.ColTema.Name = "ColTema";
            this.ColTema.ReadOnly = true;
            this.ColTema.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColPaginas
            // 
            this.ColPaginas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColPaginas.HeaderText = "Paginas";
            this.ColPaginas.Name = "ColPaginas";
            this.ColPaginas.ReadOnly = true;
            this.ColPaginas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColISBN
            // 
            this.ColISBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColISBN.HeaderText = "ISBN";
            this.ColISBN.Name = "ColISBN";
            this.ColISBN.ReadOnly = true;
            this.ColISBN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColAutor
            // 
            this.ColAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColAutor.HeaderText = "Autor";
            this.ColAutor.Name = "ColAutor";
            this.ColAutor.ReadOnly = true;
            this.ColAutor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CantidadDeRegistroslabel
            // 
            this.CantidadDeRegistroslabel.AutoSize = true;
            this.CantidadDeRegistroslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadDeRegistroslabel.Location = new System.Drawing.Point(186, 21);
            this.CantidadDeRegistroslabel.Name = "CantidadDeRegistroslabel";
            this.CantidadDeRegistroslabel.Size = new System.Drawing.Size(14, 13);
            this.CantidadDeRegistroslabel.TabIndex = 1;
            this.CantidadDeRegistroslabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad De Registros";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.BorrarHerramientastoolStrip);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.BorrarHerramientastoolStrip.ResumeLayout(false);
            this.BorrarHerramientastoolStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip BorrarHerramientastoolStrip;
        private System.Windows.Forms.ToolStripButton NuevotoolStripButton;
        private System.Windows.Forms.ToolStripButton BorrartoolStripButton;
        private System.Windows.Forms.ToolStripButton EditartoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ActualizartoolStripButton;
        private System.Windows.Forms.ToolStripButton SalirtoolStripButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DatosdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreDelLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEditorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTema;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPaginas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAutor;
        private System.Windows.Forms.Label CantidadDeRegistroslabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripDropDownButton FiltrartoolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton OrdenartoolStripButton;
        private System.Windows.Forms.ToolStripMenuItem ascPorPaginasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temaToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox TematoolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem editorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox EditorialtoolStripComboBox;
    }
}

