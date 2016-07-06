using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace test1
{
    public partial class MainForm2 : Form
    {
        public MainForm2()
        {
            InitializeComponent();
        }
        private string pl ;
        private string ci;
        private int type;
        private int p=5;
        private int q=7;
        private int n=35;
        private int dekey;
        private int enkey;
        private String plaintext = "";
        private String ciphertext = "";
        private double protime;
        private double codetime;
        private void quitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void keybutton_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            this.Produce();
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            protime = ts.TotalMilliseconds;
            this.qBox.Text = q.ToString();
            this.pBox.Text = p.ToString();
            this.nBox.Text = n.ToString();
            this.dekeyBox.Text = n.ToString()+","+dekey.ToString();
            this.enkeyBox.Text = n.ToString() + "," +enkey.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Produce()  //产生公钥和密钥函数
        {
            Random ran = new Random();
	        while(true)
	        {
		        p = ran.Next(1,100);
		        q = ran.Next(1,100);
		        if (isPrime(p) && isPrime(q)&&p!=q)
			        break;
	        }
	        n = p * q;
	        int fiN = (p - 1) * (q - 1);
	        //int e;
	        for (int i = 3; i < fiN; i++)
	        {
		        if (isPrime(i) && gcd(fiN, i) == 1)
		        {
			        enkey = i;
			        break;
		        }
	        }

	        Euler(enkey, fiN);
        }
        private int gcd(int a, int b)  //求出a与b的公因子
        {
	        if (a == 0)
	        {
		        return b;
	        }
	        else
	        {
		        return gcd(b % a, a);
	        }
        }

         private void Euler(int e, int fin)  //求出e相对模fin的乘法逆元
        {
	        int u1 = 1;
	        int u2 = 0;
	        int u3 = fin;
	        int v1 = 0;
	        int v2 = 1;
	        int v3 = e;
	      //  int v = 1;
	        int t1, t2, t3;
	        int q;
	        int uu, vv;
	        int inverse, z;
	        while (v3 != 0)
	        {
		        q = (int)(u3 /v3);
		        t1 = u1 - q * v1;
		        t2 = u2 - q * v2;
		        t3 = u3 - q * v3;
		        u1 = v1;
		        u2 = v2;
		        u3 = v3;
		        v1 = t1;
		        v2 = t2;
		        v3 = t3;
		        z =  1;
	        }
	        uu = u1;
	        vv = u2;
	        if (vv < 0)
		        inverse = vv + fin;
	        else
		        inverse = vv;
	        dekey = inverse;
        }
         private bool isPrime(int x)  //判断整数i是否为素数
        {	
	        int i;
	        for (i = 2; i <= (int)Math.Sqrt(x); i++)
	        {
		        if (x % i == 0)
			        break;
	        }
            if (i > (int)Math.Sqrt(x))
		        return true;
	        return false;
        }

         private void enbutton_Click(object sender, EventArgs e)
         {
             if (this.qBox.Text.Length == 0)
                 MessageBox.Show("密钥未生成");
             else if (this.plainBox.Text.Length > 0)//输入新的明文
             {
                 cipherBox.Text = "";
                 plaintext = this.plainBox.Text;
                 Stopwatch sw = new Stopwatch();
                 sw.Start();
                 RSA rsa = new RSA(0);
                 ciphertext = rsa.OnCode(plaintext, enkey, n);
                 sw.Stop();
                 TimeSpan ts = sw.Elapsed;
                 codetime = ts.TotalMilliseconds;
                 resultBox.Text = ciphertext;
                 MessageBox.Show("加密总花费" + (codetime + protime).ToString() + "ms.");
             }
                  
         }
         private void debutton_Click(object sender, EventArgs e)
         {
             if (this.qBox.Text.Length == 0)
                 MessageBox.Show("密钥未生成");
             else if (this.cipherBox.Text.Length > 0)//输入新的密文
             {
                 plainBox.Text = "";
                 ciphertext = this.cipherBox.Text;
                 Stopwatch sw = new Stopwatch();
                 sw.Start();
                 RSA rsa = new RSA(1);
                 plaintext = rsa.OnDecode(ciphertext, dekey, n);
                 sw.Stop();
                 TimeSpan ts = sw.Elapsed;
                 codetime = ts.TotalMilliseconds;
                 resultBox.Text =  plaintext;
                 MessageBox.Show("解密总花费"+(codetime+protime).ToString()+"ms.");
             }
             else//不输入新密文，直接解密
             {
                 Stopwatch sw = new Stopwatch();
                 sw.Start();
                 RSA rsa0 = new RSA(1);
                 plaintext = rsa0.OnDecode(ciphertext, dekey, n);
                 sw.Stop();
                 TimeSpan ts = sw.Elapsed;
                 codetime = ts.TotalMilliseconds;
                 resultBox.Text =  plaintext;
                 MessageBox.Show("解密总花费" + (codetime + protime).ToString() + "ms.");
             }
         }
         private void pinbutton_Click(object sender, EventArgs e)
         {
            // byte[] tmp = new byte[100];
             String path = plainBox.Text;
             plainBox.Text = Read(path);
         }

         private void cinbutton_Click(object sender, EventArgs e)
         {
             //byte[] tmp = new byte[100];
             String path = cipherBox.Text;
             cipherBox.Text = Read(path);
         }

         private void savebutton_Click(object sender, EventArgs e)
         {
             this.Write(saveBox.Text, resultBox.Text);
         }
         public String Read(string path)
         {
             StreamReader sr = new StreamReader(path, Encoding.Default);
             String line;
             String temp = ""; 
             while ((line = sr.ReadLine()) != null)
             {
                 temp += line;
             }
             return temp;
         }
         public void Write(string path,string result)
         {
              try 
            {
                if (path.Length > 0)
                {
                     FileStream fs = new FileStream(path, FileMode.Create);
                     StreamWriter sw = new StreamWriter(fs);
                     //开始写入
                     sw.Write(result);
                     //清空缓冲区
                     MessageBox.Show("导出成功！");
                     sw.Flush();
                     //关闭流
                     sw.Close();
                     fs.Close();
                }
                else
                    MessageBox.Show("Path should not be null!");
            }
              catch (IOException)
              {
                  MessageBox.Show("File save error!");
              }
         }
         private void label1_Click(object sender, EventArgs e)
         {

         }

         private void label7_Click(object sender, EventArgs e)
         {

         }
     }
}
