namespace CommunityWork
{
    partial class ButtonTask
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_body = new System.Windows.Forms.Label();
            this.label_owner = new System.Windows.Forms.Label();
            this.label_venc = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.label_completed = new System.Windows.Forms.Label();
            this.label_header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_body
            // 
            this.label_body.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_body.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_body.Location = new System.Drawing.Point(6, 58);
            this.label_body.Name = "label_body";
            this.label_body.Size = new System.Drawing.Size(254, 101);
            this.label_body.TabIndex = 0;
            this.label_body.Text = "TAREA RECURRENTE INTERNA #1";
            this.label_body.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_owner
            // 
            this.label_owner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_owner.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_owner.ForeColor = System.Drawing.Color.White;
            this.label_owner.Location = new System.Drawing.Point(6, 258);
            this.label_owner.Name = "label_owner";
            this.label_owner.Size = new System.Drawing.Size(254, 56);
            this.label_owner.TabIndex = 1;
            this.label_owner.Text = "MAYTEELSOON GUERRA CASTILLA";
            this.label_owner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_venc
            // 
            this.label_venc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_venc.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_venc.ForeColor = System.Drawing.Color.White;
            this.label_venc.Location = new System.Drawing.Point(6, 165);
            this.label_venc.Name = "label_venc";
            this.label_venc.Size = new System.Drawing.Size(254, 21);
            this.label_venc.TabIndex = 2;
            this.label_venc.Text = "----";
            this.label_venc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_time
            // 
            this.label_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_time.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.ForeColor = System.Drawing.Color.White;
            this.label_time.Location = new System.Drawing.Point(6, 186);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(254, 45);
            this.label_time.TabIndex = 3;
            this.label_time.Text = "05:09 HRS";
            this.label_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_completed
            // 
            this.label_completed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_completed.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_completed.ForeColor = System.Drawing.Color.White;
            this.label_completed.Location = new System.Drawing.Point(6, 237);
            this.label_completed.Name = "label_completed";
            this.label_completed.Size = new System.Drawing.Size(254, 21);
            this.label_completed.TabIndex = 4;
            this.label_completed.Text = "COMPLETADO POR";
            this.label_completed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_header
            // 
            this.label_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_header.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header.ForeColor = System.Drawing.Color.White;
            this.label_header.Location = new System.Drawing.Point(6, 7);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(254, 45);
            this.label_header.TabIndex = 5;
            this.label_header.Text = "TAREA INCOMPLETA";
            this.label_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label_header);
            this.Controls.Add(this.label_owner);
            this.Controls.Add(this.label_completed);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_venc);
            this.Controls.Add(this.label_body);
            this.Name = "ButtonTask";
            this.Size = new System.Drawing.Size(265, 320);
            this.Load += new System.EventHandler(this.ButtonTask_Load);
            this.Click += new System.EventHandler(this.ButtonTask_Click);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_body;
        private System.Windows.Forms.Label label_venc;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_owner;
        private System.Windows.Forms.Label label_completed;
        private System.Windows.Forms.Label label_header;
    }
}
