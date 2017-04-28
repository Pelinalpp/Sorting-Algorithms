namespace Veri_Odev_2_Soru_2
{
    partial class frmSoru2
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
            this.btnBubble = new System.Windows.Forms.Button();
            this.btnSelection = new System.Windows.Forms.Button();
            this.btnInsertion = new System.Windows.Forms.Button();
            this.btnQuick = new System.Windows.Forms.Button();
            this.btnHeap = new System.Windows.Forms.Button();
            this.txtListe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBubble
            // 
            this.btnBubble.Location = new System.Drawing.Point(31, 18);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(168, 23);
            this.btnBubble.TabIndex = 0;
            this.btnBubble.Text = "Bubble";
            this.btnBubble.UseVisualStyleBackColor = true;
            this.btnBubble.Click += new System.EventHandler(this.btnBubble_Click);
            // 
            // btnSelection
            // 
            this.btnSelection.Location = new System.Drawing.Point(31, 53);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(168, 24);
            this.btnSelection.TabIndex = 1;
            this.btnSelection.Text = "Selection";
            this.btnSelection.UseVisualStyleBackColor = true;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // btnInsertion
            // 
            this.btnInsertion.Location = new System.Drawing.Point(31, 89);
            this.btnInsertion.Name = "btnInsertion";
            this.btnInsertion.Size = new System.Drawing.Size(168, 24);
            this.btnInsertion.TabIndex = 3;
            this.btnInsertion.Text = "Insertion";
            this.btnInsertion.UseVisualStyleBackColor = true;
            this.btnInsertion.Click += new System.EventHandler(this.btnInsertion_Click);
            // 
            // btnQuick
            // 
            this.btnQuick.Location = new System.Drawing.Point(31, 125);
            this.btnQuick.Name = "btnQuick";
            this.btnQuick.Size = new System.Drawing.Size(168, 23);
            this.btnQuick.TabIndex = 2;
            this.btnQuick.Text = "Quick";
            this.btnQuick.UseVisualStyleBackColor = true;
            this.btnQuick.Click += new System.EventHandler(this.btnQuick_Click);
            // 
            // btnHeap
            // 
            this.btnHeap.Location = new System.Drawing.Point(31, 160);
            this.btnHeap.Name = "btnHeap";
            this.btnHeap.Size = new System.Drawing.Size(168, 23);
            this.btnHeap.TabIndex = 4;
            this.btnHeap.Text = "Heap";
            this.btnHeap.UseVisualStyleBackColor = true;
            this.btnHeap.Click += new System.EventHandler(this.btnHeap_Click);
            // 
            // txtListe
            // 
            this.txtListe.Location = new System.Drawing.Point(215, 18);
            this.txtListe.Multiline = true;
            this.txtListe.Name = "txtListe";
            this.txtListe.Size = new System.Drawing.Size(503, 168);
            this.txtListe.TabIndex = 5;
            // 
            // frmSoru2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 198);
            this.Controls.Add(this.txtListe);
            this.Controls.Add(this.btnHeap);
            this.Controls.Add(this.btnInsertion);
            this.Controls.Add(this.btnQuick);
            this.Controls.Add(this.btnSelection);
            this.Controls.Add(this.btnBubble);
            this.Name = "frmSoru2";
            this.Text = "Performans Testi";
            this.Load += new System.EventHandler(this.frmSoru2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.Button btnInsertion;
        private System.Windows.Forms.Button btnQuick;
        private System.Windows.Forms.Button btnHeap;
        private System.Windows.Forms.TextBox txtListe;
    }
}

