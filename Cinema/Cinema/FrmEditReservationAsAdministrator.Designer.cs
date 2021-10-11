
namespace Cinema
{
    partial class FrmEditReservationAsAdministrator
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
            this.tbReservationBill = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberOfSeats = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProjections = new System.Windows.Forms.ComboBox();
            this.cbMovieNames = new System.Windows.Forms.ComboBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // tbReservationBill
            // 
            this.tbReservationBill.Enabled = false;
            this.tbReservationBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReservationBill.Location = new System.Drawing.Point(272, 156);
            this.tbReservationBill.Name = "tbReservationBill";
            this.tbReservationBill.Size = new System.Drawing.Size(189, 24);
            this.tbReservationBill.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Reservation Bill : ";
            // 
            // NumberOfSeats
            // 
            this.NumberOfSeats.Location = new System.Drawing.Point(272, 111);
            this.NumberOfSeats.Name = "NumberOfSeats";
            this.NumberOfSeats.Size = new System.Drawing.Size(189, 20);
            this.NumberOfSeats.TabIndex = 21;
            this.NumberOfSeats.ValueChanged += new System.EventHandler(this.NumberOfSeats_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Number Of Seats :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Projection Date and Time : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Movie Name : ";
            // 
            // cbProjections
            // 
            this.cbProjections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjections.FormattingEnabled = true;
            this.cbProjections.Location = new System.Drawing.Point(272, 63);
            this.cbProjections.Name = "cbProjections";
            this.cbProjections.Size = new System.Drawing.Size(189, 21);
            this.cbProjections.TabIndex = 24;
            this.cbProjections.SelectedIndexChanged += new System.EventHandler(this.cbProjections_SelectedIndexChanged);
            // 
            // cbMovieNames
            // 
            this.cbMovieNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMovieNames.FormattingEnabled = true;
            this.cbMovieNames.Location = new System.Drawing.Point(272, 20);
            this.cbMovieNames.Name = "cbMovieNames";
            this.cbMovieNames.Size = new System.Drawing.Size(189, 21);
            this.cbMovieNames.TabIndex = 25;
            this.cbMovieNames.SelectedIndexChanged += new System.EventHandler(this.cbMovieNames_SelectedIndexChanged);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(29, 299);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(257, 35);
            this.btnSaveChanges.TabIndex = 26;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(503, 299);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(257, 35);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmEditReservationAsAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.cbMovieNames);
            this.Controls.Add(this.cbProjections);
            this.Controls.Add(this.tbReservationBill);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumberOfSeats);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditReservationAsAdministrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation Administration";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfSeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbReservationBill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumberOfSeats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProjections;
        private System.Windows.Forms.ComboBox cbMovieNames;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnClose;
    }
}