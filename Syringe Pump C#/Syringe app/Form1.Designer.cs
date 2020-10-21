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
            this.connection_status = new System.Windows.Forms.TextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.exit_button = new System.Windows.Forms.Button();
            this.settings_group = new System.Windows.Forms.GroupBox();
            this.bolus = new System.Windows.Forms.Button();
            this.speed_unit = new System.Windows.Forms.Label();
            this.set_syringe = new System.Windows.Forms.Button();
            this.syringe_unit = new System.Windows.Forms.Label();
            this.set_speed = new System.Windows.Forms.Button();
            this.syringe_status = new System.Windows.Forms.TextBox();
            this.syringeCombobox = new System.Windows.Forms.ComboBox();
            this.speed_status = new System.Windows.Forms.TextBox();
            this.syringe_lbl = new System.Windows.Forms.Label();
            this.speed_lbl = new System.Windows.Forms.Label();
            this.speedCombobox = new System.Windows.Forms.ComboBox();
            this.stop_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.forth_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.connection_group = new System.Windows.Forms.GroupBox();
            this.port_txt = new System.Windows.Forms.TextBox();
            this.run_status = new System.Windows.Forms.TextBox();
            this.statusGroup = new System.Windows.Forms.GroupBox();
            this.time_elapsed_txt = new System.Windows.Forms.Label();
            this.injected = new System.Windows.Forms.TextBox();
            this.syringe1ml = new System.Windows.Forms.TextBox();
            this.syringe_pict = new System.Windows.Forms.PictureBox();
            this.progress_bar = new System.Windows.Forms.Panel();
            this.move_groupbox = new System.Windows.Forms.GroupBox();
            this.home_1 = new System.Windows.Forms.Button();
            this.pos_start_btn = new System.Windows.Forms.Button();
            this.minimalize_btn = new System.Windows.Forms.Button();
            this.syringe1group = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.move_speed_lbl = new System.Windows.Forms.Label();
            this.track_speed1 = new System.Windows.Forms.TrackBar();
            this.bolus_group = new System.Windows.Forms.GroupBox();
            this.bolusInj = new System.Windows.Forms.NumericUpDown();
            this.bolusSpeed = new System.Windows.Forms.NumericUpDown();
            this.bolus_distance_lbl = new System.Windows.Forms.Label();
            this.bolus_speed_lbl = new System.Windows.Forms.Label();
            this.distance_lbl = new System.Windows.Forms.Label();
            this.bolus_start = new System.Windows.Forms.Button();
            this.bolus_lbl = new System.Windows.Forms.Label();
            this.exit_bolus = new System.Windows.Forms.Button();
            this.deleteMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSyringeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.settings_group.SuspendLayout();
            this.connection_group.SuspendLayout();
            this.statusGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.syringe_pict)).BeginInit();
            this.move_groupbox.SuspendLayout();
            this.syringe1group.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_speed1)).BeginInit();
            this.bolus_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bolusInj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolusSpeed)).BeginInit();
            this.deleteMenu.SuspendLayout();
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
            this.exit_button.Location = new System.Drawing.Point(709, 0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(24, 25);
            this.exit_button.TabIndex = 24;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // settings_group
            // 
            this.settings_group.Controls.Add(this.bolus);
            this.settings_group.Controls.Add(this.speed_unit);
            this.settings_group.Controls.Add(this.set_syringe);
            this.settings_group.Controls.Add(this.syringe_unit);
            this.settings_group.Controls.Add(this.set_speed);
            this.settings_group.Controls.Add(this.syringe_status);
            this.settings_group.Controls.Add(this.syringeCombobox);
            this.settings_group.Controls.Add(this.speed_status);
            this.settings_group.Controls.Add(this.syringe_lbl);
            this.settings_group.Controls.Add(this.speed_lbl);
            this.settings_group.Controls.Add(this.speedCombobox);
            this.settings_group.Font = new System.Drawing.Font("Courier New", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settings_group.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.settings_group.Location = new System.Drawing.Point(10, 15);
            this.settings_group.Name = "settings_group";
            this.settings_group.Size = new System.Drawing.Size(262, 129);
            this.settings_group.TabIndex = 8;
            this.settings_group.TabStop = false;
            this.settings_group.Text = "Settings";
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
            this.speed_unit.Location = new System.Drawing.Point(132, 75);
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
            // syringe_unit
            // 
            this.syringe_unit.AutoSize = true;
            this.syringe_unit.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.syringe_unit.Location = new System.Drawing.Point(132, 26);
            this.syringe_unit.Name = "syringe_unit";
            this.syringe_unit.Size = new System.Drawing.Size(21, 14);
            this.syringe_unit.TabIndex = 12;
            this.syringe_unit.Text = "ml";
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
            this.syringeCombobox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.syringeCombobox.FormattingEnabled = true;
            this.syringeCombobox.Items.AddRange(new object[] {
            "1",
            "5",
            "20"});
            this.syringeCombobox.Location = new System.Drawing.Point(79, 20);
            this.syringeCombobox.Name = "syringeCombobox";
            this.syringeCombobox.Size = new System.Drawing.Size(47, 22);
            this.syringeCombobox.TabIndex = 1;
            this.syringeCombobox.SelectionChangeCommitted += new System.EventHandler(this.syringeCombobox_SelectionChangeCommitted);
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
            // speedCombobox
            // 
            this.speedCombobox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.speedCombobox.Items.AddRange(new object[] {
            "0,01",
            "0,1",
            "0,18",
            "1",
            "10",
            "15",
            "20"});
            this.speedCombobox.Location = new System.Drawing.Point(79, 70);
            this.speedCombobox.Name = "speedCombobox";
            this.speedCombobox.Size = new System.Drawing.Size(47, 22);
            this.speedCombobox.TabIndex = 3;
            this.speedCombobox.SelectionChangeCommitted += new System.EventHandler(this.speedCombobox_SelectionChangeCommitted);
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
            this.panel1.Size = new System.Drawing.Size(685, 18);
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
            this.port_txt.Text = "ffafafa";
            this.port_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // run_status
            // 
            this.run_status.BackColor = System.Drawing.Color.White;
            this.run_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.run_status.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.run_status.Location = new System.Drawing.Point(12, 222);
            this.run_status.Multiline = true;
            this.run_status.Name = "run_status";
            this.run_status.ReadOnly = true;
            this.run_status.Size = new System.Drawing.Size(265, 20);
            this.run_status.TabIndex = 10;
            this.run_status.TabStop = false;
            // 
            // statusGroup
            // 
            this.statusGroup.Controls.Add(this.time_elapsed_txt);
            this.statusGroup.Controls.Add(this.injected);
            this.statusGroup.Controls.Add(this.syringe1ml);
            this.statusGroup.Controls.Add(this.run_status);
            this.statusGroup.Controls.Add(this.syringe_pict);
            this.statusGroup.Controls.Add(this.progress_bar);
            this.statusGroup.Font = new System.Drawing.Font("Courier New", 7F);
            this.statusGroup.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.statusGroup.Location = new System.Drawing.Point(10, 226);
            this.statusGroup.Name = "statusGroup";
            this.statusGroup.Size = new System.Drawing.Size(438, 331);
            this.statusGroup.TabIndex = 19;
            this.statusGroup.TabStop = false;
            this.statusGroup.Text = "Run Console";
            // 
            // time_elapsed_txt
            // 
            this.time_elapsed_txt.AutoSize = true;
            this.time_elapsed_txt.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.time_elapsed_txt.Location = new System.Drawing.Point(167, 26);
            this.time_elapsed_txt.Name = "time_elapsed_txt";
            this.time_elapsed_txt.Size = new System.Drawing.Size(183, 16);
            this.time_elapsed_txt.TabIndex = 15;
            this.time_elapsed_txt.Text = "Elapsed time: 0h:00m:00s";
            // 
            // injected
            // 
            this.injected.BackColor = System.Drawing.Color.White;
            this.injected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.injected.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.injected.Location = new System.Drawing.Point(79, 306);
            this.injected.Multiline = true;
            this.injected.Name = "injected";
            this.injected.ReadOnly = true;
            this.injected.Size = new System.Drawing.Size(269, 20);
            this.injected.TabIndex = 35;
            this.injected.TabStop = false;
            this.injected.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // syringe1ml
            // 
            this.syringe1ml.BackColor = System.Drawing.Color.White;
            this.syringe1ml.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.syringe1ml.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.syringe1ml.Location = new System.Drawing.Point(135, 280);
            this.syringe1ml.Name = "syringe1ml";
            this.syringe1ml.ReadOnly = true;
            this.syringe1ml.Size = new System.Drawing.Size(165, 16);
            this.syringe1ml.TabIndex = 33;
            this.syringe1ml.TabStop = false;
            this.syringe1ml.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // syringe_pict
            // 
            this.syringe_pict.Location = new System.Drawing.Point(9, 20);
            this.syringe_pict.Name = "syringe_pict";
            this.syringe_pict.Size = new System.Drawing.Size(422, 226);
            this.syringe_pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.syringe_pict.TabIndex = 12;
            this.syringe_pict.TabStop = false;
            // 
            // progress_bar
            // 
            this.progress_bar.Location = new System.Drawing.Point(10, 252);
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(422, 22);
            this.progress_bar.TabIndex = 14;
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
            this.minimalize_btn.Location = new System.Drawing.Point(685, 0);
            this.minimalize_btn.Name = "minimalize_btn";
            this.minimalize_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.minimalize_btn.Size = new System.Drawing.Size(24, 25);
            this.minimalize_btn.TabIndex = 23;
            this.minimalize_btn.Text = "-";
            this.minimalize_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimalize_btn.UseVisualStyleBackColor = false;
            this.minimalize_btn.Click += new System.EventHandler(this.minimalize_btn_Click);
            // 
            // syringe1group
            // 
            this.syringe1group.Controls.Add(this.groupBox2);
            this.syringe1group.Controls.Add(this.stop_btn);
            this.syringe1group.Controls.Add(this.move_groupbox);
            this.syringe1group.Controls.Add(this.start_btn);
            this.syringe1group.Controls.Add(this.statusGroup);
            this.syringe1group.Controls.Add(this.settings_group);
            this.syringe1group.Controls.Add(this.bolus_group);
            this.syringe1group.Font = new System.Drawing.Font("Courier New", 7F);
            this.syringe1group.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.syringe1group.Location = new System.Drawing.Point(12, 102);
            this.syringe1group.Name = "syringe1group";
            this.syringe1group.Size = new System.Drawing.Size(457, 567);
            this.syringe1group.TabIndex = 30;
            this.syringe1group.TabStop = false;
            this.syringe1group.Text = "1st Syringe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.move_speed_lbl);
            this.groupBox2.Controls.Add(this.track_speed1);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 7F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Location = new System.Drawing.Point(158, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 69);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Move speed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 7F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(116, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 34;
            this.label5.Text = "Quarter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 7F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(190, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 34;
            this.label4.Text = "Half";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 7F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(257, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 33;
            this.label3.Text = "Full";
            // 
            // move_speed_lbl
            // 
            this.move_speed_lbl.AutoSize = true;
            this.move_speed_lbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.move_speed_lbl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.move_speed_lbl.Location = new System.Drawing.Point(6, 17);
            this.move_speed_lbl.Name = "move_speed_lbl";
            this.move_speed_lbl.Size = new System.Drawing.Size(100, 16);
            this.move_speed_lbl.TabIndex = 8;
            this.move_speed_lbl.Text = "Move speed:";
            // 
            // track_speed1
            // 
            this.track_speed1.BackColor = System.Drawing.Color.White;
            this.track_speed1.LargeChange = 1;
            this.track_speed1.Location = new System.Drawing.Point(124, 13);
            this.track_speed1.Maximum = 3;
            this.track_speed1.Minimum = 1;
            this.track_speed1.Name = "track_speed1";
            this.track_speed1.Size = new System.Drawing.Size(161, 45);
            this.track_speed1.TabIndex = 0;
            this.track_speed1.TabStop = false;
            this.track_speed1.Value = 1;
            this.track_speed1.ValueChanged += new System.EventHandler(this.track_speed1_ValueChanged);
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
            1000,
            0,
            0,
            0});
            this.bolusInj.Minimum = new decimal(new int[] {
            1,
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
            this.bolusSpeed.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.bolusSpeed.Location = new System.Drawing.Point(115, 18);
            this.bolusSpeed.Maximum = new decimal(new int[] {
            200,
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
            // deleteMenu
            // 
            this.deleteMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.deleteMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSyringeToolStripMenuItem});
            this.deleteMenu.Name = "deleteMenu";
            this.deleteMenu.Size = new System.Drawing.Size(149, 26);
            // 
            // deleteSyringeToolStripMenuItem
            // 
            this.deleteSyringeToolStripMenuItem.Name = "deleteSyringeToolStripMenuItem";
            this.deleteSyringeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.deleteSyringeToolStripMenuItem.Text = "Delete syringe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(62, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "Syringe pump";
            // 
            // mainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.syringe1group);
            this.Controls.Add(this.minimalize_btn);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.connection_group);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Syringe Pump";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.settings_group.ResumeLayout(false);
            this.settings_group.PerformLayout();
            this.connection_group.ResumeLayout(false);
            this.connection_group.PerformLayout();
            this.statusGroup.ResumeLayout(false);
            this.statusGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.syringe_pict)).EndInit();
            this.move_groupbox.ResumeLayout(false);
            this.syringe1group.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_speed1)).EndInit();
            this.bolus_group.ResumeLayout(false);
            this.bolus_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bolusInj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolusSpeed)).EndInit();
            this.deleteMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox connection_status;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.GroupBox settings_group;
        private System.Windows.Forms.ComboBox speedCombobox;
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
        private System.Windows.Forms.TextBox run_status;
        private System.Windows.Forms.PictureBox syringe_pict;
        private System.Windows.Forms.GroupBox statusGroup;
        private System.Windows.Forms.GroupBox move_groupbox;
        private System.Windows.Forms.Button pos_start_btn;
        private System.Windows.Forms.Label syringe_unit;
        private System.Windows.Forms.Label speed_unit;
        private System.Windows.Forms.Button set_syringe;
        private System.Windows.Forms.Button home_1;
        private System.Windows.Forms.Panel progress_bar;
        private System.Windows.Forms.Button minimalize_btn;
        private System.Windows.Forms.Label time_elapsed_txt;
        private System.Windows.Forms.GroupBox syringe1group;
        private System.Windows.Forms.ContextMenuStrip deleteMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteSyringeToolStripMenuItem;
        private System.Windows.Forms.TextBox syringe1ml;
        private System.Windows.Forms.TextBox injected;
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
        private System.Windows.Forms.TrackBar track_speed1;
        private System.Windows.Forms.Label move_speed_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown bolusSpeed;
        private System.Windows.Forms.NumericUpDown bolusInj;
        private System.Windows.Forms.Label label1;
    }
}

