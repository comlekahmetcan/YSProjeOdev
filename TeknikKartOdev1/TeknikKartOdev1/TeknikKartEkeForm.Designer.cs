namespace TeknikKartOdev1
{
    partial class TeknikKartEkeForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.lblTaksName = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.btnTaskEKLE = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.usersTableAdapter1 = new TeknikKartOdev1.TeknikKartDataSetTableAdapters.UsersTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.DurumId = new System.Windows.Forms.Label();
            this.txtDurumID = new System.Windows.Forms.TextBox();
            this.teknikKartDataSet1 = new TeknikKartOdev1.TeknikKartDataSet();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teknikKartDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 342);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(442, 77);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(171, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "İşin AÇIKLAMASI";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "TASK EKLEME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(196, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Notlar";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 453);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(442, 51);
            this.richTextBox2.TabIndex = 14;
            this.richTextBox2.Text = "";
            // 
            // lblTaksName
            // 
            this.lblTaksName.AutoSize = true;
            this.lblTaksName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaksName.Location = new System.Drawing.Point(181, 138);
            this.lblTaksName.Name = "lblTaksName";
            this.lblTaksName.Size = new System.Drawing.Size(71, 13);
            this.lblTaksName.TabIndex = 10;
            this.lblTaksName.Text = "Task Name";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(61, 168);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(332, 20);
            this.txtTaskName.TabIndex = 12;
            // 
            // btnTaskEKLE
            // 
            this.btnTaskEKLE.Location = new System.Drawing.Point(136, 538);
            this.btnTaskEKLE.Name = "btnTaskEKLE";
            this.btnTaskEKLE.Size = new System.Drawing.Size(180, 23);
            this.btnTaskEKLE.TabIndex = 15;
            this.btnTaskEKLE.Text = "TaskEkle";
            this.btnTaskEKLE.UseVisualStyleBackColor = true;
            this.btnTaskEKLE.Click += new System.EventHandler(this.txtTaskEkle_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(12, 592);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 16;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.button1_Click);
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(187, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "User ID";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(64, 75);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(332, 20);
            this.txtUserID.TabIndex = 12;
            this.txtUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keypress);
            // 
            // DurumId
            // 
            this.DurumId.AutoSize = true;
            this.DurumId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DurumId.Location = new System.Drawing.Point(193, 229);
            this.DurumId.Name = "DurumId";
            this.DurumId.Size = new System.Drawing.Size(58, 13);
            this.DurumId.TabIndex = 10;
            this.DurumId.Text = "Durum İd";
            // 
            // txtDurumID
            // 
            this.txtDurumID.Location = new System.Drawing.Point(61, 258);
            this.txtDurumID.Name = "txtDurumID";
            this.txtDurumID.Size = new System.Drawing.Size(332, 20);
            this.txtDurumID.TabIndex = 12;
            this.txtDurumID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keypress);
            // 
            // teknikKartDataSet1
            // 
            this.teknikKartDataSet1.DataSetName = "TeknikKartDataSet";
            this.teknikKartDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(573, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(622, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Başlangıç Tarihi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 608);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Teknik Kartları Goruntule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // TeknikKartEkeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(841, 649);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnTaskEKLE);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.txtDurumID);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DurumId);
            this.Controls.Add(this.lblTaksName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "TeknikKartEkeForm";
            this.Text = "TeknikKartEkeForm";
            this.Load += new System.EventHandler(this.TeknikKartEkeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teknikKartDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label lblTaksName;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Button btnTaskEKLE;
        private System.Windows.Forms.Button btnGeri;
        private TeknikKartDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label DurumId;
        private System.Windows.Forms.TextBox txtDurumID;
        private TeknikKartDataSet teknikKartDataSet1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}