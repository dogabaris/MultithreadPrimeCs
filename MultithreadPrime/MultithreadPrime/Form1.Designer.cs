namespace MultithreadPrime
{
    partial class MultiThreadPrime
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
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet = new MultithreadPrime.Database2DataSet();
            this.label_sayi = new System.Windows.Forms.Label();
            this.label_arastirilan = new System.Windows.Forms.Label();
            this.btn_bitir = new System.Windows.Forms.Button();
            this.btn_basla = new System.Windows.Forms.Button();
            this.label_snc = new System.Windows.Forms.Label();
            this.label_sonuc = new System.Windows.Forms.Label();
            this.tableTableAdapter = new MultithreadPrime.Database2DataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new MultithreadPrime.Database2DataSetTableAdapters.TableAdapterManager();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Thread = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baslangic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bitis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asalmi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.database2DataSet;
            // 
            // database2DataSet
            // 
            this.database2DataSet.DataSetName = "Database2DataSet";
            this.database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_sayi
            // 
            this.label_sayi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_sayi.AutoSize = true;
            this.label_sayi.Location = new System.Drawing.Point(1005, 130);
            this.label_sayi.Name = "label_sayi";
            this.label_sayi.Size = new System.Drawing.Size(13, 13);
            this.label_sayi.TabIndex = 8;
            this.label_sayi.Text = "0";
            // 
            // label_arastirilan
            // 
            this.label_arastirilan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_arastirilan.AutoSize = true;
            this.label_arastirilan.Location = new System.Drawing.Point(911, 130);
            this.label_arastirilan.Name = "label_arastirilan";
            this.label_arastirilan.Size = new System.Drawing.Size(81, 13);
            this.label_arastirilan.TabIndex = 7;
            this.label_arastirilan.Text = "Araştırılan Sayı :";
            // 
            // btn_bitir
            // 
            this.btn_bitir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_bitir.Location = new System.Drawing.Point(1005, 80);
            this.btn_bitir.Name = "btn_bitir";
            this.btn_bitir.Size = new System.Drawing.Size(75, 23);
            this.btn_bitir.TabIndex = 6;
            this.btn_bitir.Text = "Bitir";
            this.btn_bitir.UseVisualStyleBackColor = true;
            this.btn_bitir.Click += new System.EventHandler(this.btn_bitir_Click);
            // 
            // btn_basla
            // 
            this.btn_basla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_basla.Location = new System.Drawing.Point(914, 80);
            this.btn_basla.Name = "btn_basla";
            this.btn_basla.Size = new System.Drawing.Size(75, 23);
            this.btn_basla.TabIndex = 5;
            this.btn_basla.Text = "Başla";
            this.btn_basla.UseVisualStyleBackColor = true;
            this.btn_basla.Click += new System.EventHandler(this.btn_basla_Click);
            // 
            // label_snc
            // 
            this.label_snc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_snc.AutoSize = true;
            this.label_snc.Location = new System.Drawing.Point(911, 177);
            this.label_snc.Name = "label_snc";
            this.label_snc.Size = new System.Drawing.Size(44, 13);
            this.label_snc.TabIndex = 10;
            this.label_snc.Text = "Sonuç :";
            // 
            // label_sonuc
            // 
            this.label_sonuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_sonuc.AutoSize = true;
            this.label_sonuc.Location = new System.Drawing.Point(914, 211);
            this.label_sonuc.Name = "label_sonuc";
            this.label_sonuc.Size = new System.Drawing.Size(103, 13);
            this.label_sonuc.TabIndex = 11;
            this.label_sonuc.Text = "Sayı daha girilmedi...";
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = MultithreadPrime.Database2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Thread,
            this.Baslangic,
            this.Bitis,
            this.Asalmi});
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.No;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView.Size = new System.Drawing.Size(905, 597);
            this.dataGridView.TabIndex = 15;
            // 
            // Thread
            // 
            this.Thread.HeaderText = "Thread";
            this.Thread.Name = "Thread";
            this.Thread.ReadOnly = true;
            // 
            // Baslangic
            // 
            this.Baslangic.HeaderText = "Bas.Nok";
            this.Baslangic.Name = "Baslangic";
            this.Baslangic.ReadOnly = true;
            // 
            // Bitis
            // 
            this.Bitis.HeaderText = "Bit.Nok";
            this.Bitis.Name = "Bitis";
            this.Bitis.ReadOnly = true;
            // 
            // Asalmi
            // 
            this.Asalmi.HeaderText = "Asallık";
            this.Asalmi.Name = "Asalmi";
            this.Asalmi.ReadOnly = true;
            // 
            // MultiThreadPrime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 595);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label_sonuc);
            this.Controls.Add(this.label_snc);
            this.Controls.Add(this.label_sayi);
            this.Controls.Add(this.label_arastirilan);
            this.Controls.Add(this.btn_bitir);
            this.Controls.Add(this.btn_basla);
            this.Name = "MultiThreadPrime";
            this.Text = "MultiThreadus Prime";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_sayi;
        private System.Windows.Forms.Label label_arastirilan;
        private System.Windows.Forms.Button btn_bitir;
        private System.Windows.Forms.Button btn_basla;
        private System.Windows.Forms.Label label_snc;
        private System.Windows.Forms.Label label_sonuc;
        private Database2DataSet database2DataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Database2DataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private Database2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thread;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bitis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asalmi;
    }
}

