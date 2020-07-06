using System;
using System.Windows.Forms;
using System.IO;

namespace LiveWinCounter
{
    public partial class WinCounter : Form
    {
        public WinCounter()
        {
            InitializeComponent();
            if (!File.Exists("wins.txt"))
            {
                File.WriteAllText("wins.txt", "0");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists("wins.txt"))
            {
                File.WriteAllText("wins.txt", "0");
                return;
            }
            string winsRaw = File.ReadAllText("wins.txt");
            int wins = 0;
            try
            {
                wins = Int32.Parse(winsRaw) + 1;
            }catch
            {
                wins = 0;
            }
            File.WriteAllText("wins.txt", wins.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText("wins.txt", "0");
        }
    }
}
