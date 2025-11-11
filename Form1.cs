using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 4; j++)
                {
                    //インスタンスの生成
                    testbotton testbotton = new testbotton();

                    //ボタンの位置を設定 
                    testbotton.Location = new Point(400 * i, 400);

                    // ボタンの大きさを設定
                    testbotton.Size = new Size(400, 400);

                    // ボタン内のテキスト追加
                    testbotton.Text = "あいうえお";

                    //コントロールにボタンを設定
                    Controls.Add(testbotton);
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("感謝を忘れない");
        }
    }
}
