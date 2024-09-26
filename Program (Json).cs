using System.Security.Cryptography;
using System.Text.Json;
using System.Xml.Serialization;

namespace OOP___Lab_10;

class ProgramJson
{
    static void Main(string[] args)
    {
        //Bước 1: tạo 1 list các Students
        StudentList stList = new StudentList();
        stList.Students.Add(new Student{Name = "Minh", Age = 19});
        stList.Students.Add(new Student{Name = "Duy", Age = 22});

        //Bước 2: Serialize danh sách học sinh sang file Json và viết vào file
        string jsonString = JsonSerializer.Serialize(stList);
        File.WriteAllText("data.dat", jsonString);

        //Bước 3: Đọc dữ liệu Json từ file vào 1 string mới
        string  newJson  = File.ReadAllText("data.dat");

        //Step 4: Deserialize XML String vào 1 StudentList mới
        StudentList newStudentList = JsonSerializer.Deserialize<StudentList>(newJson);

        //Step 5: Thêm 1 hoặc 2 Students vào danh sách
        newStudentList.Students.Add(new Student {Name = "Danh", Age = 23});
        newStudentList.Students.Add(new Student { Name = "Trí", Age = 22});

        //Step 6: Serialize danh sách đã được cập nhật và viết nó lại vào chung 1 file
        string updatedJsonString = JsonSerializer.Serialize(newStudentList);
        File.WriteAllText("data.dat", updatedJsonString);

        //Step 7: Đọc và cho thấy dữ liệu đã được cập nhật
        string updatedJson = File.ReadAllText("data.dat");
        StudentList updatedStudentList = JsonSerializer.Deserialize<StudentList>(updatedJson);

        //Cho thấy danh sách Student được cập nhật
        System.Console.WriteLine("Danh sách sinh viên đã được cập nhật");
        foreach (Student student in updatedStudentList.Students) {
            System.Console.WriteLine($"Tên: {student.Name}, AesGcm: {student.Age}");
        }
    }
}
