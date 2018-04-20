﻿namespace Getränkeabrechnung.Ansicht
{
    partial class AbrechnungsVorschauFenster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbrechnungsVorschauFenster));
            this.Tabelle = new BrightIdeasSoftware.ObjectListView();
            this.NameSpalte = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.VerbrauchKostenSpalte = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.VerlustKostenSpalte = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.AltGuthabenSpalte = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.NeuGuthabenSpalte = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Knopf = new System.Windows.Forms.Button();
            this.PrintDokument = new System.Drawing.Printing.PrintDocument();
            this.PrintDialog = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Tabelle)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabelle
            // 
            this.Tabelle.AllColumns.Add(this.NameSpalte);
            this.Tabelle.AllColumns.Add(this.VerbrauchKostenSpalte);
            this.Tabelle.AllColumns.Add(this.VerlustKostenSpalte);
            this.Tabelle.AllColumns.Add(this.AltGuthabenSpalte);
            this.Tabelle.AllColumns.Add(this.NeuGuthabenSpalte);
            this.Tabelle.AlternateRowBackColor = System.Drawing.SystemColors.ButtonFace;
            this.Tabelle.CellEditUseWholeCell = false;
            this.Tabelle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameSpalte,
            this.VerbrauchKostenSpalte,
            this.VerlustKostenSpalte,
            this.AltGuthabenSpalte,
            this.NeuGuthabenSpalte});
            this.Tabelle.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tabelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabelle.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Tabelle.HeaderWordWrap = true;
            this.Tabelle.Location = new System.Drawing.Point(0, 0);
            this.Tabelle.Margin = new System.Windows.Forms.Padding(0);
            this.Tabelle.MultiSelect = false;
            this.Tabelle.Name = "Tabelle";
            this.Tabelle.Scrollable = false;
            this.Tabelle.SelectColumnsOnRightClick = false;
            this.Tabelle.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.Tabelle.ShowGroups = false;
            this.Tabelle.ShowSortIndicators = false;
            this.Tabelle.Size = new System.Drawing.Size(1164, 501);
            this.Tabelle.SortGroupItemsByPrimaryColumn = false;
            this.Tabelle.TabIndex = 0;
            this.Tabelle.UseAlternatingBackColors = true;
            this.Tabelle.UseCompatibleStateImageBehavior = false;
            this.Tabelle.View = System.Windows.Forms.View.Details;
            this.Tabelle.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.Tabelle_FormatCell);
            this.Tabelle.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.Tabelle_FormatRow);
            // 
            // NameSpalte
            // 
            this.NameSpalte.AspectName = "Name";
            this.NameSpalte.FillsFreeSpace = true;
            this.NameSpalte.Text = "Vorschau";
            // 
            // VerbrauchKostenSpalte
            // 
            this.VerbrauchKostenSpalte.AspectName = "VerbrauchKosten";
            this.VerbrauchKostenSpalte.AspectToStringFormat = "";
            this.VerbrauchKostenSpalte.Text = "Aktuell";
            this.VerbrauchKostenSpalte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.VerbrauchKostenSpalte.Width = 70;
            // 
            // VerlustKostenSpalte
            // 
            this.VerlustKostenSpalte.AspectName = "VerlustKosten";
            this.VerlustKostenSpalte.AspectToStringFormat = "";
            this.VerlustKostenSpalte.Text = "Verlust- umlage";
            this.VerlustKostenSpalte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.VerlustKostenSpalte.Width = 70;
            // 
            // AltGuthabenSpalte
            // 
            this.AltGuthabenSpalte.AspectName = "AltesGuthaben";
            this.AltGuthabenSpalte.AspectToStringFormat = "";
            this.AltGuthabenSpalte.Text = "Altes Guthaben";
            this.AltGuthabenSpalte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AltGuthabenSpalte.Width = 70;
            // 
            // NeuGuthabenSpalte
            // 
            this.NeuGuthabenSpalte.AspectName = "NeuesGuthaben";
            this.NeuGuthabenSpalte.AspectToStringFormat = "";
            this.NeuGuthabenSpalte.Text = "Neues Guthaben";
            this.NeuGuthabenSpalte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NeuGuthabenSpalte.Width = 70;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Tabelle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Knopf, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1164, 541);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Knopf
            // 
            this.Knopf.Dock = System.Windows.Forms.DockStyle.Right;
            this.Knopf.Location = new System.Drawing.Point(1086, 504);
            this.Knopf.Name = "Knopf";
            this.Knopf.Size = new System.Drawing.Size(75, 34);
            this.Knopf.TabIndex = 1;
            this.Knopf.Text = "Drucken...";
            this.Knopf.UseVisualStyleBackColor = true;
            this.Knopf.Click += new System.EventHandler(this.Knopf_Click);
            // 
            // PrintDokument
            // 
            this.PrintDokument.OriginAtMargins = true;
            this.PrintDokument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDokument_PrintPage);
            // 
            // PrintDialog
            // 
            this.PrintDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintDialog.Document = this.PrintDokument;
            this.PrintDialog.Enabled = true;
            this.PrintDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintDialog.Icon")));
            this.PrintDialog.Name = "PrintDialog";
            this.PrintDialog.UseAntiAlias = true;
            this.PrintDialog.Visible = false;
            // 
            // AbrechnungsVorschauFenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AbrechnungsVorschauFenster";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Abrechnung";
            ((System.ComponentModel.ISupportInitialize)(this.Tabelle)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView Tabelle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Knopf;
        private BrightIdeasSoftware.OLVColumn NameSpalte;
        private BrightIdeasSoftware.OLVColumn AltGuthabenSpalte;
        private BrightIdeasSoftware.OLVColumn NeuGuthabenSpalte;
        private BrightIdeasSoftware.OLVColumn VerbrauchKostenSpalte;
        private BrightIdeasSoftware.OLVColumn VerlustKostenSpalte;
        private System.Drawing.Printing.PrintDocument PrintDokument;
        private System.Windows.Forms.PrintPreviewDialog PrintDialog;
    }
}
