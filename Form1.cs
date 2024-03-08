using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Original_Clock_5
{
    public partial class Form1 : Form
    {
        int endTime;
        int nowTime;
        int MouseX;
        int MouseY;


        public Form1()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox13.ImageLocation = "https://umaidango.github.io/net.png";

            


            // フォームの境界線、タイトルバーを無しに設定
            this.FormBorderStyle = FormBorderStyle.None;
            


            // フォームの不透明度を60%に設定（半透明化）
            this.Opacity = 1;

            int radius = 12;
            int diameter = radius * 2;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            // 左上
            gp.AddPie(0, 0, diameter, diameter, 180, 90);
            // 右上
            gp.AddPie(this.Width - diameter, 0, diameter, diameter, 270, 90);
            // 左下
            gp.AddPie(0, this.Height - diameter, diameter, diameter, 90, 90);
            // 右下
            gp.AddPie(this.Width - diameter, this.Height - diameter, diameter, diameter, 0, 90);
            // 中央
            gp.AddRectangle(new Rectangle(radius, 0, this.Width - diameter, this.Height));
            // 左
            gp.AddRectangle(new Rectangle(0, radius, radius, this.Height - diameter));
            // 右
            gp.AddRectangle(new Rectangle(this.Width - radius, radius, radius, this.Height - diameter));

            this.Region = new Region(gp);





            this.MaximizeBox = false;
            
            this.Text = Application.ProductName;
            timer1.Interval = 1000;
            timer1.Enabled = true;

            tabPage1.Text = "時計";
            tabPage2.Text = "背景";
            tabPage3.Text = "設定";
            tabPage4.Text = "タイマー";
            tabPage5.Text = "1";
            tabPage6.Text = "2";
            tabPage7.Text = "その他";


            
            button1.Text = "file1";
            button2.Text = "file2";
            button3.Text = "file3";
            button4.Text = "file4";
            button5.Text = "file5";
            button6.Text = "file6";
            button7.Text = "file7";
            button8.Text = "file8";
            button10.Text = "file10";
            button11.Text = "file12";
            button12.Text = "file13";
            button13.Text = "blue";
            button14.Text = "red";
            button15.Text = "black";
            button16.Text = "green";
            button21.Text = "設定を戻す（リセット）";


            radioButton1.Text = "小";
            radioButton2.Text = "中";
            



            


           



           
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
        }


        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           


            tabPage1.Font = new Font(label1.Font.FontFamily, 12);
            tabPage2.Font = new Font(label1.Font.FontFamily, 12);
            tabPage3.Font = new Font(label1.Font.FontFamily, 12);
            tabPage4.Font = new Font(label1.Font.FontFamily, 12);
            tabPage5.Font = new Font(label1.Font.FontFamily, 12);
            tabPage6.Font = new Font(label1.Font.FontFamily, 12);
            tabPage7.Font = new Font(label1.Font.FontFamily, 12);



            button1.Font = new Font(label1.Font.FontFamily, 12);
            button2.Font = new Font(label1.Font.FontFamily, 12);
            button3.Font = new Font(label1.Font.FontFamily, 12);
            button4.Font = new Font(label1.Font.FontFamily, 12);
            button5.Font = new Font(label1.Font.FontFamily, 12);
            button6.Font = new Font(label1.Font.FontFamily, 12);
            button7.Font = new Font(label1.Font.FontFamily, 12);
            button8.Font = new Font(label1.Font.FontFamily, 12);
            button10.Font = new Font(label1.Font.FontFamily, 12);
            button11.Font = new Font(label1.Font.FontFamily, 12);
            button12.Font = new Font(label1.Font.FontFamily, 12);
            button13.Font = new Font(label1.Font.FontFamily, 12);
            button14.Font = new Font(label1.Font.FontFamily, 12);
            button15.Font = new Font(label1.Font.FontFamily, 12);
            button16.Font = new Font(label1.Font.FontFamily, 12);
            button21.Font = new Font(label1.Font.FontFamily, 12);


            radioButton1.Font = new Font(label1.Font.FontFamily, 12);
            radioButton2.Font = new Font(label1.Font.FontFamily, 12);
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;



        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            tabPage1.Font = new Font(label1.Font.FontFamily, 9);
            tabPage2.Font = new Font(label1.Font.FontFamily, 9);
            tabPage3.Font = new Font(label1.Font.FontFamily, 9);
            tabPage4.Font = new Font(label1.Font.FontFamily, 9);
            tabPage5.Font = new Font(label1.Font.FontFamily, 9);
            tabPage6.Font = new Font(label1.Font.FontFamily, 9);
            tabPage7.Font = new Font(label1.Font.FontFamily, 9);



            button1.Font = new Font(label1.Font.FontFamily, 9);
            button2.Font = new Font(label1.Font.FontFamily, 9);
            button3.Font = new Font(label1.Font.FontFamily, 9);
            button4.Font = new Font(label1.Font.FontFamily, 9);
            button5.Font = new Font(label1.Font.FontFamily, 9);
            button6.Font = new Font(label1.Font.FontFamily, 9);
            button7.Font = new Font(label1.Font.FontFamily, 9);
            button8.Font = new Font(label1.Font.FontFamily, 9);
            button10.Font = new Font(label1.Font.FontFamily, 9);
            button11.Font = new Font(label1.Font.FontFamily, 9);
            button12.Font = new Font(label1.Font.FontFamily, 9);
            button13.Font = new Font(label1.Font.FontFamily, 9);
            button14.Font = new Font(label1.Font.FontFamily, 9);
            button15.Font = new Font(label1.Font.FontFamily, 9);
            button16.Font = new Font(label1.Font.FontFamily, 9);
            button21.Font = new Font(label1.Font.FontFamily, 9);


            radioButton1.Font = new Font(label1.Font.FontFamily, 9);
            radioButton2.Font = new Font(label1.Font.FontFamily, 9);
            

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }



        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tabPage1.BackgroundImage = Original_Clock_5.Properties.Resources.h_k_a0000;

           

           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabPage1.BackgroundImage = Original_Clock_5.Properties.Resources.h_k_a0005;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabPage1.BackgroundImage = Original_Clock_5.Properties.Resources.h_k_a0004;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabPage1.BackgroundImage = Original_Clock_5.Properties.Resources.h_k_a0002;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabPage1.BackgroundImage = Original_Clock_5.Properties.Resources.h_k_a0003;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabPage1.BackgroundImage = Original_Clock_5.Properties.Resources.h_k_a0001;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabPage1.BackgroundImage = Original_Clock_5.Properties.Resources.h_k_a0000;
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("画像追加予定です。",
                "工事中",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("画像追加予定です。",
                "工事中",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("画像追加予定です。",
                "工事中",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("画像追加予定です。",
                "工事中",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabPage1.BackgroundImage = global::Original_Clock_5.Properties.Resources.h_k_a00007;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("画像追加予定です。",
                "工事中",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            

            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.ItemSize = new Size(73, 25);
            tabControl1.Size = new Size(502, 267);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Green;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            tabPage1.BackgroundImage = Original_Clock_5.Properties.Resources.h_k_a0001;

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            tabPage1.BackgroundImage = Original_Clock_5.Properties.Resources.h_k_a0003;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            tabPage1.BackgroundImage = Original_Clock_5.Properties.Resources.h_k_a0002;
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            tabPage1.BackgroundImage = Original_Clock_5.Properties.Resources.h_k_a0004;
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            tabPage1.BackgroundImage = Original_Clock_5.Properties.Resources.h_k_a0005;
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            //FontDialogクラスのインスタンスを作成
            FontDialog fd = new FontDialog();

            //初期のフォントを設定
            fd.Font = label1.Font;
            //初期の色を設定
            fd.Color = label1.ForeColor;
            //ユーザーが選択できるポイントサイズの最大値を設定する
            fd.MaxSize = 250;
            fd.MinSize = 24;
            //存在しないフォントやスタイルをユーザーが選択すると
            //エラーメッセージを表示する
            fd.FontMustExist = true;
            //横書きフォントだけを表示する
            fd.AllowVerticalFonts = false;
            //色を選択できるようにする
            fd.ShowColor = true;
            //取り消し線、下線、テキストの色などのオプションを指定可能にする
            //デフォルトがTrueのため必要はない
            fd.ShowEffects = true;
            //固定ピッチフォント以外も表示する
            //デフォルトがFalseのため必要はない
            fd.FixedPitchOnly = false;
            //ベクタ フォントを選択できるようにする
            //デフォルトがTrueのため必要はない
            fd.AllowVectorFonts = true;

            //ダイアログを表示する
            if (fd.ShowDialog() != DialogResult.Cancel)
            {

                label1.Font = fd.Font;
                label1.ForeColor = fd.Color;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

            //ダイアログを表示する


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(textSetTime.Text, out endTime))
            {
                endTime = 1;

            }

            nowTime = 0;

            timer2.Start();


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int remainingTime;
            nowTime++;

            remainingTime = endTime - nowTime;
            TextremainingTime.Text = remainingTime.ToString();

            if (endTime == nowTime)
            {
                timer2.Stop();


                MessageBox.Show("時間になりました！！！");







            }


            else
            {

            }


        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.TopMost = !TopMost;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //using System.Windows.Forms;

            //メッセージボックスを表示する
            MessageBox.Show("Original Clock Ver.5.06",
                "Version",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);


        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            

               
            

        }

        private void button21_Click(object sender, EventArgs e)
        {
            tabPage1.BackgroundImage = null;
            label1.ForeColor = Color.Black;
            this.TopMost = false;

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void TextremainingTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void hureru_MouseMove(object sender, MouseEventArgs e)
        {
            this.pictureBox9.Image = global::Original_Clock_5.Properties.Resources.close_2;


        }

        private void kaeru_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox9.Image = global::Original_Clock_5.Properties.Resources.close_1;
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void window_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.MouseX = e.X;
                this.MouseY = e.Y;
            }
        }

        private void window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - MouseX;
                this.Top += e.Y - MouseY;

            }
        }

        private void saisyouka_MouseDown(object sender, MouseEventArgs e)
        {
            


        }

        private void saisyouka_MouseMove(object sender, MouseEventArgs e)
        {
            this.pictureBox10.Image = global::Original_Clock_5.Properties.Resources.saisyouka_2;
        }

        private void saisyouka_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox10.Image = global::Original_Clock_5.Properties.Resources.saisyouka_1;
        }

        

        private void progressBar1_Click(object sender, EventArgs e)
        {

            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            //自分自身のフォームを最大化
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox12_Click_1(object sender, EventArgs e)
        {
            tabPage1.BackgroundImage = global::Original_Clock_5.Properties.Resources.h_k_a00007;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void pictureBox13_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
