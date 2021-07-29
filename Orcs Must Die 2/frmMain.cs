using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using System.Threading.Tasks;

namespace Orcs_Must_Die_2
{
    public partial class frmMain : Form
    {
        public Mem MemLib = new Mem();
        public string addespro;
        bool ProcOpen = false;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            MemLib.OpenProcess("OrcsMustDie2");
            groupBox_Process.Enabled = false;
            groupBox_AobFunction.Enabled = false;
        }


        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (!MemLib.OpenProcess("OrcsMustDie2"))
                {
                    System.Threading.Thread.Sleep(1000);
                    BGWorker.ReportProgress(0);
                    ProcOpen = false;
                    return;
                }

                ProcOpen = true;

                System.Threading.Thread.Sleep(1000);
                BGWorker.ReportProgress(0);
            }
        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen == true)
            {
                groupBox_Process.Text = "Game Process : True";
                groupBox_Process.Enabled = true;


            }
            else
            {
                groupBox_Process.Text = "Game Process : False";
                groupBox_Process.Enabled = false;
            }
        }

        private void checkBox_UnMoney_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_UnMoney.Checked == true)
            {
                MemLib.FreezeValue("OrcsMustDie2.exe+0x007A4454,0x30C,0x40,0x310,0x7C", "int", "99999");
            }
            else if (checkBox_UnMoney.Checked == false)
            {
                MemLib.UnfreezeValue("OrcsMustDie2.exe+0x007A4454,0x30C,0x40,0x310,0x7C");
            }
            
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void checkBox_UnSkillPoint_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_UnSkillPoint.Checked == true)
            {
                MemLib.FreezeValue("OrcsMustDie2.exe+0x7B830C", "int", "99999");
            }
            else if (checkBox_UnSkillPoint.Checked == false)
            {
                MemLib.UnfreezeValue("OrcsMustDie2.exe+0x7B830C");
            }
            //OrcsMustDie2.exe + 7B830C
        }

        private void checkBox_UnHP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_UnHP.Checked == true)
            {
                MemLib.FreezeValue("OrcsMustDie2.exe+0x007A4454,0x140,0x2C,0x170,0x20,0x18,0x54", "float", "999");
            }
            else if (checkBox_UnHP.Checked == false)
            {
                MemLib.UnfreezeValue("OrcsMustDie2.exe+0x007A4454,0x140,0x2C,0x170,0x20,0x18,0x54");
            }
            //"OrcsMustDie2.exe" + 007A4454
        }

        private void checkBox_UnSP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_UnSP.Checked == true)
            {
                MemLib.FreezeValue("OrcsMustDie2.exe+0x007BA838,0x1C,0x2C,0x128,0x40,0x20,0x18,0x5C", "float", "999");
            }
            else if (checkBox_UnSP.Checked == false)
            {
                MemLib.UnfreezeValue("OrcsMustDie2.exe+0x007BA838,0x1C,0x2C,0x128,0x40,0x20,0x18,0x5C");
            }
            //"OrcsMustDie2.exe" + 007BA838
        }

        public string addespro_StopHealthWrite;
        public string addespro_JumpRepeatAnimation;
        public string addespro_JumpCheck;
        public string addespro_ShotDelay;
        public string addespro_EnemyNoticeYou;
        public string addespro_EnemyAttack;
        public string addespro_PlayerYawRotation;

        private async void checkBox_AoB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_AoB.Checked == true)
            {
                IEnumerable<long> AoBScanResults_StopHealthWrite = await MemLib.AoBScan(0x00000000, 0xffffffff, "0F 8B A6 00 00 00 F3 0F 11", false, true);
                IEnumerable<long> AoBScanResults_JumpRepeatAnimation = await MemLib.AoBScan(0x00000000, 0xffffffff, "74 1C 0F 57 C0 F3 0F 11 83 54 02 00 00", false, true);
                IEnumerable<long> AoBScanResults_JumpCheck = await MemLib.AoBScan(0x00000000, 0xffffffff, "74 45 0F 57 C0 24 FE 0C 02", false, true);
                IEnumerable<long> AoBScanResults_ShotDelay = await MemLib.AoBScan(0x00000000, 0xffffffff, "F3 0F 11 46 10 3B C3 75 04 33 FF EB 03", false, true);
                IEnumerable<long> AoBScanResults_EnemyNoticeYou = await MemLib.AoBScan(0x00000000, 0xffffffff, "75 28 80 7E 69 00 0F 84 E7 02 00 00 8B 81 D4 02 00 00", false, true);
                IEnumerable<long> AoBScanResults_EnemyAttack = await MemLib.AoBScan(0x00000000, 0xffffffff, "74 1D 8B C3 E8 ?? ?? ?? ?? 8B 4C 24 28", false, true);
                IEnumerable<long> AoBScanResults_PlayerYawRotation = await MemLib.AoBScan(0x00000000, 0xffffffff, "0F 84 96 00 00 00 8B 0D C0 F9 8C 00 8B 01 E8 ?? ?? ?? ?? 84 C0", false, true);


                long SingleAoBScanResult_StopHealthWrite = AoBScanResults_StopHealthWrite.FirstOrDefault();
                long SingleAoBScanResult_JumpRepeatAnimation = AoBScanResults_JumpRepeatAnimation.FirstOrDefault();
                long SingleAoBScanResult_JumpCheck = AoBScanResults_JumpCheck.FirstOrDefault();
                long SingleAoBScanResult_ShotDelay = AoBScanResults_ShotDelay.FirstOrDefault();
                long SingleAoBScanResult_EnemyNoticeYou = AoBScanResults_EnemyNoticeYou.FirstOrDefault();
                long SingleAoBScanResult_EnemyAttack = AoBScanResults_EnemyAttack.FirstOrDefault();
                long SingleAoBScanResult_PlayerYawRotation = AoBScanResults_PlayerYawRotation.FirstOrDefault();

                addespro_StopHealthWrite = SingleAoBScanResult_StopHealthWrite.ToString("X");
                addespro_JumpRepeatAnimation = SingleAoBScanResult_JumpRepeatAnimation.ToString("X");
                addespro_JumpCheck = SingleAoBScanResult_JumpCheck.ToString("X");
                addespro_ShotDelay = SingleAoBScanResult_ShotDelay.ToString("X");
                addespro_EnemyNoticeYou = SingleAoBScanResult_EnemyNoticeYou.ToString("X");
                addespro_EnemyAttack = SingleAoBScanResult_EnemyAttack.ToString("X");
                addespro_PlayerYawRotation = SingleAoBScanResult_PlayerYawRotation.ToString("X");

                groupBox_AobFunction.Enabled = true;
            }
            else if (checkBox_AoB.Checked == false)
            {
                groupBox_AobFunction.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_StopAllHealth.Checked == true)
            {
                string sAdresse = String.Format("{0:X2}", addespro_StopHealthWrite);
                MemLib.WriteMemory(sAdresse, "bytes", "0xE9 0xA7 0x00 0x00 0x00 0x90");
            }
            else if (checkBox_StopAllHealth.Checked == false)
            {
                string sAdresse = String.Format("{0:X2}", addespro_StopHealthWrite);
                MemLib.WriteMemory(sAdresse, "bytes", "0x0F 0x8B 0xA6 0x00 0x00 0x00");
            }
        }

        private void checkBox_UnJump_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_UnJump.Checked == true)
            {
                string sAdresse1 = String.Format("{0:X2}", addespro_JumpRepeatAnimation);
                string sAdresse2 = String.Format("{0:X2}", addespro_JumpCheck);
                MemLib.WriteMemory(sAdresse1, "bytes", "0x90 0x90");
                MemLib.WriteMemory(sAdresse2, "bytes", "0x90 0x90");
            }
            else if (checkBox_UnJump.Checked == false)
            {
                string sAdresse1 = String.Format("{0:X2}", addespro_JumpRepeatAnimation);
                string sAdresse2 = String.Format("{0:X2}", addespro_JumpCheck);
                MemLib.WriteMemory(sAdresse1, "bytes", "0x74 0x1C");
                MemLib.WriteMemory(sAdresse2, "bytes", "0x74 0x45");
            }
        }

        private void checkBox_ShotDelay_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShotDelay.Checked == true)
            {
                string sAdresse = String.Format("{0:X2}", addespro_ShotDelay);
                MemLib.WriteMemory(sAdresse, "bytes", "0x90 0x90 0x90 0x90 0x90");
            }
            else if (checkBox_ShotDelay.Checked == false)
            {
                string sAdresse = String.Format("{0:X2}", addespro_ShotDelay);
                MemLib.WriteMemory(sAdresse, "bytes", "0xF3 0x0F 0x11 0x46 0x10");
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void checkBox_DontSee_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_DontSee.Checked == true)
            {
                string sAdresse = String.Format("{0:X2}", addespro_EnemyNoticeYou);
                MemLib.WriteMemory(sAdresse, "bytes", "0x90 0x90");
            }
            else if (checkBox_DontSee.Checked == false)
            {
                string sAdresse = String.Format("{0:X2}", addespro_EnemyNoticeYou);
                MemLib.WriteMemory(sAdresse, "bytes", "0x75 0x28");
            }
        }

        private void checkBox_EnemyAttack_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_EnemyAttack.Checked == true)
            {
                string sAdresse = String.Format("{0:X2}", addespro_EnemyAttack);
                MemLib.WriteMemory(sAdresse, "bytes", "0x90 0x90");
            }
            else if (checkBox_EnemyAttack.Checked == false)
            {
                string sAdresse = String.Format("{0:X2}", addespro_EnemyAttack);
                MemLib.WriteMemory(sAdresse, "bytes", "0x74 0x1D");
            }
        }

        private void checkBox_PlayerYawRotation_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_PlayerYawRotation.Checked == true)
            {
                string sAdresse = String.Format("{0:X2}", addespro_PlayerYawRotation);
                MemLib.WriteMemory(sAdresse, "bytes", "0xEB 0x19 0x90 0x90 0x90 0x90");
            }
            else if (checkBox_PlayerYawRotation.Checked == false)
            {
                string sAdresse = String.Format("{0:X2}", addespro_PlayerYawRotation);
                MemLib.WriteMemory(sAdresse, "bytes", "0x0F 0x84 0x96 0x00 0x00 0x00");
            }
        }
    }
}
