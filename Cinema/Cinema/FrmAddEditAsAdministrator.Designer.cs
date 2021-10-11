
namespace Cinema
{
    partial class FrmAddEditAsAdministrator
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
            this.cbMemberNames = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbReservations = new System.Windows.Forms.ComboBox();
            this.btnEditReservation = new System.Windows.Forms.Button();
            this.btnEditProjections = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.tbMemberName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditMovies = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Member Name : ";
            // 
            // cbMemberNames
            // 
            this.cbMemberNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMemberNames.FormattingEnabled = true;
            this.cbMemberNames.Location = new System.Drawing.Point(166, 21);
            this.cbMemberNames.Name = "cbMemberNames";
            this.cbMemberNames.Size = new System.Drawing.Size(203, 21);
            this.cbMemberNames.TabIndex = 10;
            this.cbMemberNames.SelectedIndexChanged += new System.EventHandler(this.cbMemberNames_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Reservations :";
            // 
            // cbReservations
            // 
            this.cbReservations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReservations.FormattingEnabled = true;
            this.cbReservations.Location = new System.Drawing.Point(166, 74);
            this.cbReservations.Name = "cbReservations";
            this.cbReservations.Size = new System.Drawing.Size(604, 21);
            this.cbReservations.TabIndex = 12;
            // 
            // btnEditReservation
            // 
            this.btnEditReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditReservation.Location = new System.Drawing.Point(15, 117);
            this.btnEditReservation.Name = "btnEditReservation";
            this.btnEditReservation.Size = new System.Drawing.Size(237, 42);
            this.btnEditReservation.TabIndex = 30;
            this.btnEditReservation.Text = "Edit Reservation";
            this.btnEditReservation.UseVisualStyleBackColor = true;
            this.btnEditReservation.Click += new System.EventHandler(this.btnEditReservation_Click);
            // 
            // btnEditProjections
            // 
            this.btnEditProjections.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProjections.Location = new System.Drawing.Point(18, 271);
            this.btnEditProjections.Name = "btnEditProjections";
            this.btnEditProjections.Size = new System.Drawing.Size(246, 60);
            this.btnEditProjections.TabIndex = 34;
            this.btnEditProjections.Text = "Edit/Remove/New Projections";
            this.btnEditProjections.UseVisualStyleBackColor = true;
            this.btnEditProjections.Click += new System.EventHandler(this.btnEditProjections_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Projection Administration :";
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveMember.Location = new System.Drawing.Point(660, 20);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(110, 40);
            this.btnRemoveMember.TabIndex = 36;
            this.btnRemoveMember.Text = "Remove";
            this.btnRemoveMember.UseVisualStyleBackColor = true;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click);
            // 
            // tbMemberName
            // 
            this.tbMemberName.Location = new System.Drawing.Point(406, 20);
            this.tbMemberName.Name = "tbMemberName";
            this.tbMemberName.Size = new System.Drawing.Size(194, 20);
            this.tbMemberName.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "Movie Administration :";
            // 
            // btnEditMovies
            // 
            this.btnEditMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMovies.Location = new System.Drawing.Point(341, 271);
            this.btnEditMovies.Name = "btnEditMovies";
            this.btnEditMovies.Size = new System.Drawing.Size(246, 60);
            this.btnEditMovies.TabIndex = 39;
            this.btnEditMovies.Text = "Add/Remove Movies";
            this.btnEditMovies.UseVisualStyleBackColor = true;
            this.btnEditMovies.Click += new System.EventHandler(this.btnEditMovies_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(542, 381);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(228, 47);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmAddEditAsAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEditMovies);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMemberName);
            this.Controls.Add(this.btnRemoveMember);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEditProjections);
            this.Controls.Add(this.btnEditReservation);
            this.Controls.Add(this.cbReservations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMemberNames);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddEditAsAdministrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMemberNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbReservations;
        private System.Windows.Forms.Button btnEditReservation;
        private System.Windows.Forms.Button btnEditProjections;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemoveMember;
        private System.Windows.Forms.TextBox tbMemberName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditMovies;
        private System.Windows.Forms.Button btnClose;
    }
}