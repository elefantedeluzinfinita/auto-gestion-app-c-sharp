namespace CommunityWork
{
    partial class ControlPanel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.groupBoxPanelOne = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button24);
            this.groupBox1.Controls.Add(this.button23);
            this.groupBox1.Controls.Add(this.button22);
            this.groupBox1.Controls.Add(this.button21);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 79);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PANEL DE ACCIONES";
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(674, 19);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(209, 44);
            this.button24.TabIndex = 3;
            this.button24.Text = "MAPA";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(459, 19);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(209, 44);
            this.button23.TabIndex = 2;
            this.button23.Text = "PROYECTOS EN CURSO";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(244, 19);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(209, 44);
            this.button22.TabIndex = 1;
            this.button22.Text = "TAREAS DIARIAS";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(29, 19);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(209, 44);
            this.button21.TabIndex = 0;
            this.button21.Text = "ASISTENCIA";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // groupBoxPanelOne
            // 
            this.groupBoxPanelOne.AutoScroll = true;
            this.groupBoxPanelOne.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBoxPanelOne.Location = new System.Drawing.Point(12, 97);
            this.groupBoxPanelOne.Name = "groupBoxPanelOne";
            this.groupBoxPanelOne.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxPanelOne.Size = new System.Drawing.Size(907, 436);
            this.groupBoxPanelOne.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 675);
            this.Controls.Add(this.groupBoxPanelOne);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Tareas Diarias";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.FlowLayoutPanel groupBoxPanelOne;
    }
}

