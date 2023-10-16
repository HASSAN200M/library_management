
namespace library
{
    partial class ADD_BOOK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADD_BOOK));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tBCATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_dataDataSet1 = new library.library_dataDataSet1();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.BUTTONADD_BOOK = new System.Windows.Forms.Button();
            this.TEXTBOOKNAME = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TEXTAUTHER = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TEXTBOX_ID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TEXTPRICE = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_CATTableAdapter = new library.library_dataDataSet1TableAdapters.TB_CATTableAdapter();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tBCATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_dataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Silver;
            this.comboBox1.DataSource = this.tBCATBindingSource;
            this.comboBox1.DisplayMember = "CAT_NAME";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(433, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "CAT_NAME";
            // 
            // tBCATBindingSource
            // 
            this.tBCATBindingSource.DataMember = "TB_CAT";
            this.tBCATBindingSource.DataSource = this.library_dataDataSet1;
            // 
            // library_dataDataSet1
            // 
            this.library_dataDataSet1.DataSetName = "library_dataDataSet1";
            this.library_dataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.Silver;
            this.bunifuDatepicker1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(433, 220);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(236, 25);
            this.bunifuDatepicker1.TabIndex = 7;
            this.bunifuDatepicker1.Value = new System.DateTime(2023, 1, 29, 2, 52, 50, 931);
            // 
            // BUTTONADD_BOOK
            // 
            this.BUTTONADD_BOOK.BackColor = System.Drawing.Color.Silver;
            this.BUTTONADD_BOOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTONADD_BOOK.Location = new System.Drawing.Point(247, 252);
            this.BUTTONADD_BOOK.Name = "BUTTONADD_BOOK";
            this.BUTTONADD_BOOK.Size = new System.Drawing.Size(124, 55);
            this.BUTTONADD_BOOK.TabIndex = 6;
            this.BUTTONADD_BOOK.Text = "ADD";
            this.BUTTONADD_BOOK.UseVisualStyleBackColor = false;
            this.BUTTONADD_BOOK.Click += new System.EventHandler(this.BUTTONADD_BOOK_Click);
            // 
            // TEXTBOOKNAME
            // 
            this.TEXTBOOKNAME.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TEXTBOOKNAME.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TEXTBOOKNAME.ForeColor = System.Drawing.Color.Black;
            this.TEXTBOOKNAME.HintForeColor = System.Drawing.Color.Black;
            this.TEXTBOOKNAME.HintText = "BOOK NAME";
            this.TEXTBOOKNAME.isPassword = false;
            this.TEXTBOOKNAME.LineFocusedColor = System.Drawing.Color.Empty;
            this.TEXTBOOKNAME.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.TEXTBOOKNAME.LineMouseHoverColor = System.Drawing.Color.Empty;
            this.TEXTBOOKNAME.LineThickness = 3;
            this.TEXTBOOKNAME.Location = new System.Drawing.Point(231, 31);
            this.TEXTBOOKNAME.Margin = new System.Windows.Forms.Padding(4);
            this.TEXTBOOKNAME.Name = "TEXTBOOKNAME";
            this.TEXTBOOKNAME.Size = new System.Drawing.Size(314, 44);
            this.TEXTBOOKNAME.TabIndex = 3;
            this.TEXTBOOKNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TEXTAUTHER
            // 
            this.TEXTAUTHER.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TEXTAUTHER.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TEXTAUTHER.ForeColor = System.Drawing.Color.Black;
            this.TEXTAUTHER.HintForeColor = System.Drawing.Color.Empty;
            this.TEXTAUTHER.HintText = "AUTHER";
            this.TEXTAUTHER.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.TEXTAUTHER.isPassword = false;
            this.TEXTAUTHER.LineFocusedColor = System.Drawing.Color.Empty;
            this.TEXTAUTHER.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.TEXTAUTHER.LineMouseHoverColor = System.Drawing.Color.Empty;
            this.TEXTAUTHER.LineThickness = 10;
            this.TEXTAUTHER.Location = new System.Drawing.Point(13, 106);
            this.TEXTAUTHER.Margin = new System.Windows.Forms.Padding(4);
            this.TEXTAUTHER.Name = "TEXTAUTHER";
            this.TEXTAUTHER.Size = new System.Drawing.Size(223, 44);
            this.TEXTAUTHER.TabIndex = 1;
            this.TEXTAUTHER.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TEXTBOX_ID
            // 
            this.TEXTBOX_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TEXTBOX_ID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TEXTBOX_ID.ForeColor = System.Drawing.Color.Black;
            this.TEXTBOX_ID.HintForeColor = System.Drawing.Color.Black;
            this.TEXTBOX_ID.HintText = "ID";
            this.TEXTBOX_ID.isPassword = false;
            this.TEXTBOX_ID.LineFocusedColor = System.Drawing.Color.Transparent;
            this.TEXTBOX_ID.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.TEXTBOX_ID.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.TEXTBOX_ID.LineThickness = 3;
            this.TEXTBOX_ID.Location = new System.Drawing.Point(13, 31);
            this.TEXTBOX_ID.Margin = new System.Windows.Forms.Padding(4);
            this.TEXTBOX_ID.Name = "TEXTBOX_ID";
            this.TEXTBOX_ID.Size = new System.Drawing.Size(151, 44);
            this.TEXTBOX_ID.TabIndex = 0;
            this.TEXTBOX_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(684, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TEXTPRICE
            // 
            this.TEXTPRICE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TEXTPRICE.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TEXTPRICE.ForeColor = System.Drawing.Color.Black;
            this.TEXTPRICE.HintForeColor = System.Drawing.Color.Black;
            this.TEXTPRICE.HintText = "PRICE";
            this.TEXTPRICE.isPassword = false;
            this.TEXTPRICE.LineFocusedColor = System.Drawing.Color.Transparent;
            this.TEXTPRICE.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.TEXTPRICE.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.TEXTPRICE.LineThickness = 3;
            this.TEXTPRICE.Location = new System.Drawing.Point(13, 172);
            this.TEXTPRICE.Margin = new System.Windows.Forms.Padding(4);
            this.TEXTPRICE.Name = "TEXTPRICE";
            this.TEXTPRICE.Size = new System.Drawing.Size(151, 44);
            this.TEXTPRICE.TabIndex = 47;
            this.TEXTPRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "DATE TIME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "CATEGORY";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tB_CATTableAdapter
            // 
            this.tB_CATTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Black;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(650, 3);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.pictureBox9.Size = new System.Drawing.Size(19, 17);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 50;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // ADD_BOOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 347);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.BUTTONADD_BOOK);
            this.Controls.Add(this.TEXTPRICE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TEXTBOX_ID);
            this.Controls.Add(this.TEXTBOOKNAME);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuDatepicker1);
            this.Controls.Add(this.TEXTAUTHER);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ADD_BOOK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD_BOOK";
            this.Load += new System.EventHandler(this.ADD_BOOK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBCATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_dataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.Button BUTTONADD_BOOK;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TEXTBOOKNAME;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TEXTAUTHER;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TEXTBOX_ID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TEXTPRICE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private library_dataDataSet1 library_dataDataSet1;
        private System.Windows.Forms.BindingSource tBCATBindingSource;
        private library_dataDataSet1TableAdapters.TB_CATTableAdapter tB_CATTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}