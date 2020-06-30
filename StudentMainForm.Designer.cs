namespace ITGS
{
    partial class StudentMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.issue_btn = new System.Windows.Forms.Button();
            this.condition_box = new System.Windows.Forms.ComboBox();
            this.quantity_box = new System.Windows.Forms.ComboBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemBs = new System.Windows.Forms.BindingSource(this.components);
            this.itgsDataSet1 = new ITGS.ITGSDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.return_btn = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.itemListTableAdapter1 = new ITGS.ITGSDataSetTableAdapters.ItemListTableAdapter();
            this.studentTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableTableAdapter = new ITGS.ITGSDataSetTableAdapters.StudentTableTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itgsDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 26.14286F);
            this.button1.Location = new System.Drawing.Point(32, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(396, 349);
            this.button1.TabIndex = 0;
            this.button1.Text = "Issue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 26.14286F);
            this.button2.Location = new System.Drawing.Point(479, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(396, 349);
            this.button2.TabIndex = 0;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.issue_btn);
            this.panel1.Controls.Add(this.condition_box);
            this.panel1.Controls.Add(this.quantity_box);
            this.panel1.Controls.Add(this.name_txt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(937, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 1000);
            this.panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 26.14286F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 360);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(437, 90);
            this.comboBox1.TabIndex = 4;
            // 
            // issue_btn
            // 
            this.issue_btn.Font = new System.Drawing.Font("Segoe UI", 26.14286F);
            this.issue_btn.Location = new System.Drawing.Point(77, 865);
            this.issue_btn.Name = "issue_btn";
            this.issue_btn.Size = new System.Drawing.Size(661, 96);
            this.issue_btn.TabIndex = 3;
            this.issue_btn.Text = "Issue";
            this.issue_btn.UseVisualStyleBackColor = true;
            this.issue_btn.Click += new System.EventHandler(this.issue_btn_Click);
            // 
            // condition_box
            // 
            this.condition_box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.condition_box.Font = new System.Drawing.Font("Segoe UI", 26.14286F);
            this.condition_box.FormattingEnabled = true;
            this.condition_box.Location = new System.Drawing.Point(77, 732);
            this.condition_box.Name = "condition_box";
            this.condition_box.Size = new System.Drawing.Size(240, 90);
            this.condition_box.TabIndex = 2;
            this.condition_box.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.condition_box_DrawItem);
            this.condition_box.SelectedIndexChanged += new System.EventHandler(this.condition_box_SelectedIndexChanged);
            // 
            // quantity_box
            // 
            this.quantity_box.Font = new System.Drawing.Font("Segoe UI", 26.14286F);
            this.quantity_box.FormattingEnabled = true;
            this.quantity_box.Location = new System.Drawing.Point(67, 552);
            this.quantity_box.Name = "quantity_box";
            this.quantity_box.Size = new System.Drawing.Size(434, 90);
            this.quantity_box.TabIndex = 2;
            this.quantity_box.SelectedIndexChanged += new System.EventHandler(this.quantity_box_SelectedIndexChanged);
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("Segoe UI", 26.14286F);
            this.name_txt.Location = new System.Drawing.Point(67, 157);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(434, 89);
            this.name_txt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 26.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 645);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 84);
            this.label4.TabIndex = 0;
            this.label4.Text = "Condition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 26.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 84);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(515, 84);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose Eqpiment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // ItemBs
            // 
            this.ItemBs.DataMember = "ItemList";
            this.ItemBs.DataSource = this.itgsDataSet1;
            // 
            // itgsDataSet1
            // 
            this.itgsDataSet1.DataSetName = "ITGSDataSet";
            this.itgsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.return_btn);
            this.panel2.Controls.Add(this.comboBox4);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(937, 1065);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 624);
            this.panel2.TabIndex = 2;
            // 
            // return_btn
            // 
            this.return_btn.Font = new System.Drawing.Font("Segoe UI", 26.14286F);
            this.return_btn.Location = new System.Drawing.Point(46, 507);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(661, 96);
            this.return_btn.TabIndex = 4;
            this.return_btn.Text = "Return";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Segoe UI", 26.14286F);
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(46, 339);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(434, 90);
            this.comboBox4.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 26.14286F);
            this.textBox2.Location = new System.Drawing.Point(46, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(434, 89);
            this.textBox2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 26.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(515, 84);
            this.label6.TabIndex = 4;
            this.label6.Text = "Choose Eqpiment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 26.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 84);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name";
            // 
            // itemListTableAdapter1
            // 
            this.itemListTableAdapter1.ClearBeforeFill = true;
            // 
            // studentTableBindingSource
            // 
            this.studentTableBindingSource.DataMember = "StudentTable";
            this.studentTableBindingSource.DataSource = this.itgsDataSet1;
            // 
            // studentTableTableAdapter
            // 
            this.studentTableTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(595, 547);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(280, 245);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 527);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(340, 527);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 235);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(32, 789);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(281, 235);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(340, 778);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(240, 235);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // StudentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2220, 1964);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentMainForm";
            this.Text = "StudentMainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentMainForm_FormClosed);
            this.Load += new System.EventHandler(this.StudentMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itgsDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button issue_btn;
        private System.Windows.Forms.ComboBox condition_box;
        private System.Windows.Forms.ComboBox quantity_box;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource ItemBs;
        private ITGSDataSet itgsDataSet1;
        private ITGSDataSetTableAdapters.ItemListTableAdapter itemListTableAdapter1;
        private System.Windows.Forms.BindingSource studentTableBindingSource;
        private ITGSDataSetTableAdapters.StudentTableTableAdapter studentTableTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}