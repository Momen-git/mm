namespace EventProjectLastVersion
{
    partial class Search
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label billLabel;
            System.Windows.Forms.Label timeLabel;
            System.Windows.Forms.Label dateLabel;
            this.patientDataSet = new EventProjectLastVersion.patientDataSet();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new EventProjectLastVersion.patientDataSetTableAdapters.patientTableAdapter();
            this.tableAdapterManager = new EventProjectLastVersion.patientDataSetTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.billTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.patientPhoneNumber = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            billLabel = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // patientDataSet
            // 
            this.patientDataSet.DataSetName = "patientDataSet";
            this.patientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "patient";
            this.patientBindingSource.DataSource = this.patientDataSet;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.patientTableAdapter = this.patientTableAdapter;
            this.tableAdapterManager.UpdateOrder = EventProjectLastVersion.patientDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(85, 117);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(139, 114);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(85, 145);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(47, 16);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(139, 142);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(85, 173);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(34, 16);
            ageLabel.TabIndex = 5;
            ageLabel.Text = "age:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "age", true));
            this.ageTextBox.Location = new System.Drawing.Point(139, 170);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(200, 22);
            this.ageTextBox.TabIndex = 6;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(85, 201);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(48, 16);
            phoneLabel.TabIndex = 7;
            phoneLabel.Text = "phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(139, 198);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 22);
            this.phoneTextBox.TabIndex = 8;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(85, 229);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(45, 16);
            statusLabel.TabIndex = 9;
            statusLabel.Text = "status:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "status", true));
            this.statusTextBox.Location = new System.Drawing.Point(139, 226);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(200, 22);
            this.statusTextBox.TabIndex = 10;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(85, 257);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(36, 16);
            typeLabel.TabIndex = 11;
            typeLabel.Text = "type:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "type", true));
            this.typeTextBox.Location = new System.Drawing.Point(139, 254);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(200, 22);
            this.typeTextBox.TabIndex = 12;
            // 
            // billLabel
            // 
            billLabel.AutoSize = true;
            billLabel.Location = new System.Drawing.Point(85, 285);
            billLabel.Name = "billLabel";
            billLabel.Size = new System.Drawing.Size(27, 16);
            billLabel.TabIndex = 13;
            billLabel.Text = "bill:";
            // 
            // billTextBox
            // 
            this.billTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "bill", true));
            this.billTextBox.Location = new System.Drawing.Point(139, 282);
            this.billTextBox.Name = "billTextBox";
            this.billTextBox.Size = new System.Drawing.Size(200, 22);
            this.billTextBox.TabIndex = 14;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(85, 313);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(35, 16);
            timeLabel.TabIndex = 15;
            timeLabel.Text = "time:";
            // 
            // timeTextBox
            // 
            this.timeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "time", true));
            this.timeTextBox.Location = new System.Drawing.Point(139, 310);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(200, 22);
            this.timeTextBox.TabIndex = 16;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(85, 342);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(37, 16);
            dateLabel.TabIndex = 17;
            dateLabel.Text = "date:";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource, "date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(139, 338);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateDateTimePicker.TabIndex = 18;
            // 
            // patientPhoneNumber
            // 
            this.patientPhoneNumber.Location = new System.Drawing.Point(197, 38);
            this.patientPhoneNumber.Name = "patientPhoneNumber";
            this.patientPhoneNumber.Size = new System.Drawing.Size(187, 22);
            this.patientPhoneNumber.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EventProjectLastVersion.Properties.Resources.magnifying_glass_solid;
            this.pictureBox1.Location = new System.Drawing.Point(412, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 392);
            this.Controls.Add(this.patientPhoneNumber);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(billLabel);
            this.Controls.Add(this.billTextBox);
            this.Controls.Add(timeLabel);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private patientDataSet patientDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private patientDataSetTableAdapters.patientTableAdapter patientTableAdapter;
        private patientDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox billTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox patientPhoneNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}