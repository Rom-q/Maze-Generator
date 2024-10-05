namespace Random_Maze_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_width = new System.Windows.Forms.TextBox();
            this.tb_height = new System.Windows.Forms.TextBox();
            this.lbl_width = new System.Windows.Forms.Label();
            this.lbl_height = new System.Windows.Forms.Label();
            this.btn_genMaze = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_i1 = new System.Windows.Forms.Button();
            this.btn_i2 = new System.Windows.Forms.Button();
            this.btn_newgen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_width
            // 
            this.tb_width.Location = new System.Drawing.Point(76, 5);
            this.tb_width.Name = "tb_width";
            this.tb_width.Size = new System.Drawing.Size(132, 20);
            this.tb_width.TabIndex = 2;
            this.tb_width.Text = "10";
            // 
            // tb_height
            // 
            this.tb_height.Location = new System.Drawing.Point(76, 38);
            this.tb_height.Name = "tb_height";
            this.tb_height.Size = new System.Drawing.Size(132, 20);
            this.tb_height.TabIndex = 3;
            this.tb_height.Text = "10";
            // 
            // lbl_width
            // 
            this.lbl_width.AutoSize = true;
            this.lbl_width.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_width.Location = new System.Drawing.Point(12, 38);
            this.lbl_width.Name = "lbl_width";
            this.lbl_width.Size = new System.Drawing.Size(58, 16);
            this.lbl_width.TabIndex = 4;
            this.lbl_width.Text = "Высота:";
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_height.Location = new System.Drawing.Point(12, 9);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(58, 16);
            this.lbl_height.TabIndex = 5;
            this.lbl_height.Text = "Ширина";
            // 
            // btn_genMaze
            // 
            this.btn_genMaze.Location = new System.Drawing.Point(76, 77);
            this.btn_genMaze.Name = "btn_genMaze";
            this.btn_genMaze.Size = new System.Drawing.Size(102, 23);
            this.btn_genMaze.TabIndex = 6;
            this.btn_genMaze.Text = "Создать";
            this.btn_genMaze.UseVisualStyleBackColor = true;
            this.btn_genMaze.Click += new System.EventHandler(this.btn_genMaze_Click);
            // 
            // btn_back
            // 
            this.btn_back.Enabled = false;
            this.btn_back.Location = new System.Drawing.Point(9, 57);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(61, 23);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Visible = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_i1
            // 
            this.btn_i1.Location = new System.Drawing.Point(214, 38);
            this.btn_i1.Name = "btn_i1";
            this.btn_i1.Size = new System.Drawing.Size(15, 28);
            this.btn_i1.TabIndex = 9;
            this.btn_i1.Text = "i";
            this.btn_i1.UseVisualStyleBackColor = true;
            this.btn_i1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_i2
            // 
            this.btn_i2.Location = new System.Drawing.Point(214, -3);
            this.btn_i2.Name = "btn_i2";
            this.btn_i2.Size = new System.Drawing.Size(15, 28);
            this.btn_i2.TabIndex = 10;
            this.btn_i2.Text = "i";
            this.btn_i2.UseVisualStyleBackColor = true;
            this.btn_i2.Click += new System.EventHandler(this.btn_i2_Click);
            // 
            // btn_newgen
            // 
            this.btn_newgen.Enabled = false;
            this.btn_newgen.Location = new System.Drawing.Point(9, 77);
            this.btn_newgen.Name = "btn_newgen";
            this.btn_newgen.Size = new System.Drawing.Size(61, 23);
            this.btn_newgen.TabIndex = 11;
            this.btn_newgen.Text = "Новый";
            this.btn_newgen.UseVisualStyleBackColor = true;
            this.btn_newgen.Visible = false;
            this.btn_newgen.Click += new System.EventHandler(this.btn_newgen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(262, 110);
            this.Controls.Add(this.btn_newgen);
            this.Controls.Add(this.btn_i2);
            this.Controls.Add(this.btn_i1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_genMaze);
            this.Controls.Add(this.lbl_height);
            this.Controls.Add(this.lbl_width);
            this.Controls.Add(this.tb_height);
            this.Controls.Add(this.tb_width);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Random Maze Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_width;
        private System.Windows.Forms.TextBox tb_height;
        private System.Windows.Forms.Label lbl_width;
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.Button btn_genMaze;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_i1;
        private System.Windows.Forms.Button btn_i2;
        private System.Windows.Forms.Button btn_newgen;
    }
}

