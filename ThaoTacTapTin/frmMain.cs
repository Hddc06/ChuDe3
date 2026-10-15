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
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System.Xml;
using System.Xml.Serialization;

namespace ThaoTacTapTin
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private List<StudentInfo> LoadJSON(string path)
        {
            List<StudentInfo> list = new List<StudentInfo>();

            StreamReader r = new StreamReader(path);

            string json = r.ReadToEnd();

            r.Close();

            var array = (JObject)JsonConvert.DeserializeObject(json);

            var students = array["sinhvien"].Children();

            foreach (var item in students)
            {
                string mssv = item["MSSV"].Value<string>();
                string hoten = item["hoten"].Value<string>();
                int tuoi = item["tuoi"].Value<int>();
                double diem = item["diem"].Value<double>();
                bool tongiao = item["tongiao"].Value<bool>();

                StudentInfo info = new StudentInfo(
                    mssv,
                    hoten,
                    tuoi,
                    diem,
                    tongiao);

                list.Add(info);
            }

            return list;
        }
        private void btnDocFile_Click(object sender, EventArgs e)
        {
            string str = "";

            string path = Path.Combine(
                Application.StartupPath,
                "students.json");

            List<StudentInfo> list = LoadJSON(path);

            for (int i = 0; i < list.Count; i++)
            {
                StudentInfo info = list[i];

                str += string.Format(
                    "Sinh viên {0} có MSSV: {1}, họ tên: {2}, điểm TB: {3}\r\n",
                    i + 1,
                    info.MSSV,
                    info.Hoten,
                    info.Diem);
            }

            MessageBox.Show(str);
        }

        private void btnReadXML_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(
                Application.StartupPath,
                "books.xml");

            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load(path);

            XmlNodeList nodeList =
                xmlDoc.DocumentElement.SelectNodes("/catalog/book");

            string str = "";

            foreach (XmlNode node in nodeList)
            {
                string isbn =
                    node.Attributes["ISBN"].Value;

                string title =
                    node.SelectSingleNode("title").InnerText;

                string price =
                    node.SelectSingleNode("price").InnerText;

                string firstName =
                    node.SelectSingleNode(
                        "author/first-name").InnerText;

                string lastName =
                    node.SelectSingleNode(
                        "author/last-name").InnerText;

                str += isbn + " | " +
                       title + " | " +
                       firstName + " " + lastName + " | " +
                       price + "\r\n";
            }

            MessageBox.Show(str);
        }

        private void btnWriteXML_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(
                Application.StartupPath,
                "books_write.xml");

            XmlWriterSettings settings = new XmlWriterSettings();

            settings.Indent = true;
            settings.Encoding = System.Text.Encoding.UTF8;

            using (XmlWriter writer = XmlWriter.Create(path, settings))
            {
                writer.WriteStartDocument();

                writer.WriteComment("This is a book sample XML");

                writer.WriteStartElement("book");

                writer.WriteAttributeString(
                    "ISBN",
                    "9831123212");

                writer.WriteAttributeString(
                    "yearpublished",
                    "2002");

                writer.WriteElementString(
                    "author",
                    "Mahesh Chand");

                writer.WriteElementString(
                    "title",
                    "Visual C# Programming");

                writer.WriteElementString(
                    "price",
                    "44.95");

                writer.WriteEndElement();

                writer.WriteEndDocument();
            }

            MessageBox.Show(
                "Ghi file XML thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnSerializeXML_Click(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>();

            books.Add(new Book(
                "9831123212",
                "A Programmer's Guide to ADO .Net using C#",
                "Mahesh Chand",
                44.99m,
                2002));

            books.Add(new Book(
                "9781484234",
                "Pro Entity Framework Core 1",
                "Adam Freeman",
                44.99m,
                2018));

            SaveToXmlFile(books);

            MessageBox.Show(
                "Đã ghi danh sách sách ra XML!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void SaveToXmlFile(List<Book> books)
        {
            string path = Path.Combine(
                Application.StartupPath,
                "books_serializer.xml");

            XmlSerializer serializer =
                new XmlSerializer(typeof(List<Book>));

            using (StreamWriter writer =
                new StreamWriter(path))
            {
                serializer.Serialize(writer, books);
            }
        }
    }
}
