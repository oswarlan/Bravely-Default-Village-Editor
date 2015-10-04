using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bravely_Default_Save_Editor {
    public partial class Form1 : Form {
        static int villagerCountOffset = 0x4; // Villager count offset at 0x4-0x5
        //Village Building Byte contains the offsets for where the info is stored. Relevant data for both is 0x2 long (level and number of workers)
        static int[] villageBuildingByte = new int[] { 0x56, 0x68, 0x7A, 0x8C, 0x9E, 0xB0, 0xC2, 0xD4, 0xE6, 0xF8, 0x10A };
        byte[] saveFileVillagerCount = new byte[2], newVillagerCount = new byte[2]; //store save data, and new user data
        byte[] saveFileVillageBuildingLevel = new byte[11], // 11 buildings, therefore, 11 slots to hold data
            saveFileVillageUpgraders = new byte[11],
            newVillageBuildingLevel = new byte[11],
            VillageUpraders = new byte[11];
        string filePath;
        public Form1() {
            InitializeComponent();
            saveToolStripMenuItem.Enabled = false;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            openFileDialog1.ShowDialog();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            for (int i = 0; i < 11; i++) {
                if (newVillageBuildingLevel[i] != saveFileVillageBuildingLevel[i]) {
                    Stream outStream = File.Open(filePath, FileMode.Open);
                    outStream.Seek(villageBuildingByte[i], SeekOrigin.Begin);
                    outStream.WriteByte(newVillageBuildingLevel[i]);
                    outStream.Close();
                    saveFileVillageBuildingLevel[i] = newVillageBuildingLevel[i];
                }
            }
            if (errorProvider1.GetError(NewVillagerCountInput) != null) {
                Stream outStream = File.Open(filePath, FileMode.Open);
                outStream.Seek(villagerCountOffset, SeekOrigin.Begin);
                outStream.WriteByte(newVillagerCount[0]);
                outStream.WriteByte(newVillagerCount[1]);
                outStream.Close();
                newVillagerCount.CopyTo(saveFileVillagerCount, 0);
                VillagerCountDisplay.Text = ConvertPopulationToDec().ToString();
            }
        }
        private void NewVillagerCountInput_TextChanged(object sender, EventArgs e) {
            int number;
            bool result = Int32.TryParse(NewVillagerCountInput.Text, out number);
            if (result && number >= 0) {
                byte byte2 = (byte)((number / 128) * 0x10);
                byte byte1 = (byte)(number - ((byte2 * 128) / 0x10));
                newVillagerCount[0] = byte1;
                newVillagerCount[1] = byte2;
                errorProvider1.Clear();
                if (filePath != null)
                    saveToolStripMenuItem.Enabled = true;
            }
            else {
                errorProvider1.SetError(NewVillagerCountInput, "Must contain a number between 0 and 999");
                saveToolStripMenuItem.Enabled = false;
            }
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) {
            filePath = openFileDialog1.FileName;
            string fileName = openFileDialog1.SafeFileName;
            if (fileName.Equals("COLONY0.sav") || fileName.Equals("COLONY1.sav") || fileName.Equals("COLONY2.sav")) {
                saveToolStripMenuItem.Enabled = true;
                using (FileStream str = File.OpenRead(filePath)) {
                    for (int i = 0; i < 11; i++) {// 11 buildings, so i < 11
                        //read village data, and store it in arrays
                        str.Seek(villageBuildingByte[i], SeekOrigin.Begin);
                        str.Read(saveFileVillageBuildingLevel, i, 1);
                    }
                    //read population data, and store it
                    str.Seek(villagerCountOffset, SeekOrigin.Begin);
                    str.Read(saveFileVillagerCount, 0, 1);
                    str.Read(saveFileVillagerCount, 1, 1);
                    str.Close();
                    saveFileVillageBuildingLevel.CopyTo(newVillageBuildingLevel, 0);
                    saveFileVillagerCount.CopyTo(newVillagerCount, 0);
                    // UGLY way to update all the boxes to show current values. Special Move shop needs special work due to its byte containing 2 bits of data
                    VillageBuildingNewLevel1.Text = (saveFileVillageBuildingLevel[0] % 0x10).ToString();
                    VillageBuildingNewLevel2.Text = saveFileVillageBuildingLevel[1].ToString();
                    VillageBuildingNewLevel3.Text = saveFileVillageBuildingLevel[2].ToString();
                    VillageBuildingNewLevel4.Text = saveFileVillageBuildingLevel[3].ToString();
                    VillageBuildingNewLevel5.Text = saveFileVillageBuildingLevel[4].ToString();
                    VillageBuildingNewLevel6.Text = saveFileVillageBuildingLevel[5].ToString();
                    VillageBuildingNewLevel7.Text = saveFileVillageBuildingLevel[6].ToString();
                    VillageBuildingNewLevel8.Text = saveFileVillageBuildingLevel[7].ToString();
                    VillageBuildingNewLevel9.Text = saveFileVillageBuildingLevel[8].ToString();
                    VillageBuildingNewLevel10.Text = saveFileVillageBuildingLevel[9].ToString();
                    VillageBuildingNewLevel11.Text = saveFileVillageBuildingLevel[10].ToString();
                    VillagerCountDisplay.Text = ConvertPopulationToDec().ToString();
                }
            }
            else
                MessageBox.Show("You need to select the 'COLONY#.sav' file, or this program will not function corretly");
        }

        private void VillageBuildingNewLevel1_SelectedIndexChanged(object sender, EventArgs e) {
            if (VillageBuildingNewLevel1.SelectedIndex > saveFileVillageBuildingLevel[0])
                newVillageBuildingLevel[0] -= (byte)(VillageBuildingNewLevel1.SelectedIndex - saveFileVillageBuildingLevel[0] % 0x10 + 1);
            else
                newVillageBuildingLevel[0] += (byte)(VillageBuildingNewLevel1.SelectedIndex - saveFileVillageBuildingLevel[0] % 0x10 + 1);
        }
        private void VillageBuildingNewLevel2_SelectedIndexChanged(object sender, EventArgs e) {
            newVillageBuildingLevel[1] = (byte)(VillageBuildingNewLevel2.SelectedIndex + 1);
        }
        private void VillageBuildingNewLevel3_SelectedIndexChanged(object sender, EventArgs e) {
            newVillageBuildingLevel[2] = (byte)(VillageBuildingNewLevel3.SelectedIndex + 1);
        }
        private void VillageBuildingNewLevel4_SelectedIndexChanged(object sender, EventArgs e) {
            newVillageBuildingLevel[3] = (byte)(VillageBuildingNewLevel4.SelectedIndex + 1);
        }
        private void VillageBuildingNewLevel5_SelectedIndexChanged(object sender, EventArgs e) {
            newVillageBuildingLevel[4] = (byte)(VillageBuildingNewLevel5.SelectedIndex + 1);
        }
        private void VillageBuildingNewLevel6_SelectedIndexChanged(object sender, EventArgs e) {
            newVillageBuildingLevel[5] = (byte)(VillageBuildingNewLevel6.SelectedIndex + 1);
        }
        private void VillageBuildingNewLevel7_SelectedIndexChanged(object sender, EventArgs e) {
            newVillageBuildingLevel[6] = (byte)(VillageBuildingNewLevel7.SelectedIndex + 1);
        }
        private void VillageBuildingNewLevel8_SelectedIndexChanged(object sender, EventArgs e) {
            newVillageBuildingLevel[7] = (byte)(VillageBuildingNewLevel8.SelectedIndex + 1);
        }
        private void VillageBuildingNewLevel9_SelectedIndexChanged(object sender, EventArgs e) {
            newVillageBuildingLevel[8] = (byte)(VillageBuildingNewLevel9.SelectedIndex + 1);
        }
        private void VillageBuildingNewLevel10_SelectedIndexChanged(object sender, EventArgs e) {
            newVillageBuildingLevel[9] = (byte)(VillageBuildingNewLevel10.SelectedIndex + 1);
        }
        private void VillageBuildingNewLevel11_SelectedIndexChanged(object sender, EventArgs e) {
            newVillageBuildingLevel[10] = (byte)(VillageBuildingNewLevel11.SelectedIndex + 1);
        }
        public int ConvertPopulationToDec() {
            return saveFileVillagerCount[0] + ((saveFileVillagerCount[1] / 0x10) * 128);
        }
        public int ConvertPopulationToHex() {
            return 0x0000;
        }
    }
}
