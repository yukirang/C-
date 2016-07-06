using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace test1
{
    class DES
    {
        public DES(int type)
        {
         
            this.flag = type;
        }

        private int flag;
        private int addlen;
        //置换IP表
        private int[] ip={
        58,50,42,34,26,18,10,2,
        60,52,44,36,28,20,12,4,
        62,54,46,38,30,22,14,6,
        64,56,48,40,32,24,16,8,
        57,49,41,33,25,17,9,1,
        59,51,43,35,27,19,11,3,
        61,53,45,37,29,21,13,5,
        63,55,47,39,31,23,15,7 
        };
        //逆置换IP-1表
        private int[] ipr={
        40,8,48,16,56,24,64,32,
        39,7,47,15,55,23,63,31,
        38,6,46,14,54,22,62,30,
        37,5,45,13,53,21,61,29,
        36,4,44,12,52,20,60,28,
        35,3,43,11,51,19,59,27,
        34,2,42,10,50,18,58,26,
        33,1,41,9,49,17,57,25
        };
        //E 位选择表
        private int[] e={
        32,1, 2, 3, 4, 5,4, 5,
        6, 7, 8, 9,8, 9, 10,11,
        12,13,12,13,14,15,16,17,
        16,17,18,19,20,21,20,21,
        22,23,24,25,24,25,26,27,
        28,29,28,29,30,31,32,1
        };
        //P换位表
        private int[] p={
        16,7,20,21,29,12,28,17,
        1,15,23,26,5,18,31,10,
        2,8,24,14,32,27,3,9,19,
        13,30,6,22,11,4,25
        };
        //pc1选位表
        private int[] pc1={
        57,49,41,33,25,17,9,1,
        58,50,42,34,26,18,10,2,
        59,51,43,35,27,19,11,3,
        60,52,44,36,63,55,47,39,
        31,23,15,7,62,54,46,38,
        30,22,14,6,61,53,45,37,
        29,21,13,5,28,20,12,4
        };
        //pc2选位表
        private int[] pc2={
        14,17,11,24,1,5,3,28,
        15,6,21,10,23,19,12,4,
        26,8,16,7,27,20,13,2,
        41,52,31,37,47,55,30,40,
        51,45,33,48,44,49,39,56,
        34,53,46,42,50,36,29,32
        };
        //左移位数表
        private int[] shl={1,1,2,2,2,2,2,2,1,2,2,2,2,2,2,1};
        //S盒
        private int[,,] s={
        //s1
        {{14, 4, 13, 1, 2, 15, 11, 8, 3, 10, 6, 12, 5, 9, 0, 7},
        {0, 15, 7, 4, 14, 2, 13, 1, 10, 6, 12, 11, 9, 5, 3, 8},
        {4, 1, 14, 8, 13, 6, 2, 11, 15, 12, 9, 7, 3, 10, 5, 0},
        {15, 12, 8, 2, 4, 9, 1, 7, 5, 11, 3, 14, 10, 0, 6, 13}},
        //s2
        {{15, 1, 8, 14, 6, 11, 3, 4, 9, 7, 2, 13, 12, 0, 5, 10},
        {3, 13, 4, 7, 15, 2, 8, 14, 12, 0, 1, 10, 6, 9, 11, 5},
        {0, 14, 7, 11, 10, 4, 13, 1, 5, 8, 12, 6, 9, 3, 2, 15},
        {13, 8, 10, 1, 3, 15, 4, 2, 11, 6, 7, 12, 0, 5, 14, 9}},
        //s3
        {{10, 0, 9, 14, 6, 3, 15, 5, 1, 13, 12, 7, 11, 4, 2, 8},
        {13, 7, 0, 9, 3, 4, 6, 10, 2, 8, 5, 14, 12, 11, 15, 1},
        {13, 6, 4, 9, 8, 15, 3, 0, 11, 1, 2, 12, 5, 10, 14, 7},
        {1, 10, 13, 0, 6, 9, 8, 7, 4, 15, 14, 3, 11, 5, 2, 12}},
        //s4
        {{7, 13, 14, 3, 0, 6, 9, 10, 1, 2, 8, 5, 11, 12, 4, 15},
        {13, 8, 11, 5, 6, 15, 0, 3, 4, 7, 2, 12, 1, 10, 14, 9},
        {10, 6, 9, 0, 12, 11, 7, 13, 15, 1, 3, 14, 5, 2, 8, 4},
        {3, 15, 0, 6, 10, 1, 13, 8, 9, 4, 5, 11, 12, 7, 2, 14}},
        //s5
        {{2, 12, 4, 1, 7, 10, 11, 6, 8, 5, 3, 15, 13, 0, 14, 9},
        {14, 11, 2, 12, 4, 7, 13, 1, 5, 0, 15, 10, 3, 9, 8, 6},
        {4, 2, 1, 11, 10, 13, 7, 8, 15, 9, 12, 5, 6, 3, 0, 14},
        {11, 8, 12, 7, 1, 14, 2, 13, 6, 15, 0, 9, 10, 4, 5, 3}},
        //s6
        {{12, 1, 10, 15, 9, 2, 6, 8, 0, 13, 3, 4, 14, 7, 5, 11},
        {10, 15, 4, 2, 7, 12, 9, 5, 6, 1, 13, 14, 0, 11, 3, 8},
        {9, 14, 15, 5, 2, 8, 12, 3, 7, 0, 4, 10, 1, 13, 11, 6},
        {4, 3, 2, 12, 9, 5, 15, 10, 11, 14, 1, 7, 6, 0, 8, 13}},
        //s7
        {{4, 11, 2, 14, 15, 0, 8, 13, 3, 12, 9, 7, 5, 10, 6, 1},
        {13, 0, 11, 7, 4, 9, 1, 10, 14, 3, 5, 12, 2, 15, 8, 6},
        {1, 4, 11, 13, 12, 3, 7, 14, 10, 15, 6, 8, 0, 5, 9, 2},
        {6, 11, 13, 8, 1, 4, 10, 7, 9, 5, 0, 15, 14, 2, 3, 12}},
        //s8
        {{13, 2, 8, 4, 6, 15, 11, 1, 10, 9, 3, 14, 5, 0, 12, 7},
        {1, 15, 13, 8, 10, 3, 7, 4, 12, 5, 6, 11, 0, 14, 9, 2},
        {7, 11, 4, 1, 9, 12, 14, 2, 0, 6, 10, 13, 15, 3, 5, 8},
        {2, 1, 14, 7, 4, 10, 8, 13, 15, 12, 9, 0, 3, 5, 6, 11}}
        };
        public double time;
        private void BinaryIntArrayToByteList(int[] data, List<byte> value)// 将二进制数组转换为字节List
        {
            int i;
            String c = "";
            for (i = 0; i < data.Length; i++)//二进制整形数组转换为String
            {
                if (data[i] == 0)
                    c += '0';
                else
                    c += '1';
            }
            System.Text.RegularExpressions.CaptureCollection cs =
                System.Text.RegularExpressions.Regex.Match(c, @"([01]{8})+").Groups[1].Captures;//二进制String转换为字节序string
            for (i = 0; i < 8; i++)
            {
                value.Add(Convert.ToByte(cs[i].Value, 2));//String每两个字符转换为字节，并加入Value
            }
        }

        private int[] ByteListToBirnaryIntArray(List<byte> intdata)//字节List转换为二进制数组
        {
            int i;
            int j;
            int[] IntDa = new int[8];
            for (i = 0; i < 8; i++)
            {
                IntDa[i] = intdata[i];
                if (IntDa[i] < 0)
                {
                    IntDa[i] += 256;
                    IntDa[i] %= 256;
                }
            }
            int[] IntVa = new int[64];
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 8; j++)
                {
                    IntVa[((i * 8) + 7) - j] = IntDa[i] % 2;
                    IntDa[i] = IntDa[i] / 2;
                }
            }
            return IntVa;
        }

     //密钥数组初始化
	 private void KeyInit(int[] key, int[,] keyarray) {
	  int i;
	  int j;
	  int[] k = new int[56];
	  for (i = 0; i < 56; i++) {
          k[i] = key[pc1[i] - 1]; // PC-1生成子密钥keyarray[i,j]
	  }
	  for (i = 0; i < 16; i++) {
	   LeftMove(k, shl[i]); 
	   for (j = 0; j < 48; j++) {
	    keyarray[i,j] = k[pc2[j] - 1]; 
	   }
	  }
	 }
     private List<byte> DesEight(List<byte> des_key, List<byte> des_data)//单组DES
     {
         
         if ((des_key.Count != 8) || (des_data.Count != 8) || ((this.flag != 1) && (this.flag != 0)))//格式检查
         {
             throw new Exception();//抛出异常
         }
         int[] key = new int[64];
         int[] encrypt = new int[64];
         List<byte> EncryptCode = new List<byte>();// 加密完成后的字节数组
         int[,] KeyArray = new int[16, 48];// 密钥二进制字节数组

         key = ByteListToBirnaryIntArray(des_key);// 将加密数据字节数组转换成二进制字节数组
         encrypt = ByteListToBirnaryIntArray(des_data);// 字节List密钥转换为二维密钥数组
         KeyInit(key, KeyArray); // 密钥初始化
         EncryptCode = Encrypt(encrypt, KeyArray);// 加密解密
         return EncryptCode;
     }

     //加密解密
     private List<byte> Encrypt(int[] timeData, int[,] keyarray)
     {
	  int i;
      List<byte> encrypt = new List<byte> ();
	 
	  int[] ip0 = new int[64];
	  int[] ip_1 = new int[64];
	
	  for (i = 0; i < 64; i++) {
	   ip0[i] = timeData[ip[i] - 1]; // IP变换
	  }
	  if (this.flag == 1) { // 加密
	   for (i = 0; i < 16; i++) {
	    F_Func(ip0, i, keyarray);
	   }
	  } else if (this.flag == 0) { // 解密
	   for (i = 15; i >= 0; i--) {
	    F_Func(ip0, i, keyarray);
	   }
	  }
	  for (i = 0; i < 64; i++) {
	   ip_1[i] = ip0[ipr[i] - 1]; // IP逆运算
	  }
	  BinaryIntArrayToByteList(ip_1, encrypt);//二进制数组转换为字节List
	  return encrypt;
	 }

    
	 private void LeftMove(int[] k, int offset) {
	  int i;
	  // 循环移位操作函数
	  int[] c0 = new int[28];
	  int[] d0 = new int[28];
	  int[] c1 = new int[28];
	  int[] d1 = new int[28];
	  for (i = 0; i < 28; i++) {
	   c0[i] = k[i];
	   d0[i] = k[i + 28];
	  }
	  if (offset == 1) {
	   for (i = 0; i < 27; i++) { // 循环左移一位
	    c1[i] = c0[i + 1];
	    d1[i] = d0[i + 1];
	   }
	   c1[27] = c0[0];
	   d1[27] = d0[0];
	  } else if (offset == 2) {
	   for (i = 0; i < 26; i++) { // 循环左移两位
	    c1[i] = c0[i + 2];
	    d1[i] = d0[i + 2];
	   }
	   c1[26] = c0[0];
	   d1[26] = d0[0];
	   c1[27] = c0[1];
	   d1[27] = d0[1];
	  }
	  for (i = 0; i < 28; i++) {
	   k[i] = c1[i];
	   k[i + 28] = d1[i];
	  }
	 }

	 private void F_Func(int[] ind, int times,int[,] keyarray) {//f函数
	  int i;
	  int j;
	  int[] l0 = new int[32];
	  int[] r0 = new int[32];
	  int[] l1 = new int[32];
	  int[] r1 = new int[32];
	  int[] re = new int[48];
	  int[,] S = new int[8,6];
	  int[] sBoxData = new int[8];
	  int[] sValue = new int[32];
	  int[] rp = new int[32];
	  for (i = 0; i < 32; i++) {
	   l0[i] = ind[i]; // 明文左侧初始化
	   r0[i] = ind[i + 32]; // 明文右侧初始化
	  }
	  for (i = 0; i < 48; i++) {
	   re[i] = r0[e[i] - 1]; // E变换
	   re[i] = re[i] + keyarray[times,i]; // 与KeyArray[times][i]按位作不进位加法运算
	   if (re[i] == 2) {
	    re[i] = 0;
	   }
	  }
	  for (i = 0; i < 8; i++) 
      { // 48位分成8组
	   for (j = 0; j < 6; j++) {
	    S[i,j] = re[(i * 6) + j];
	   }
     
       sBoxData[i] = s[i, (S[i, 0] << 1) + S[i, 5], (S[i, 1] << 3) + (S[i, 2] << 2) + (S[i, 3] << 1) + S[i, 4]];  // S盒
	  
       for (j = 0; j < 4; j++)
       { // 输出到二进制数组
	    sValue[((i * 4) + 3) - j] = sBoxData[i] % 2;
	    sBoxData[i] = sBoxData[i] / 2;
	   }
	  }
	  for (i = 0; i < 32; i++) {
	   rp[i] = sValue[p[i] - 1]; // P变换
	   l1[i] = r0[i]; 
	   r1[i] = l0[i] + rp[i];
	   if (r1[i] == 2) {
	    r1[i] = 0;
	   }
	   // 重新合成ind
	   // 最后一次变换左右不互换
	   if (((this.flag == 0) && (times == 0)) || ((this.flag == 1) && (times == 15))) {
	    ind[i] = r1[i];
	    ind[i + 32] = l1[i];
	   }
	    else {
	    ind[i] = l1[i];
	    ind[i + 32] = r1[i];
	   }
	  }
	 }
     private List<byte> ByteListFormat(List<byte> data, int flag)//字节List填充
     {
      
      int len = data.Count;
	  int adlen = 8 - (len % 8);//增加字节数
	  int newlen = len + adlen;
      if (adlen == 8)
      {
          newlen = len;
          this.addlen = 0;
      }
      else
          this.addlen = adlen;
      byte addtmp = (byte)this.addlen;
      List<byte> newdata = new List<byte>();
      for (int i = 0; i < len; i++)
          newdata.Add(data[i]);//将数据字节加入newdata
      for (int j = len; j < newlen; j++)
          newdata.Add((byte)this.addlen);//用增加字节填充newdata
          return newdata;
	 }


     public List<byte>DesRun(List<byte>input,List<byte>in_key)//执行DES
     {
     
      List<byte> format_key = new  List<byte>(ByteListFormat(in_key, this.flag));
      List<byte> format_data =new  List<byte>(ByteListFormat(input, this.flag));
	  int datalen = format_data.Count;
	  int unitcount = datalen / 8;
      List<byte> result_data = new List<byte>();
      List<byte> tmpkey = new List<byte>();
      List<byte> tmpdata = new List<byte>();
	  for (int i = 0; i < unitcount; i++) {//按8字节分组，执行DES算法
          for (int j = 0; j < 8; j++)
          {
              tmpkey.Add(format_key[j]);
              tmpdata.Add(format_data[8*i+j]);
          }
         // Stopwatch sw = new Stopwatch();
         // sw.Start();
           List<byte> tmpresult = DesEight(tmpkey, tmpdata);//一组DES
          // sw.Stop();
          // TimeSpan ts = sw.Elapsed;
          // time = ts.TotalMilliseconds;
           foreach (byte c in tmpresult)
               result_data.Add(c);//将分组DES的结果加入最终结果List
           tmpdata.Clear();
           tmpkey.Clear();
           tmpresult.Clear();
	  }
      //解密过程，去掉结果中填充的字节
      if (this.flag == 1)
      {
          if (result_data.Count > 0)
          {
              int delete = result_data[result_data.Count - 1];//删除字节数
              if (delete > 7 || delete < 1)//不需要删除
                  return result_data;
              result_data.RemoveRange(result_data.Count - delete, delete);//删除多余字节
          }
      }     
      return result_data;
    }
  }
}
   

