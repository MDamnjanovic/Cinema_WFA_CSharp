
namespace Cinema
{
    partial class FrmEditReservation
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbMovieName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDateTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberOfSeats = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbReservationBill = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Movie Name : ";
            // 
            // tbMovieName
            // 
            this.tbMovieName.Enabled = false;
            this.tbMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMovieName.Location = new System.Drawing.Point(271, 27);
            this.tbMovieName.Name = "tbMovieName";
            this.tbMovieName.Size = new System.Drawing.Size(189, 24);
            this.tbMovieName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Projection Date and Time : ";
            // 
            // tbDateTime
            // 
            this.tbDateTime.Enabled = false;
            this.tbDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateTime.Location = new System.Drawing.Point(271, 70);
            this.tbDateTime.Name = "tbDateTime";
            this.tbDateTime.Size = new System.Drawing.Size(189, 24);
            this.tbDateTime.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Number Of Seats :";
            // 
            // NumberOfSeats
            // 
            this.NumberOfSeats.Location = new System.Drawing.Point(271, 118);
            this.NumberOfSeats.Name = "NumberOfSeats";
            this.NumberOfSeats.Size = new System.Drawing.Size(189, 20);
            this.NumberOfSeats.TabIndex = 13;
            this.NumberOfSeats.ValueChanged += new System.EventHandler(this.NumberOfSeats_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Reservation Bill : ";
            // 
            // tbReservationBill
            // 
            this.tbReservationBill.Enabled = false;
            this.tbReservationBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReservationBill.Location = new System.Drawing.Point(271, 163);
            this.tbReservationBill.Name = "tbReservationBill";
            this.tbReservationBill.Size = new System.Drawing.Size(189, 24);
            this.tbReservationBill.TabIndex = 15;
            this.tbReservationBill.TextChanged += new System.EventHandler(this.tbReservationBill_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(599, 372);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(155, 28);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(42, 371);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(180, 29);
            this.btnSaveChanges.TabIndex = 17;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // FrmEditReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbReservationBill);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumberOfSeats);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDateTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMovieName);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editing Your Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfSeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMovieName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumberOfSeats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbReservationBill;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}