namespace DBCrud
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCable = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_PrepaidCards = new System.Windows.Forms.DataGridView();
            this.cmd_add = new System.Windows.Forms.Button();
            this.cmd_edit = new System.Windows.Forms.Button();
            this.cmd_delete = new System.Windows.Forms.Button();
            this.cmd_save = new System.Windows.Forms.Button();
            this.cmd_cancel = new System.Windows.Forms.Button();
            this.dateTimePicker_DateReg = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Expire = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PrepaidCards)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCable
            // 
            this.txtCable.Location = new System.Drawing.Point(133, 300);
            this.txtCable.Name = "txtCable";
            this.txtCable.Size = new System.Drawing.Size(196, 20);
            this.txtCable.TabIndex = 80;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(484, 236);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(196, 20);
            this.txtAmount.TabIndex = 79;
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(484, 268);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(196, 20);
            this.txtPin.TabIndex = 78;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Amount";
            this.Column5.HeaderText = "Amout";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CableType";
            this.Column4.HeaderText = "Cable Type";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "Pin";
            this.Column6.HeaderText = "Pin";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 26);
            this.button1.TabIndex = 77;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Status";
            this.Column7.HeaderText = "Status";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Date_Expired";
            this.Column9.HeaderText = "Date Expired";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Date_Registered";
            this.Column10.HeaderText = "Date Registered";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridView_PrepaidCards
            // 
            this.dataGridView_PrepaidCards.AllowUserToAddRows = false;
            this.dataGridView_PrepaidCards.AllowUserToDeleteRows = false;
            this.dataGridView_PrepaidCards.AllowUserToResizeColumns = false;
            this.dataGridView_PrepaidCards.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Thistle;
            this.dataGridView_PrepaidCards.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_PrepaidCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PrepaidCards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column10,
            this.Column9});
            this.dataGridView_PrepaidCards.Location = new System.Drawing.Point(12, 40);
            this.dataGridView_PrepaidCards.Name = "dataGridView_PrepaidCards";
            this.dataGridView_PrepaidCards.ReadOnly = true;
            this.dataGridView_PrepaidCards.RowHeadersVisible = false;
            this.dataGridView_PrepaidCards.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_PrepaidCards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_PrepaidCards.Size = new System.Drawing.Size(672, 186);
            this.dataGridView_PrepaidCards.TabIndex = 76;
            this.dataGridView_PrepaidCards.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_PrepaidCards_CellClick);
            this.dataGridView_PrepaidCards.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_PrepaidCards_CellContentClick);
            // 
            // cmd_add
            // 
            this.cmd_add.Location = new System.Drawing.Point(29, 338);
            this.cmd_add.Name = "cmd_add";
            this.cmd_add.Size = new System.Drawing.Size(81, 26);
            this.cmd_add.TabIndex = 81;
            this.cmd_add.Text = "Add";
            this.cmd_add.UseVisualStyleBackColor = true;
            this.cmd_add.Click += new System.EventHandler(this.cmd_add_Click);
            // 
            // cmd_edit
            // 
            this.cmd_edit.Location = new System.Drawing.Point(116, 338);
            this.cmd_edit.Name = "cmd_edit";
            this.cmd_edit.Size = new System.Drawing.Size(81, 26);
            this.cmd_edit.TabIndex = 82;
            this.cmd_edit.Text = "Edit";
            this.cmd_edit.UseVisualStyleBackColor = true;
            this.cmd_edit.Click += new System.EventHandler(this.cmd_edit_Click);
            // 
            // cmd_delete
            // 
            this.cmd_delete.Location = new System.Drawing.Point(203, 338);
            this.cmd_delete.Name = "cmd_delete";
            this.cmd_delete.Size = new System.Drawing.Size(81, 26);
            this.cmd_delete.TabIndex = 83;
            this.cmd_delete.Text = "Delete";
            this.cmd_delete.UseVisualStyleBackColor = true;
            this.cmd_delete.Click += new System.EventHandler(this.cmd_delete_Click);
            // 
            // cmd_save
            // 
            this.cmd_save.Location = new System.Drawing.Point(290, 338);
            this.cmd_save.Name = "cmd_save";
            this.cmd_save.Size = new System.Drawing.Size(81, 26);
            this.cmd_save.TabIndex = 84;
            this.cmd_save.Text = "Save";
            this.cmd_save.UseVisualStyleBackColor = true;
            this.cmd_save.Click += new System.EventHandler(this.cmd_save_Click);
            // 
            // cmd_cancel
            // 
            this.cmd_cancel.Location = new System.Drawing.Point(377, 338);
            this.cmd_cancel.Name = "cmd_cancel";
            this.cmd_cancel.Size = new System.Drawing.Size(81, 26);
            this.cmd_cancel.TabIndex = 85;
            this.cmd_cancel.Text = "Cancel";
            this.cmd_cancel.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_DateReg
            // 
            this.dateTimePicker_DateReg.Location = new System.Drawing.Point(133, 236);
            this.dateTimePicker_DateReg.Name = "dateTimePicker_DateReg";
            this.dateTimePicker_DateReg.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker_DateReg.TabIndex = 86;
            // 
            // dateTimePicker_Expire
            // 
            this.dateTimePicker_Expire.Location = new System.Drawing.Point(133, 268);
            this.dateTimePicker_Expire.Name = "dateTimePicker_Expire";
            this.dateTimePicker_Expire.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker_Expire.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "Date Registered";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Date Expiore";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Cable Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 91;
            this.label4.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "PIN";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CIGNAL",
            "SKY",
            "GSAT",
            "GPINOY"});
            this.comboBox1.Location = new System.Drawing.Point(484, 307);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 21);
            this.comboBox1.TabIndex = 93;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 381);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_Expire);
            this.Controls.Add(this.dateTimePicker_DateReg);
            this.Controls.Add(this.cmd_cancel);
            this.Controls.Add(this.cmd_save);
            this.Controls.Add(this.cmd_delete);
            this.Controls.Add(this.cmd_edit);
            this.Controls.Add(this.cmd_add);
            this.Controls.Add(this.txtCable);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_PrepaidCards);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PrepaidCards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCable;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridView dataGridView_PrepaidCards;
        private System.Windows.Forms.Button cmd_add;
        private System.Windows.Forms.Button cmd_edit;
        private System.Windows.Forms.Button cmd_delete;
        private System.Windows.Forms.Button cmd_save;
        private System.Windows.Forms.Button cmd_cancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateReg;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Expire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

