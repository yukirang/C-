using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace test1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }    
        
        private List <byte> pl=new List<byte>();//明文字节List
        private List<byte> ci = new List<byte>();//密文字节List
        List<byte> kl = new List<byte>();//密钥字节List
        private byte[] key = Encoding.UTF8.GetBytes("computer");//初始化密钥
        private int type;
        private double time;
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void EnButton_Click(object sender, EventArgs e)
        {
            type = 0;
            byte[] tmp1 = new byte[100];
            if (this.keyBox.Text.Length > 0)//输入新的密钥
                key = Encoding.Default.GetBytes(this.keyBox.Text);
            foreach (byte b in key)//将密钥录入kl;
                kl.Add(b);
            if (this.plainBox.Text.Length > 0)//输入新的明文
            {
                cipherBox.Text = "";
                tmp1 = Encoding.Default.GetBytes(this.plainBox.Text);
                pl.Clear();
                for (int i = 0; i <  tmp1.Length; i++)
                    pl.Add(tmp1[i]);//将明文录入pl
                DES des = new DES(0);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                this.ci = des.DesRun(pl, kl);//DES 加密
                sw.Stop();
                TimeSpan ts = sw.Elapsed;
                time = ts.TotalMilliseconds;
                tmp1 = ListToByteArray(ci);
                resultBox.Text = "加密后："+Encoding.Default.GetString(tmp1);//打印结果
                MessageBox.Show("加密总花费" + (time.ToString() + "ms."));
            }
            kl.Clear();
            key = Encoding.UTF8.GetBytes("computer");//重置初始密钥
         }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deButton_Click(object sender, EventArgs e)
        {
            type = 1;
            byte[] tmp = new byte[100];
            if (this.keyBox.Text.Length > 0)
                key = Encoding.Default.GetBytes(this.keyBox.Text);//输入新的密钥
            foreach (byte b in key)//将密钥录入kl;
                kl.Add(b);
            if (this.cipherBox.Text.Length > 0)//输入新的密文
            {
                plainBox.Text = "";
                DES des1 = new DES(1);
                ci.Clear();
                tmp = Encoding.Default.GetBytes(this.cipherBox.Text);//字符串转换为字节数组
                for (int i = 0; i < tmp.Length; i++)
                    ci.Add(tmp[i]);//将密文录入ci
                Stopwatch sw = new Stopwatch();
                sw.Start();
                pl = des1.DesRun(ci, kl);
                tmp = ListToByteArray(pl);
                sw.Stop();
                TimeSpan ts = sw.Elapsed;
                time = ts.TotalMilliseconds;
                resultBox.Text ="解密后："+Encoding.Default.GetString(tmp);
                MessageBox.Show("解密总花费" + (time.ToString() + "ms."));
            }
            else//不输入新明文，直接解密
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                DES des0 = new DES(1);
                pl = des0.DesRun(this.ci, this.kl);//DES 解密
                sw.Stop();
                TimeSpan ts = sw.Elapsed;
                time = ts.TotalMilliseconds;
                tmp = ListToByteArray(pl);
                resultBox.Text="解密后："+Encoding.Default.GetString(tmp);//打印结果 
                MessageBox.Show("解密总花费" + (time.ToString() + "ms."));
            }
            kl.Clear();
            key = Encoding.UTF8.GetBytes("computer");//重置初始密钥
        }

        public byte[] ListToByteArray(List<byte> list)//将字节List转换为字节数组
        {
            byte[] bt = new byte[list.Count];
            for(int i=0;i<list.Count;i++)
                bt[i] = list[i];
            return bt;
        }  
        private void button1_Click_1(object sender, EventArgs e)
        {
            byte[] tmp = new byte[100];
            String path=plainBox.Text;
            Read(path,tmp);
            pl.Clear();
            foreach (byte b in tmp)
                pl.Add(b);
            plainBox.Text = Encoding.Default.GetString(tmp);
        }
        private void button2_Click(object sender, EventArgs e)
        {

            byte[] tmp = new byte[100];
            String path =cipherBox.Text;
            Read(path, tmp);
            ci.Clear();
            foreach (byte b in tmp)
                ci.Add(b);
            cipherBox.Text = Encoding.Default.GetString(tmp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            byte[] tmp = new byte[100];
            Write(saveBox.Text);
        }
        public void Read(String path,byte[]tmp)
        {
            try
            {
                if (path.Length > 0)
                {
                    FileStream file = new FileStream(path, FileMode.Open);
                    file.Seek(0, SeekOrigin.Begin);
                    file.Read(tmp, 0, 100);
                }
                else
                    MessageBox.Show("Path should not be null!");
        
            }
            catch (IOException e)
            {
                MessageBox.Show("Path error!");
                Console.WriteLine(e);
  
            }
        }
        public void Write(String path)
        {
            try 
            {
                if (path.Length > 0)
                {
                    FileStream fs = new FileStream(path, FileMode.Append);
                    StreamWriter sw = new StreamWriter(fs);

                    sw.Write(DateTime.Now.ToString() + resultBox.Text);
                    sw.WriteLine("");
                    MessageBox.Show("导出成功！");

                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
                else
                    MessageBox.Show("Path should not be null!");
            }
            catch(IOException)
            {
                 MessageBox.Show("File save error!");
            }
        }

    }
}
