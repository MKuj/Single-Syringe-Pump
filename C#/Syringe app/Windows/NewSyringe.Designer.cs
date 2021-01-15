namespace Syringe_app
{
    partial class NewSyringe
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
            this.exit_button = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.forth_btn = new System.Windows.Forms.Button();
            this.title_lb = new System.Windows.Forms.Label();
            this.syringe_name_lb = new System.Windows.Forms.Label();
            this.s_name_txt = new System.Windows.Forms.TextBox();
            this.pos_lb = new System.Windows.Forms.Label();
            this.stop_btn = new System.Windows.Forms.Button();
            this.s_length_txt = new System.Windows.Forms.TextBox();
            this.syringe_length_lb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.set_start_btn = new System.Windows.Forms.Button();
            this.s_vol_txt = new System.Windows.Forms.TextBox();
            this.syringe_volume_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.speed_cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Transparent;
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit_button.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.exit_button.Location = new System.Drawing.Point(500, 0);
            this.exit_button.Margin = new System.Windows.Forms.Padding(4);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(32, 31);
            this.exit_button.TabIndex = 11;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_btn.Location = new System.Drawing.Point(417, 359);
            this.ok_btn.Margin = new System.Windows.Forms.Padding(4);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(100, 28);
            this.ok_btn.TabIndex = 10;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.home_btn.Location = new System.Drawing.Point(282, 215);
            this.home_btn.Margin = new System.Windows.Forms.Padding(4);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(101, 38);
            this.home_btn.TabIndex = 7;
            this.home_btn.Text = "Home";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.back_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.back_btn.ForeColor = System.Drawing.Color.Turquoise;
            this.back_btn.Location = new System.Drawing.Point(173, 215);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(101, 37);
            this.back_btn.TabIndex = 6;
            this.back_btn.Text = "Step -";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.back_btn_MouseDown);
            this.back_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.back_btn_MouseUp);
            // 
            // forth_btn
            // 
            this.forth_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.forth_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.forth_btn.FlatAppearance.BorderSize = 0;
            this.forth_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forth_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.forth_btn.ForeColor = System.Drawing.Color.Turquoise;
            this.forth_btn.Location = new System.Drawing.Point(64, 215);
            this.forth_btn.Margin = new System.Windows.Forms.Padding(4);
            this.forth_btn.Name = "forth_btn";
            this.forth_btn.Size = new System.Drawing.Size(101, 37);
            this.forth_btn.TabIndex = 5;
            this.forth_btn.Text = "Step +";
            this.forth_btn.UseVisualStyleBackColor = false;
            this.forth_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.forth_btn_MouseDown);
            this.forth_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.forth_btn_MouseUp);
            // 
            // title_lb
            // 
            this.title_lb.AutoSize = true;
            this.title_lb.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title_lb.Location = new System.Drawing.Point(177, 45);
            this.title_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_lb.Name = "title_lb";
            this.title_lb.Size = new System.Drawing.Size(206, 29);
            this.title_lb.TabIndex = 30;
            this.title_lb.Text = "Add new syringe";
            // 
            // syringe_name_lb
            // 
            this.syringe_name_lb.AutoSize = true;
            this.syringe_name_lb.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.syringe_name_lb.Location = new System.Drawing.Point(12, 112);
            this.syringe_name_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.syringe_name_lb.Name = "syringe_name_lb";
            this.syringe_name_lb.Size = new System.Drawing.Size(107, 16);
            this.syringe_name_lb.TabIndex = 31;
            this.syringe_name_lb.Text = "Syringe name:";
            // 
            // s_name_txt
            // 
            this.s_name_txt.Location = new System.Drawing.Point(143, 109);
            this.s_name_txt.Name = "s_name_txt";
            this.s_name_txt.Size = new System.Drawing.Size(374, 23);
            this.s_name_txt.TabIndex = 1;
            // 
            // pos_lb
            // 
            this.pos_lb.AutoSize = true;
            this.pos_lb.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pos_lb.Location = new System.Drawing.Point(24, 276);
            this.pos_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pos_lb.Name = "pos_lb";
            this.pos_lb.Size = new System.Drawing.Size(141, 16);
            this.pos_lb.TabIndex = 33;
            this.pos_lb.Text = "Current position: --";
            // 
            // stop_btn
            // 
            this.stop_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stop_btn.Enabled = false;
            this.stop_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.stop_btn.FlatAppearance.BorderSize = 0;
            this.stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stop_btn.ForeColor = System.Drawing.Color.White;
            this.stop_btn.Location = new System.Drawing.Point(390, 215);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(101, 38);
            this.stop_btn.TabIndex = 8;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // s_length_txt
            // 
            this.s_length_txt.Location = new System.Drawing.Point(143, 138);
            this.s_length_txt.Name = "s_length_txt";
            this.s_length_txt.Size = new System.Drawing.Size(101, 23);
            this.s_length_txt.TabIndex = 2;
            this.s_length_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.s_length_txt_KeyPress);
            // 
            // syringe_length_lb
            // 
            this.syringe_length_lb.AutoSize = true;
            this.syringe_length_lb.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.syringe_length_lb.Location = new System.Drawing.Point(12, 141);
            this.syringe_length_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.syringe_length_lb.Name = "syringe_length_lb";
            this.syringe_length_lb.Size = new System.Drawing.Size(114, 16);
            this.syringe_length_lb.TabIndex = 36;
            this.syringe_length_lb.Text = "Syringe length:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(251, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "mm";
            // 
            // set_start_btn
            // 
            this.set_start_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.set_start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_start_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.set_start_btn.ForeColor = System.Drawing.Color.Turquoise;
            this.set_start_btn.Location = new System.Drawing.Point(143, 313);
            this.set_start_btn.Margin = new System.Windows.Forms.Padding(4);
            this.set_start_btn.Name = "set_start_btn";
            this.set_start_btn.Size = new System.Drawing.Size(240, 37);
            this.set_start_btn.TabIndex = 4;
            this.set_start_btn.Text = "Set current as start position";
            this.set_start_btn.UseVisualStyleBackColor = false;
            this.set_start_btn.Click += new System.EventHandler(this.set_start_btn_Click);
            // 
            // s_vol_txt
            // 
            this.s_vol_txt.Location = new System.Drawing.Point(143, 167);
            this.s_vol_txt.Name = "s_vol_txt";
            this.s_vol_txt.Size = new System.Drawing.Size(101, 23);
            this.s_vol_txt.TabIndex = 3;
            this.s_vol_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // syringe_volume_lbl
            // 
            this.syringe_volume_lbl.AutoSize = true;
            this.syringe_volume_lbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.syringe_volume_lbl.Location = new System.Drawing.Point(12, 170);
            this.syringe_volume_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.syringe_volume_lbl.Name = "syringe_volume_lbl";
            this.syringe_volume_lbl.Size = new System.Drawing.Size(121, 16);
            this.syringe_volume_lbl.TabIndex = 40;
            this.syringe_volume_lbl.Text = "Syringe volume:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(251, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "ml";
            // 
            // speed_cmb
            // 
            this.speed_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speed_cmb.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.speed_cmb.FormattingEnabled = true;
            this.speed_cmb.Items.AddRange(new object[] {
            "1x",
            "2x",
            "4x"});
            this.speed_cmb.Location = new System.Drawing.Point(390, 139);
            this.speed_cmb.Name = "speed_cmb";
            this.speed_cmb.Size = new System.Drawing.Size(121, 24);
            this.speed_cmb.TabIndex = 9;
            this.speed_cmb.SelectedIndexChanged += new System.EventHandler(this.speed_cmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(326, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Speed:";
            // 
            // NewSyringe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speed_cmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.syringe_volume_lbl);
            this.Controls.Add(this.s_vol_txt);
            this.Controls.Add(this.set_start_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.syringe_length_lb);
            this.Controls.Add(this.s_length_txt);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.pos_lb);
            this.Controls.Add(this.s_name_txt);
            this.Controls.Add(this.syringe_name_lb);
            this.Controls.Add(this.title_lb);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.forth_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.exit_button);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewSyringe";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new syringe";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewSyringe_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button forth_btn;
        private System.Windows.Forms.Label title_lb;
        private System.Windows.Forms.Label syringe_name_lb;
        private System.Windows.Forms.TextBox s_name_txt;
        private System.Windows.Forms.Label pos_lb;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.TextBox s_length_txt;
        private System.Windows.Forms.Label syringe_length_lb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button set_start_btn;
        private System.Windows.Forms.TextBox s_vol_txt;
        private System.Windows.Forms.Label syringe_volume_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox speed_cmb;
        private System.Windows.Forms.Label label1;
    }
}