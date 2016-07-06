using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class RSA
    {
        public RSA(int type)
        {
         
            this.flag = type;
        }

        private int flag;
        public String OnCode(String plaintext,int enkey,int n)   //加密函数
        {
	        String temp;
	        String encSt = "";
	        for (int i = 0; i < plaintext.Length; i++)
	        {
		        temp = encSt;
		        encSt =encSt+power((int)plaintext[i], enkey, n)+"+";
	        }
            return encSt;
        }
        public String OnDecode(String ciphertext,int dekey,int n)   // 解密函数
        {
	        String temp = "";
	        String DecSt  = "";
	        for (int i = 0,j = -1; i < ciphertext.Length;i++)
	        {
                if (ciphertext[i] == '+')
                {
                    for (int k = 1; k < i - j; k++)
                        temp = temp + ciphertext[j + k];
                    DecSt += Convert.ToChar((power(Convert.ToInt32(temp), dekey, n)));
                    temp = "";
                    j = i;
                }
	        }
            return DecSt;
        }


        public int power(int a, int n, int m) //求出a的n次方模m的值
        {
            int z=1, t;
	        for(t=a; n>0; n>>=1)
            { 
                 if (n%2==1) z=(z*t) % m;
                 t=(t*t) % m;
            }
	        return(z);
        }
    }
}
