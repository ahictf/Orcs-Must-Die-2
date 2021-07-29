
namespace Orcs_Must_Die_2
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox_Process = new System.Windows.Forms.GroupBox();
            this.checkBox_UnSP = new System.Windows.Forms.CheckBox();
            this.groupBox_Function2 = new System.Windows.Forms.GroupBox();
            this.groupBox_AobFunction = new System.Windows.Forms.GroupBox();
            this.checkBox_PlayerYawRotation = new System.Windows.Forms.CheckBox();
            this.checkBox_EnemyAttack = new System.Windows.Forms.CheckBox();
            this.checkBox_DontSee = new System.Windows.Forms.CheckBox();
            this.checkBox_ShotDelay = new System.Windows.Forms.CheckBox();
            this.checkBox_StopAllHealth = new System.Windows.Forms.CheckBox();
            this.checkBox_UnJump = new System.Windows.Forms.CheckBox();
            this.checkBox_AoB = new System.Windows.Forms.CheckBox();
            this.checkBox_UnHP = new System.Windows.Forms.CheckBox();
            this.checkBox_UnSkillPoint = new System.Windows.Forms.CheckBox();
            this.checkBox_UnMoney = new System.Windows.Forms.CheckBox();
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox_Process.SuspendLayout();
            this.groupBox_Function2.SuspendLayout();
            this.groupBox_AobFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Process
            // 
            this.groupBox_Process.Controls.Add(this.checkBox_UnSP);
            this.groupBox_Process.Controls.Add(this.groupBox_Function2);
            this.groupBox_Process.Controls.Add(this.checkBox_UnHP);
            this.groupBox_Process.Controls.Add(this.checkBox_UnSkillPoint);
            this.groupBox_Process.Controls.Add(this.checkBox_UnMoney);
            this.groupBox_Process.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Process.Name = "groupBox_Process";
            this.groupBox_Process.Size = new System.Drawing.Size(251, 320);
            this.groupBox_Process.TabIndex = 3;
            this.groupBox_Process.TabStop = false;
            this.groupBox_Process.Text = "Game Process : False";
            // 
            // checkBox_UnSP
            // 
            this.checkBox_UnSP.AutoSize = true;
            this.checkBox_UnSP.Location = new System.Drawing.Point(145, 51);
            this.checkBox_UnSP.Name = "checkBox_UnSP";
            this.checkBox_UnSP.Size = new System.Drawing.Size(86, 17);
            this.checkBox_UnSP.TabIndex = 3;
            this.checkBox_UnSP.Text = "Unlimited SP";
            this.checkBox_UnSP.UseVisualStyleBackColor = true;
            this.checkBox_UnSP.CheckedChanged += new System.EventHandler(this.checkBox_UnSP_CheckedChanged);
            // 
            // groupBox_Function2
            // 
            this.groupBox_Function2.Controls.Add(this.groupBox_AobFunction);
            this.groupBox_Function2.Controls.Add(this.checkBox_AoB);
            this.groupBox_Function2.Location = new System.Drawing.Point(17, 74);
            this.groupBox_Function2.Name = "groupBox_Function2";
            this.groupBox_Function2.Size = new System.Drawing.Size(215, 229);
            this.groupBox_Function2.TabIndex = 4;
            this.groupBox_Function2.TabStop = false;
            this.groupBox_Function2.Text = "AoB";
            // 
            // groupBox_AobFunction
            // 
            this.groupBox_AobFunction.Controls.Add(this.checkBox_PlayerYawRotation);
            this.groupBox_AobFunction.Controls.Add(this.checkBox_EnemyAttack);
            this.groupBox_AobFunction.Controls.Add(this.checkBox_DontSee);
            this.groupBox_AobFunction.Controls.Add(this.checkBox_ShotDelay);
            this.groupBox_AobFunction.Controls.Add(this.checkBox_StopAllHealth);
            this.groupBox_AobFunction.Controls.Add(this.checkBox_UnJump);
            this.groupBox_AobFunction.Location = new System.Drawing.Point(17, 45);
            this.groupBox_AobFunction.Name = "groupBox_AobFunction";
            this.groupBox_AobFunction.Size = new System.Drawing.Size(178, 166);
            this.groupBox_AobFunction.TabIndex = 5;
            this.groupBox_AobFunction.TabStop = false;
            // 
            // checkBox_PlayerYawRotation
            // 
            this.checkBox_PlayerYawRotation.AutoSize = true;
            this.checkBox_PlayerYawRotation.Location = new System.Drawing.Point(17, 133);
            this.checkBox_PlayerYawRotation.Name = "checkBox_PlayerYawRotation";
            this.checkBox_PlayerYawRotation.Size = new System.Drawing.Size(138, 17);
            this.checkBox_PlayerYawRotation.TabIndex = 10;
            this.checkBox_PlayerYawRotation.Text = "Prevent Player Rotation";
            this.checkBox_PlayerYawRotation.UseVisualStyleBackColor = true;
            this.checkBox_PlayerYawRotation.CheckedChanged += new System.EventHandler(this.checkBox_PlayerYawRotation_CheckedChanged);
            // 
            // checkBox_EnemyAttack
            // 
            this.checkBox_EnemyAttack.AutoSize = true;
            this.checkBox_EnemyAttack.Location = new System.Drawing.Point(17, 110);
            this.checkBox_EnemyAttack.Name = "checkBox_EnemyAttack";
            this.checkBox_EnemyAttack.Size = new System.Drawing.Size(91, 17);
            this.checkBox_EnemyAttack.TabIndex = 9;
            this.checkBox_EnemyAttack.Text = "Stop Enemies";
            this.checkBox_EnemyAttack.UseVisualStyleBackColor = true;
            this.checkBox_EnemyAttack.CheckedChanged += new System.EventHandler(this.checkBox_EnemyAttack_CheckedChanged);
            // 
            // checkBox_DontSee
            // 
            this.checkBox_DontSee.AutoSize = true;
            this.checkBox_DontSee.Location = new System.Drawing.Point(17, 88);
            this.checkBox_DontSee.Name = "checkBox_DontSee";
            this.checkBox_DontSee.Size = new System.Drawing.Size(150, 17);
            this.checkBox_DontSee.TabIndex = 8;
            this.checkBox_DontSee.Text = "Enemies Don\'t Notice You";
            this.checkBox_DontSee.UseVisualStyleBackColor = true;
            this.checkBox_DontSee.CheckedChanged += new System.EventHandler(this.checkBox_DontSee_CheckedChanged);
            // 
            // checkBox_ShotDelay
            // 
            this.checkBox_ShotDelay.AutoSize = true;
            this.checkBox_ShotDelay.Location = new System.Drawing.Point(17, 65);
            this.checkBox_ShotDelay.Name = "checkBox_ShotDelay";
            this.checkBox_ShotDelay.Size = new System.Drawing.Size(121, 17);
            this.checkBox_ShotDelay.TabIndex = 7;
            this.checkBox_ShotDelay.Text = "Remove Shot Delay";
            this.checkBox_ShotDelay.UseVisualStyleBackColor = true;
            this.checkBox_ShotDelay.CheckedChanged += new System.EventHandler(this.checkBox_ShotDelay_CheckedChanged);
            // 
            // checkBox_StopAllHealth
            // 
            this.checkBox_StopAllHealth.AutoSize = true;
            this.checkBox_StopAllHealth.Location = new System.Drawing.Point(17, 19);
            this.checkBox_StopAllHealth.Name = "checkBox_StopAllHealth";
            this.checkBox_StopAllHealth.Size = new System.Drawing.Size(96, 17);
            this.checkBox_StopAllHealth.TabIndex = 5;
            this.checkBox_StopAllHealth.Text = "Stop All Health";
            this.checkBox_StopAllHealth.UseVisualStyleBackColor = true;
            this.checkBox_StopAllHealth.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox_UnJump
            // 
            this.checkBox_UnJump.AutoSize = true;
            this.checkBox_UnJump.Location = new System.Drawing.Point(17, 42);
            this.checkBox_UnJump.Name = "checkBox_UnJump";
            this.checkBox_UnJump.Size = new System.Drawing.Size(97, 17);
            this.checkBox_UnJump.TabIndex = 6;
            this.checkBox_UnJump.Text = "Unlimited Jump";
            this.checkBox_UnJump.UseVisualStyleBackColor = true;
            this.checkBox_UnJump.CheckedChanged += new System.EventHandler(this.checkBox_UnJump_CheckedChanged);
            // 
            // checkBox_AoB
            // 
            this.checkBox_AoB.AutoSize = true;
            this.checkBox_AoB.Location = new System.Drawing.Point(17, 22);
            this.checkBox_AoB.Name = "checkBox_AoB";
            this.checkBox_AoB.Size = new System.Drawing.Size(90, 17);
            this.checkBox_AoB.TabIndex = 4;
            this.checkBox_AoB.Text = "AoB Function";
            this.checkBox_AoB.UseVisualStyleBackColor = true;
            this.checkBox_AoB.CheckedChanged += new System.EventHandler(this.checkBox_AoB_CheckedChanged);
            // 
            // checkBox_UnHP
            // 
            this.checkBox_UnHP.AutoSize = true;
            this.checkBox_UnHP.Location = new System.Drawing.Point(145, 28);
            this.checkBox_UnHP.Name = "checkBox_UnHP";
            this.checkBox_UnHP.Size = new System.Drawing.Size(87, 17);
            this.checkBox_UnHP.TabIndex = 2;
            this.checkBox_UnHP.Text = "Unlimited HP";
            this.checkBox_UnHP.UseVisualStyleBackColor = true;
            this.checkBox_UnHP.CheckedChanged += new System.EventHandler(this.checkBox_UnHP_CheckedChanged);
            // 
            // checkBox_UnSkillPoint
            // 
            this.checkBox_UnSkillPoint.AutoSize = true;
            this.checkBox_UnSkillPoint.Location = new System.Drawing.Point(17, 51);
            this.checkBox_UnSkillPoint.Name = "checkBox_UnSkillPoint";
            this.checkBox_UnSkillPoint.Size = new System.Drawing.Size(118, 17);
            this.checkBox_UnSkillPoint.TabIndex = 1;
            this.checkBox_UnSkillPoint.Text = "Unlimited Skill Point";
            this.checkBox_UnSkillPoint.UseVisualStyleBackColor = true;
            this.checkBox_UnSkillPoint.CheckedChanged += new System.EventHandler(this.checkBox_UnSkillPoint_CheckedChanged);
            // 
            // checkBox_UnMoney
            // 
            this.checkBox_UnMoney.AutoSize = true;
            this.checkBox_UnMoney.Location = new System.Drawing.Point(17, 28);
            this.checkBox_UnMoney.Name = "checkBox_UnMoney";
            this.checkBox_UnMoney.Size = new System.Drawing.Size(104, 17);
            this.checkBox_UnMoney.TabIndex = 0;
            this.checkBox_UnMoney.Text = "Unlimited Money";
            this.checkBox_UnMoney.UseVisualStyleBackColor = true;
            this.checkBox_UnMoney.CheckedChanged += new System.EventHandler(this.checkBox_UnMoney_CheckedChanged);
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 344);
            this.Controls.Add(this.groupBox_Process);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(294, 383);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(294, 383);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orcs Must Die 2 By AHICTF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.groupBox_Process.ResumeLayout(false);
            this.groupBox_Process.PerformLayout();
            this.groupBox_Function2.ResumeLayout(false);
            this.groupBox_Function2.PerformLayout();
            this.groupBox_AobFunction.ResumeLayout(false);
            this.groupBox_AobFunction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_Process;
        private System.Windows.Forms.CheckBox checkBox_UnSP;
        private System.Windows.Forms.CheckBox checkBox_UnHP;
        private System.Windows.Forms.CheckBox checkBox_UnSkillPoint;
        private System.Windows.Forms.CheckBox checkBox_UnMoney;
        private System.Windows.Forms.GroupBox groupBox_Function2;
        private System.Windows.Forms.CheckBox checkBox_AoB;
        private System.Windows.Forms.CheckBox checkBox_StopAllHealth;
        private System.Windows.Forms.CheckBox checkBox_UnJump;
        private System.Windows.Forms.GroupBox groupBox_AobFunction;
        private System.Windows.Forms.CheckBox checkBox_PlayerYawRotation;
        private System.Windows.Forms.CheckBox checkBox_EnemyAttack;
        private System.Windows.Forms.CheckBox checkBox_DontSee;
        private System.Windows.Forms.CheckBox checkBox_ShotDelay;
        private System.ComponentModel.BackgroundWorker BGWorker;
    }
}

