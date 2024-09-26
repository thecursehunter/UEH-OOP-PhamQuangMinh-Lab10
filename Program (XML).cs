using System.Security.Cryptography;
using System.Xml.Serialization;

namespace OOP___Lab_10;
/*
class ProgramXML
{
    static void Main(string[] args)
    {
        //Bước 1: tạo 1 list các Students
        StudentList stList = new StudentList();
        stList.Students.Add(new Student{Name = "Minh", Age = 19});
        stList.Students.Add(new Student{Name = "Duy", Age = 22});

        //Bước 2: Serialize danh sách học sinh sang file XML và viết vào file
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(StudentList));
        using (StreamWriter writer = new StreamWriter("data.xml")) {
            xmlSerializer.Serialize(writer, stList);
        }

        //Bước 3: Đọc dữ liệu XML từ file vào 1 string mới
        string  xmlData  = File.ReadAllText("data.xml");

        //Step 4: Deserialize XML String vào 1 StudentList mới
        StudentList newStudentList;
        using (StringReader reader = new StringReader(xmlData)) {
            newStudentList = (StudentList)xmlSerializer.Deserialize(reader);
        }

        //Step 5: Thêm 1 hoặc 2 Students vào danh sách
        newStudentList.Students.Add(new Student {Name = "Danh", Age = 23});
        newStudentList.Students.Add(new Student { Name = "Trí", Age = 22});

        //Step 6: Serialize danh sách đã được cập nhật và viết nó lại vào chung 1 file
        using (StreamWriter writer = new StreamWriter("data.xml")) {
            xmlSerializer.Serialize(writer, newStudentList);
        }

        //Step 7: Đọc và cho thấy dữ liệu đã được cập nhật
        string updatedXML = File.ReadAllText("data.xml");
        StudentList updatedStudentList;
        using (StringReader reader = new StringReader(updatedXML)) {
           updatedStudentList = ((StudentList)xmlSerializer.Deserialize(reader));
        }

        //Cho thấy danh sách Student được cập nhật
        System.Console.WriteLine("Danh sách sinh viên đã được cập nhật");
        foreach (Student student in updatedStudentList.Students) {
            System.Console.WriteLine($"Tên: {student.Name}, AesGcm: {student.Age}");
        }
    }
}
*/