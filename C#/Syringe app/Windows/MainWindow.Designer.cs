using System;

namespace Syringe_app
{
    partial class mainApp
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainApp));
            this.connection_status = new System.Windows.Forms.TextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.exit_button = new System.Windows.Forms.Button();
            this.settings_group = new System.Windows.Forms.GroupBox();
            this.speedUpDown = new System.Windows.Forms.NumericUpDown();
            this.bolus = new System.Windows.Forms.Button();
            this.speed_unit = new System.Windows.Forms.Label();
            this.set_syringe = new System.Windows.Forms.Button();
            this.set_speed = new System.Windows.Forms.Button();
            this.syringe_status = new System.Windows.Forms.TextBox();
            this.syringeCombobox = new System.Windows.Forms.ComboBox();
            this.speed_status = new System.Windows.Forms.TextBox();
            this.syringe_lbl = new System.Windows.Forms.Label();
            this.speed_lbl = new System.Windows.Forms.Label();
            this.stop_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.forth_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.connection_group = new System.Windows.Forms.GroupBox();
            this.port_txt = new System.Windows.Forms.TextBox();
            this.statusGroup = new System.Windows.Forms.GroupBox();
            this.progressPanel = new Syringe_app.ProgressPanel();
            this.move_groupbox = new System.Windows.Forms.GroupBox();
            this.home_1 = new System.Windows.Forms.Button();
            this.pos_start_btn = new System.Windows.Forms.Button();
            this.minimalize_btn = new System.Windows.Forms.Button();
            this.contextmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syringe1group = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn_4x = new System.Windows.Forms.RadioButton();
            this.move_speed_lbl = new System.Windows.Forms.Label();
            this.rbtn_2x = new System.Windows.Forms.RadioButton();
            this.rbtn_1x = new System.Windows.Forms.RadioButton();
            this.bolus_group = new System.Windows.Forms.GroupBox();
            this.bolusInj = new System.Windows.Forms.NumericUpDown();
            this.bolusSpeed = new System.Windows.Forms.NumericUpDown();
            this.bolus_distance_lbl = new System.Windows.Forms.Label();
            this.bolus_speed_lbl = new System.Windows.Forms.Label();
            this.distance_lbl = new System.Windows.Forms.Label();
            this.bolus_start = new System.Windows.Forms.Button();
            this.bolus_lbl = new System.Windows.Forms.Label();
            this.exit_bolus = new System.Windows.Forms.Button();
            this.settings_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedUpDown)).BeginInit();
            this.connection_group.SuspendLayout();
            this.statusGroup.SuspendLayout();
            this.move_groupbox.SuspendLayout();
            this.contextmenu.SuspendLayout();
            this.syringe1group.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.bolus_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bolusInj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolusSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // connection_status
            // 
            this.connection_status.BackColor = System.Drawing.Color.LimeGreen;
            this.connection_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.connection_status.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connection_status.ForeColor = System.Drawing.Color.White;
            this.connection_status.Location = new System.Drawing.Point(6, 49);
            this.connection_status.Name = "connection_status";
            this.connection_status.ReadOnly = true;
            this.connection_status.Size = new System.Drawing.Size(168, 13);
            this.connection_status.TabIndex = 3;
            this.connection_status.TabStop = false;
            this.connection_status.Text = "Status: Disconnected";
            this.connection_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
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
            this.exit_button.Location = new System.Drawing.Point(445, 0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(24, 25);
            this.exit_button.TabIndex = 24;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // settings_group
            // 
            this.settings_group.Controls.Add(this.speedUpDown);
            this.settings_group.Controls.Add(this.bolus);
            this.settings_group.Controls.Add(this.speed_unit);
            this.settings_group.Controls.Add(this.set_syringe);
            this.settings_group.Controls.Add(this.set_speed);
            this.settings_group.Controls.Add(this.syringe_status);
            this.settings_group.Controls.Add(this.syringeCombobox);
            this.settings_group.Controls.Add(this.speed_status);
            this.settings_group.Controls.Add(this.syringe_lbl);
            this.settings_group.Controls.Add(this.speed_lbl);
            this.settings_group.Font = new System.Drawing.Font("Courier New", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settings_group.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.settings_group.Location = new System.Drawing.Point(10, 15);
            this.settings_group.Name = "settings_group";
            this.settings_group.Size = new System.Drawing.Size(262, 129);
            this.settings_group.TabIndex = 8;
            this.settings_group.TabStop = false;
            this.settings_group.Text = "Settings";
            // 
            // speedUpDown
            // 
            this.speedUpDown.DecimalPlaces = 2;
            this.speedUpDown.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.speedUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.speedUpDown.Location = new System.Drawing.Point(66, 68);
            this.speedUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.speedUpDown.Name = "speedUpDown";
            this.speedUpDown.Size = new System.Drawing.Size(55, 20);
            this.speedUpDown.TabIndex = 31;
            this.speedUpDown.TabStop = false;
            this.speedUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.speedUpDown.ValueChanged += new System.EventHandler(this.speedUpDown_ValueChanged);
            this.speedUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.speedUpDown_KeyPress);
            // 
            // bolus
            // 
            this.bolus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bolus.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bolus.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.bolus.Location = new System.Drawing.Point(171, 99);
            this.bolus.Name = "bolus";
            this.bolus.Size = new System.Drawing.Size(82, 24);
            this.bolus.TabIndex = 5;
            this.bolus.Text = "Bolus mode";
            this.bolus.UseVisualStyleBackColor = true;
            this.bolus.Click += new System.EventHandler(this.bolus_Click);
            // 
            // speed_unit
            // 
            this.speed_unit.AutoSize = true;
            this.speed_unit.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.speed_unit.Location = new System.Drawing.Point(127, 74);
            this.speed_unit.Name = "speed_unit";
            this.speed_unit.Size = new System.Drawing.Size(36, 14);
            this.speed_unit.TabIndex = 13;
            this.speed_unit.Text = "ml/hr";
            // 
            // set_syringe
            // 
            this.set_syringe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_syringe.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.set_syringe.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.set_syringe.Location = new System.Drawing.Point(171, 20);
            this.set_syringe.Name = "set_syringe";
            this.set_syringe.Size = new System.Drawing.Size(82, 24);
            this.set_syringe.TabIndex = 2;
            this.set_syringe.Text = "Set syringe ";
            this.set_syringe.UseVisualStyleBackColor = true;
            this.set_syringe.Click += new System.EventHandler(this.set_syringe_Click);
            // 
            // set_speed
            // 
            this.set_speed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_speed.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.set_speed.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.set_speed.Location = new System.Drawing.Point(171, 70);
            this.set_speed.Name = "set_speed";
            this.set_speed.Size = new System.Drawing.Size(82, 24);
            this.set_speed.TabIndex = 4;
            this.set_speed.Text = "Set speed";
            this.set_speed.UseVisualStyleBackColor = true;
            this.set_speed.Click += new System.EventHandler(this.set_speed_Click);
            // 
            // syringe_status
            // 
            this.syringe_status.BackColor = System.Drawing.Color.White;
            this.syringe_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.syringe_status.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.syringe_status.Location = new System.Drawing.Point(12, 50);
            this.syringe_status.Name = "syringe_status";
            this.syringe_status.ReadOnly = true;
            this.syringe_status.Size = new System.Drawing.Size(157, 13);
            this.syringe_status.TabIndex = 11;
            this.syringe_status.TabStop = false;
            this.syringe_status.Text = "Current syringe 0 ml";
            // 
            // syringeCombobox
            // 
            this.syringeCombobox.BackColor = System.Drawing.Color.White;
            this.syringeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.syringeCombobox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.syringeCombobox.FormattingEnabled = true;
            this.syringeCombobox.Location = new System.Drawing.Point(79, 20);
            this.syringeCombobox.Name = "syringeCombobox";
            this.syringeCombobox.Size = new System.Drawing.Size(86, 22);
            this.syringeCombobox.TabIndex = 1;
            this.syringeCombobox.TabStop = false;
            this.syringeCombobox.SelectedIndexChanged += new System.EventHandler(this.syringeCombobox_SelectedIndexChanged);
            this.syringeCombobox.SelectionChangeCommitted += new System.EventHandler(this.syringeCombobox_SelectionChangeCommitted);
            this.syringeCombobox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.syringeCombobox_KeyPress);
            // 
            // speed_status
            // 
            this.speed_status.BackColor = System.Drawing.Color.White;
            this.speed_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.speed_status.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.speed_status.Location = new System.Drawing.Point(12, 100);
            this.speed_status.Name = "speed_status";
            this.speed_status.ReadOnly = true;
            this.speed_status.Size = new System.Drawing.Size(157, 13);
            this.speed_status.TabIndex = 9;
            this.speed_status.TabStop = false;
            this.speed_status.Text = "Current speed: 0 ml/hr";
            // 
            // syringe_lbl
            // 
            this.syringe_lbl.AutoSize = true;
            this.syringe_lbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.syringe_lbl.Location = new System.Drawing.Point(8, 23);
            this.syringe_lbl.Name = "syringe_lbl";
            this.syringe_lbl.Size = new System.Drawing.Size(65, 16);
            this.syringe_lbl.TabIndex = 11;
            this.syringe_lbl.Text = "Syringe:";
            // 
            // speed_lbl
            // 
            this.speed_lbl.AutoSize = true;
            this.speed_lbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.speed_lbl.Location = new System.Drawing.Point(8, 72);
            this.speed_lbl.Name = "speed_lbl";
            this.speed_lbl.Size = new System.Drawing.Size(57, 16);
            this.speed_lbl.TabIndex = 9;
            this.speed_lbl.Text = "Speed:";
            // 
            // stop_btn
            // 
            this.stop_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stop_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.stop_btn.FlatAppearance.BorderSize = 0;
            this.stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stop_btn.ForeColor = System.Drawing.Color.IndianRed;
            this.stop_btn.Location = new System.Drawing.Point(55, 190);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(76, 30);
            this.stop_btn.TabIndex = 11;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.start_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.start_btn.FlatAppearance.BorderSize = 0;
            this.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start_btn.Location = new System.Drawing.Point(55, 151);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(76, 30);
            this.start_btn.TabIndex = 10;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // forth_btn
            // 
            this.forth_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.forth_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.forth_btn.FlatAppearance.BorderSize = 0;
            this.forth_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forth_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.forth_btn.Location = new System.Drawing.Point(6, 17);
            this.forth_btn.Name = "forth_btn";
            this.forth_btn.Size = new System.Drawing.Size(76, 30);
            this.forth_btn.TabIndex = 6;
            this.forth_btn.Text = "Step +";
            this.forth_btn.UseVisualStyleBackColor = false;
            this.forth_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.forth_btn_MouseDown);
            this.forth_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.forth_btn_MouseUp);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.back_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.back_btn.Location = new System.Drawing.Point(88, 18);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(76, 30);
            this.back_btn.TabIndex = 7;
            this.back_btn.Text = "Step -";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.back_btn_MouseDown);
            this.back_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.back_btn_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 18);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // connection_group
            // 
            this.connection_group.Controls.Add(this.connection_status);
            this.connection_group.Controls.Add(this.port_txt);
            this.connection_group.Font = new System.Drawing.Font("Courier New", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connection_group.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.connection_group.Location = new System.Drawing.Point(289, 24);
            this.connection_group.Name = "connection_group";
            this.connection_group.Size = new System.Drawing.Size(180, 72);
            this.connection_group.TabIndex = 4;
            this.connection_group.TabStop = false;
            this.connection_group.Text = "Connection";
            // 
            // port_txt
            // 
            this.port_txt.BackColor = System.Drawing.Color.White;
            this.port_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.port_txt.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.port_txt.Location = new System.Drawing.Point(7, 21);
            this.port_txt.Multiline = true;
            this.port_txt.Name = "port_txt";
            this.port_txt.ReadOnly = true;
            this.port_txt.Size = new System.Drawing.Size(167, 22);
            this.port_txt.TabIndex = 33;
            this.port_txt.TabStop = false;
            this.port_txt.Text = "Device unplugged!";
            this.port_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusGroup
            // 
            this.statusGroup.Controls.Add(this.progressPanel);
            this.statusGroup.Font = new System.Drawing.Font("Courier New", 7F);
            this.statusGroup.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.statusGroup.Location = new System.Drawing.Point(10, 226);
            this.statusGroup.Name = "statusGroup";
            this.statusGroup.Size = new System.Drawing.Size(438, 331);
            this.statusGroup.TabIndex = 19;
            this.statusGroup.TabStop = false;
            this.statusGroup.Text = "Run Console";
            // 
            // progressPanel
            // 
            this.progressPanel.BackColor = System.Drawing.Color.White;
            this.progressPanel.Location = new System.Drawing.Point(5, 17);
            this.progressPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(429, 317);
            this.progressPanel.TabIndex = 0;
            // 
            // move_groupbox
            // 
            this.move_groupbox.Controls.Add(this.home_1);
            this.move_groupbox.Controls.Add(this.pos_start_btn);
            this.move_groupbox.Controls.Add(this.back_btn);
            this.move_groupbox.Controls.Add(this.forth_btn);
            this.move_groupbox.Font = new System.Drawing.Font("Courier New", 7F);
            this.move_groupbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.move_groupbox.Location = new System.Drawing.Point(278, 16);
            this.move_groupbox.Name = "move_groupbox";
            this.move_groupbox.Size = new System.Drawing.Size(170, 128);
            this.move_groupbox.TabIndex = 25;
            this.move_groupbox.TabStop = false;
            this.move_groupbox.Text = "Move";
            // 
            // home_1
            // 
            this.home_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.home_1.Location = new System.Drawing.Point(6, 93);
            this.home_1.Name = "home_1";
            this.home_1.Size = new System.Drawing.Size(158, 31);
            this.home_1.TabIndex = 9;
            this.home_1.Text = "Home";
            this.home_1.UseVisualStyleBackColor = true;
            this.home_1.Click += new System.EventHandler(this.home_1_Click);
            // 
            // pos_start_btn
            // 
            this.pos_start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pos_start_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.pos_start_btn.Location = new System.Drawing.Point(6, 56);
            this.pos_start_btn.Name = "pos_start_btn";
            this.pos_start_btn.Size = new System.Drawing.Size(158, 31);
            this.pos_start_btn.TabIndex = 8;
            this.pos_start_btn.TabStop = false;
            this.pos_start_btn.Text = "Start Position";
            this.pos_start_btn.UseVisualStyleBackColor = true;
            this.pos_start_btn.Click += new System.EventHandler(this.pos_start_btn_Click);
            // 
            // minimalize_btn
            // 
            this.minimalize_btn.BackColor = System.Drawing.Color.Transparent;
            this.minimalize_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimalize_btn.FlatAppearance.BorderSize = 0;
            this.minimalize_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.minimalize_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.minimalize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimalize_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.minimalize_btn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.minimalize_btn.Location = new System.Drawing.Point(421, 0);
            this.minimalize_btn.Name = "minimalize_btn";
            this.minimalize_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.minimalize_btn.Size = new System.Drawing.Size(24, 25);
            this.minimalize_btn.TabIndex = 23;
            this.minimalize_btn.Text = "-";
            this.minimalize_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimalize_btn.UseVisualStyleBackColor = false;
            this.minimalize_btn.Click += new System.EventHandler(this.minimalize_btn_Click);
            // 
            // contextmenu
            // 
            this.contextmenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextmenu.Name = "contextmenu";
            this.contextmenu.Size = new System.Drawing.Size(94, 26);
            this.contextmenu.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // syringe1group
            // 
            this.syringe1group.Controls.Add(this.groupBox2);
            this.syringe1group.Controls.Add(this.stop_btn);
            this.syringe1group.Controls.Add(this.move_groupbox);
            this.syringe1group.Controls.Add(this.start_btn);
            this.syringe1group.Controls.Add(this.statusGroup);
            this.syringe1group.Controls.Add(this.bolus_group);
            this.syringe1group.Controls.Add(this.settings_group);
            this.syringe1group.Font = new System.Drawing.Font("Courier New", 7F);
            this.syringe1group.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.syringe1group.Location = new System.Drawing.Point(12, 102);
            this.syringe1group.Name = "syringe1group";
            this.syringe1group.Size = new System.Drawing.Size(457, 567);
            this.syringe1group.TabIndex = 30;
            this.syringe1group.TabStop = false;
            this.syringe1group.Text = "Syringe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtn_4x);
            this.groupBox2.Controls.Add(this.move_speed_lbl);
            this.groupBox2.Controls.Add(this.rbtn_2x);
            this.groupBox2.Controls.Add(this.rbtn_1x);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 7F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Location = new System.Drawing.Point(181, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 69);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Move speed";
            // 
            // rbtn_4x
            // 
            this.rbtn_4x.AutoSize = true;
            this.rbtn_4x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_4x.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbtn_4x.Location = new System.Drawing.Point(212, 28);
            this.rbtn_4x.Name = "rbtn_4x";
            this.rbtn_4x.Size = new System.Drawing.Size(40, 20);
            this.rbtn_4x.TabIndex = 38;
            this.rbtn_4x.Text = "4x";
            this.rbtn_4x.UseVisualStyleBackColor = true;
            this.rbtn_4x.CheckedChanged += new System.EventHandler(this.rbtn_4x_CheckedChanged);
            // 
            // move_speed_lbl
            // 
            this.move_speed_lbl.AutoSize = true;
            this.move_speed_lbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.move_speed_lbl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.move_speed_lbl.Location = new System.Drawing.Point(6, 30);
            this.move_speed_lbl.Name = "move_speed_lbl";
            this.move_speed_lbl.Size = new System.Drawing.Size(100, 16);
            this.move_speed_lbl.TabIndex = 8;
            this.move_speed_lbl.Text = "Move speed:";
            // 
            // rbtn_2x
            // 
            this.rbtn_2x.AutoSize = true;
            this.rbtn_2x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_2x.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbtn_2x.Location = new System.Drawing.Point(167, 28);
            this.rbtn_2x.Name = "rbtn_2x";
            this.rbtn_2x.Size = new System.Drawing.Size(40, 20);
            this.rbtn_2x.TabIndex = 37;
            this.rbtn_2x.Text = "2x";
            this.rbtn_2x.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbtn_2x.UseVisualStyleBackColor = true;
            this.rbtn_2x.CheckedChanged += new System.EventHandler(this.rbtn_2x_CheckedChanged);
            // 
            // rbtn_1x
            // 
            this.rbtn_1x.AutoSize = true;
            this.rbtn_1x.Checked = true;
            this.rbtn_1x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_1x.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtn_1x.ForeColor = System.Drawing.Color.Red;
            this.rbtn_1x.Location = new System.Drawing.Point(122, 28);
            this.rbtn_1x.Name = "rbtn_1x";
            this.rbtn_1x.Size = new System.Drawing.Size(40, 20);
            this.rbtn_1x.TabIndex = 36;
            this.rbtn_1x.TabStop = true;
            this.rbtn_1x.Text = "1x";
            this.rbtn_1x.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbtn_1x.UseVisualStyleBackColor = true;
            this.rbtn_1x.CheckedChanged += new System.EventHandler(this.rbtn_1x_CheckedChanged);
            // 
            // bolus_group
            // 
            this.bolus_group.Controls.Add(this.bolusInj);
            this.bolus_group.Controls.Add(this.bolusSpeed);
            this.bolus_group.Controls.Add(this.bolus_distance_lbl);
            this.bolus_group.Controls.Add(this.bolus_speed_lbl);
            this.bolus_group.Controls.Add(this.distance_lbl);
            this.bolus_group.Controls.Add(this.bolus_start);
            this.bolus_group.Controls.Add(this.bolus_lbl);
            this.bolus_group.Controls.Add(this.exit_bolus);
            this.bolus_group.Font = new System.Drawing.Font("Courier New", 7F);
            this.bolus_group.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bolus_group.Location = new System.Drawing.Point(10, 16);
            this.bolus_group.Name = "bolus_group";
            this.bolus_group.Size = new System.Drawing.Size(262, 129);
            this.bolus_group.TabIndex = 36;
            this.bolus_group.TabStop = false;
            this.bolus_group.Text = " Bolus";
            this.bolus_group.Visible = false;
            // 
            // bolusInj
            // 
            this.bolusInj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bolusInj.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.bolusInj.Location = new System.Drawing.Point(116, 48);
            this.bolusInj.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.bolusInj.Name = "bolusInj";
            this.bolusInj.Size = new System.Drawing.Size(75, 23);
            this.bolusInj.TabIndex = 34;
            this.bolusInj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bolusInj.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bolusInj.ValueChanged += new System.EventHandler(this.bolusInj_ValueChanged);
            // 
            // bolusSpeed
            // 
            this.bolusSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bolusSpeed.DecimalPlaces = 2;
            this.bolusSpeed.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.bolusSpeed.Location = new System.Drawing.Point(115, 18);
            this.bolusSpeed.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.bolusSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bolusSpeed.Name = "bolusSpeed";
            this.bolusSpeed.Size = new System.Drawing.Size(75, 23);
            this.bolusSpeed.TabIndex = 33;
            this.bolusSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bolusSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bolus_distance_lbl
            // 
            this.bolus_distance_lbl.AutoSize = true;
            this.bolus_distance_lbl.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.bolus_distance_lbl.Location = new System.Drawing.Point(198, 53);
            this.bolus_distance_lbl.Name = "bolus_distance_lbl";
            this.bolus_distance_lbl.Size = new System.Drawing.Size(17, 14);
            this.bolus_distance_lbl.TabIndex = 15;
            this.bolus_distance_lbl.Text = "ul";
            // 
            // bolus_speed_lbl
            // 
            this.bolus_speed_lbl.AutoSize = true;
            this.bolus_speed_lbl.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.bolus_speed_lbl.Location = new System.Drawing.Point(197, 23);
            this.bolus_speed_lbl.Name = "bolus_speed_lbl";
            this.bolus_speed_lbl.Size = new System.Drawing.Size(36, 14);
            this.bolus_speed_lbl.TabIndex = 14;
            this.bolus_speed_lbl.Text = "ml/hr";
            // 
            // distance_lbl
            // 
            this.distance_lbl.AutoSize = true;
            this.distance_lbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.distance_lbl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.distance_lbl.Location = new System.Drawing.Point(9, 51);
            this.distance_lbl.Name = "distance_lbl";
            this.distance_lbl.Size = new System.Drawing.Size(51, 16);
            this.distance_lbl.TabIndex = 9;
            this.distance_lbl.Text = "Inject:";
            // 
            // bolus_start
            // 
            this.bolus_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bolus_start.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bolus_start.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.bolus_start.Location = new System.Drawing.Point(11, 95);
            this.bolus_start.Name = "bolus_start";
            this.bolus_start.Size = new System.Drawing.Size(82, 24);
            this.bolus_start.TabIndex = 8;
            this.bolus_start.Text = "Start";
            this.bolus_start.UseVisualStyleBackColor = true;
            this.bolus_start.Click += new System.EventHandler(this.bolus_start_Click);
            // 
            // bolus_lbl
            // 
            this.bolus_lbl.AutoSize = true;
            this.bolus_lbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.bolus_lbl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bolus_lbl.Location = new System.Drawing.Point(9, 21);
            this.bolus_lbl.Name = "bolus_lbl";
            this.bolus_lbl.Size = new System.Drawing.Size(100, 16);
            this.bolus_lbl.TabIndex = 7;
            this.bolus_lbl.Text = "Bolus speed:";
            // 
            // exit_bolus
            // 
            this.exit_bolus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_bolus.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit_bolus.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.exit_bolus.Location = new System.Drawing.Point(201, 95);
            this.exit_bolus.Name = "exit_bolus";
            this.exit_bolus.Size = new System.Drawing.Size(55, 24);
            this.exit_bolus.TabIndex = 9;
            this.exit_bolus.Text = "Back";
            this.exit_bolus.UseVisualStyleBackColor = true;
            this.exit_bolus.Click += new System.EventHandler(this.exit_bolus_Click);
            // 
            // mainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 681);
            this.ContextMenuStrip = this.contextmenu;
            this.Controls.Add(this.syringe1group);
            this.Controls.Add(this.minimalize_btn);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.connection_group);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Syringe Pump";
            this.Load += new System.EventHandler(this.main_Load);
            this.settings_group.ResumeLayout(false);
            this.settings_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedUpDown)).EndInit();
            this.connection_group.ResumeLayout(false);
            this.connection_group.PerformLayout();
            this.statusGroup.ResumeLayout(false);
            this.move_groupbox.ResumeLayout(false);
            this.contextmenu.ResumeLayout(false);
            this.syringe1group.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.bolus_group.ResumeLayout(false);
            this.bolus_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bolusInj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolusSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox connection_status;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.GroupBox settings_group;
        private System.Windows.Forms.Label speed_lbl;
        private System.Windows.Forms.TextBox speed_status;
        private System.Windows.Forms.TextBox syringe_status;
        private System.Windows.Forms.Button set_speed;
        private System.Windows.Forms.ComboBox syringeCombobox;
        private System.Windows.Forms.Label syringe_lbl;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button forth_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox connection_group;
        private System.Windows.Forms.GroupBox statusGroup;
        private System.Windows.Forms.GroupBox move_groupbox;
        private System.Windows.Forms.Button pos_start_btn;
        private System.Windows.Forms.Button set_syringe;
        private System.Windows.Forms.Button home_1;
        private System.Windows.Forms.Button minimalize_btn;
        private System.Windows.Forms.ContextMenuStrip contextmenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox syringe1group;
        private System.Windows.Forms.TextBox port_txt;
        private System.Windows.Forms.Button bolus;
        private System.Windows.Forms.GroupBox bolus_group;
        private System.Windows.Forms.Button exit_bolus;
        private System.Windows.Forms.Label bolus_lbl;
        private System.Windows.Forms.Button bolus_start;
        private System.Windows.Forms.Label distance_lbl;
        private System.Windows.Forms.Label bolus_distance_lbl;
        private System.Windows.Forms.Label bolus_speed_lbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label move_speed_lbl;
        private System.Windows.Forms.NumericUpDown bolusSpeed;
        private System.Windows.Forms.NumericUpDown bolusInj;
        private System.Windows.Forms.Label speed_unit;
        private System.Windows.Forms.NumericUpDown speedUpDown;
        private System.Windows.Forms.RadioButton rbtn_2x;
        private System.Windows.Forms.RadioButton rbtn_1x;
        private System.Windows.Forms.RadioButton rbtn_4x;
        private ProgressPanel progressPanel;
    }
}

