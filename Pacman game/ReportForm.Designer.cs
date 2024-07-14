
namespace Pacman_game
{
    partial class ReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.hadinaeemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PACMANDataSet = new Pacman_game.PACMANDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hadinaeemTableAdapter = new Pacman_game.PACMANDataSetTableAdapters.hadinaeemTableAdapter();
            this.rptPlaybtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hadinaeemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PACMANDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // hadinaeemBindingSource
            // 
            this.hadinaeemBindingSource.DataMember = "hadinaeem";
            this.hadinaeemBindingSource.DataSource = this.PACMANDataSet;
            // 
            // PACMANDataSet
            // 
            this.PACMANDataSet.DataSetName = "PACMANDataSet";
            this.PACMANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.hadinaeemBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Pacman_game.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(717, 561);
            this.reportViewer1.TabIndex = 0;
            // 
            // hadinaeemTableAdapter
            // 
            this.hadinaeemTableAdapter.ClearBeforeFill = true;
            // 
            // rptPlaybtn
            // 
            this.rptPlaybtn.BackColor = System.Drawing.SystemColors.ControlText;
            this.rptPlaybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rptPlaybtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.rptPlaybtn.FlatAppearance.BorderSize = 3;
            this.rptPlaybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rptPlaybtn.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rptPlaybtn.ForeColor = System.Drawing.Color.Yellow;
            this.rptPlaybtn.Location = new System.Drawing.Point(582, 511);
            this.rptPlaybtn.Name = "rptPlaybtn";
            this.rptPlaybtn.Size = new System.Drawing.Size(123, 38);
            this.rptPlaybtn.TabIndex = 9;
            this.rptPlaybtn.Text = "BACK";
            this.rptPlaybtn.UseVisualStyleBackColor = false;
            this.rptPlaybtn.Click += new System.EventHandler(this.rptPlaybtn_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 561);
            this.Controls.Add(this.rptPlaybtn);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacman";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hadinaeemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PACMANDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource hadinaeemBindingSource;
        private PACMANDataSet PACMANDataSet;
        private PACMANDataSetTableAdapters.hadinaeemTableAdapter hadinaeemTableAdapter;
        private System.Windows.Forms.Button rptPlaybtn;
    }
}