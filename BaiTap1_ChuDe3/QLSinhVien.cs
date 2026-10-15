using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

using Newtonsoft.Json;
using System.Xml.Serialization;

namespace BaiTap1_ChuDe3
{
    class QLSinhVien
    {
        public List<SinhVien> dsSinhVien;

        public QLSinhVien()
        {
            dsSinhVien = new List<SinhVien>();
        }

        public void Them(SinhVien sv)
        {
            //dsSinhVien.Add(sv);
            //GhiVaoFile();

            dsSinhVien.Add(sv);
        }

        public bool CapNhat(SinhVien sv)
        {
            for (int i = 0; i < dsSinhVien.Count; i++)
            {
                if (dsSinhVien[i].MSSV == sv.MSSV)
                {
                    dsSinhVien[i] = sv;

                    //GhiVaoFile();

                    return true;
                }
            }

            return false;
        }

        public bool Xoa(string mssv)
        {
            for (int i = dsSinhVien.Count - 1; i >= 0; i--)
            {
                if (dsSinhVien[i].MSSV == mssv)
                {
                    dsSinhVien.RemoveAt(i);

                    //GhiVaoFile();

                    return true;
                }
            }

            return false;
        }

        public SinhVien TimTheoMSSV(string mssv)
        {
            foreach (SinhVien sv in dsSinhVien)
            {
                if (sv.MSSV == mssv)
                    return sv;
            }

            return null;
        }

        public List<SinhVien> TimTheoTen(string ten)
        {
            List<SinhVien> ketQua = new List<SinhVien>();

            foreach (SinhVien sv in dsSinhVien)
            {
                if (sv.Ten.IndexOf(
                    ten,
                    StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    ketQua.Add(sv);
                }
            }

            return ketQua;
        }

        public List<SinhVien> TimTheoLop(string lop)
        {
            List<SinhVien> ketQua = new List<SinhVien>();

            foreach (SinhVien sv in dsSinhVien)
            {
                if (sv.Lop.IndexOf(
                    lop,
                    StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    ketQua.Add(sv);
                }
            }

            return ketQua;
        }

        public void DocTuFile()
        {
            dsSinhVien.Clear();

            string path = Path.Combine(
                Application.StartupPath,
                "students.txt"); //MSSV    Họ lót    Tên    Ngày sinh    Giới tính    Lớp    CMND    SĐT    Địa chỉ    Môn học

            if (!File.Exists(path))
                return;

            StreamReader reader = new StreamReader(
                path,
                Encoding.UTF8);

            string dong;

            while ((dong = reader.ReadLine()) != null)
            {
                if (dong.Trim() == "")
                    continue;

                string[] s = dong.Split('\t');

                if (s.Length < 10)
                    continue;

                SinhVien sv = new SinhVien();

                sv.MSSV = s[0];
                sv.HoLot = s[1];
                sv.Ten = s[2];

                DateTime ngaySinh;

                if (DateTime.TryParseExact(
                    s[3],
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out ngaySinh))
                {
                    sv.NgaySinh = ngaySinh;
                }
                else
                {
                    sv.NgaySinh = DateTime.Now;
                }

                if (s[4] == "1")
                    sv.GioiTinh = true;
                else
                    sv.GioiTinh = false;

                sv.Lop = s[5];
                sv.CMND = s[6];
                sv.SoDT = s[7];
                sv.DiaChi = s[8];

                sv.MonHoc.Clear();

                string[] dsMon = s[9].Split(';');

                foreach (string mon in dsMon)
                {
                    if (mon.Trim() != "")
                        sv.MonHoc.Add(mon.Trim());
                }

                dsSinhVien.Add(sv);
            }

            reader.Close();
        }

        public void GhiVaoFile()
        {
            string path = Path.Combine(
                Application.StartupPath,
                "students.txt");

            StreamWriter writer = new StreamWriter(
                path,
                false,
                Encoding.UTF8);

            foreach (SinhVien sv in dsSinhVien)
            {
                string gioiTinh = "0";

                if (sv.GioiTinh)
                    gioiTinh = "1";

                string monHoc = "";

                for (int i = 0; i < sv.MonHoc.Count; i++)
                {
                    monHoc += sv.MonHoc[i];

                    if (i < sv.MonHoc.Count - 1)
                        monHoc += ";";
                }

                string dong =
                    sv.MSSV + "\t" +
                    sv.HoLot + "\t" +
                    sv.Ten + "\t" +
                    sv.NgaySinh.ToString("dd/MM/yyyy") + "\t" +
                    gioiTinh + "\t" +
                    sv.Lop + "\t" +
                    sv.CMND + "\t" +
                    sv.SoDT + "\t" +
                    sv.DiaChi + "\t" +
                    monHoc;

                writer.WriteLine(dong);
            }

            writer.Close();
        }
        public void GhiFileJSON()
        {
            string path = Path.Combine(
                Application.StartupPath,
                "students.json");

            string json = JsonConvert.SerializeObject(
                dsSinhVien,
                Formatting.Indented);

            File.WriteAllText(
                path,
                json,
                Encoding.UTF8);
        }
        public void DocFileJSON()
        {
            string path = Path.Combine(
                Application.StartupPath,
                "students.json");

            if (!File.Exists(path))
                return;

            string json = File.ReadAllText(
                path,
                Encoding.UTF8);

            if (json.Trim() == "")
                return;

            List<SinhVien> danhSach =
                JsonConvert.DeserializeObject<List<SinhVien>>(json);

            if (danhSach != null)
            {
                dsSinhVien = danhSach;
            }
        }
        public void GhiFileXML()
        {
            string path = Path.Combine(
                Application.StartupPath,
                "students.xml");

            XmlSerializer serializer =
                new XmlSerializer(typeof(List<SinhVien>));

            using (StreamWriter writer =
                new StreamWriter(path, false, Encoding.UTF8))
            {
                serializer.Serialize(writer, dsSinhVien);
            }
        }
        public bool DocFileXML()
        {
            string path = Path.Combine(
                Application.StartupPath,
                "students.xml");

            if (!File.Exists(path))
            {
                MessageBox.Show(
                    "Không tìm thấy file students.xml!\n" + path,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            XmlSerializer serializer =
                new XmlSerializer(typeof(List<SinhVien>));

            try
            {
                using (StreamReader reader =
                    new StreamReader(path, Encoding.UTF8))
                {
                    List<SinhVien> danhSach =
                        (List<SinhVien>)serializer.Deserialize(reader);

                    if (danhSach == null)
                    {
                        MessageBox.Show(
                            "Không đọc được danh sách sinh viên từ XML!");

                        return false;
                    }

                    dsSinhVien = danhSach;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi đọc XML:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }
    }
}