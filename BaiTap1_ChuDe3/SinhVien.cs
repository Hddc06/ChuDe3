using System;
using System.Collections.Generic;

namespace BaiTap1_ChuDe3
{
   public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoLot { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string Lop { get; set; }
        public string CMND { get; set; }
        public string SoDT { get; set; }
        public string DiaChi { get; set; }
        public List<string> MonHoc { get; set; }

        public SinhVien()
        {
            MonHoc = new List<string>();
        }

        public SinhVien(string mssv, string hoLot, string ten,
            DateTime ngaySinh, bool gioiTinh, string lop,
            string cmnd, string soDT, string diaChi,
            List<string> monHoc)
        {
            this.MSSV = mssv;
            this.HoLot = hoLot;
            this.Ten = ten;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.Lop = lop;
            this.CMND = cmnd;
            this.SoDT = soDT;
            this.DiaChi = diaChi;
            this.MonHoc = monHoc;
        }
    }
}