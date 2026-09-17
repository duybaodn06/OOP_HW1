using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai07
{
    internal class Management
    {
        private Person[] danhSach;
        private int n;

        public Management(int n)
        {
            this.n = 0;
            danhSach = new Person[n];
        }
        public bool Them(Person person)
        {
            try
            {
                danhSach[n] = person;
                n++;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Xoa(string hoTen)
        {
            try
            {
                int temp = -1;
                for (int i = 0; i < n; i++)
                {
                    if (danhSach[i].hoTen == hoTen)
                    {
                        danhSach[i] = null;
                        temp = i;
                    }
                }
                if (temp != -1)
                {
                    for (int i = temp; i < n - 1; i++)
                    {
                        danhSach[i] = danhSach[i + 1];
                    }
                    this.n--;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }  
        }
        public void SapXep()
        {
            for (int i = 0; i < danhSach.Length - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(danhSach[j].hoTen, danhSach[j + 1].hoTen) < 0 ? true : false)
                    {
                        (danhSach[j], danhSach[j + 1]) = (danhSach[j + 1], danhSach[j]);
                    }
                }
            }
        }
        //public override string ToString()
        //{
        //    return "";
        //}
    }
}
