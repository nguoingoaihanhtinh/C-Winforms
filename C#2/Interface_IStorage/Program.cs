using System;

interface IStorable
{
    void Read();
    void Write(object obj);
    int Status
    {
        get; set;
    }
}

// tạo một lớp thực thi giao diện Istorable
public class Document : IStorable
{
    public Document(string s)
    {
        Console.WriteLine("Creating document with: {0}", s);
    }
    // thực thi phương thức Read()
    public void Read()
    {
        Console.WriteLine("Implement the Read Method for IStorable");
    }
    // thực thi phương thức Write 
    public void Write(object o)
    {
        Console.WriteLine("Impleting the Write Method for IStorable");
    }
    // thực thi thuộc tính 
    public int Status
    {
        get
        {
            return status;
        }
        set
        {
            status = value;
        }
    }
    // lưu trữ giá trị thuộc tính 
    private int status = 0;
}
public class Tester
{
    static void Main()
    {
        // truy cập phương thức trong đối tượng Document 
        Document doc = new Document("Test Document");
        doc.Status = -1;
        doc.Read();
        Console.WriteLine("Document Status: {0}", doc.Status);
        // gán cho một giao diện và sử dụng giao diện
        IStorable isDoc = (IStorable)doc;
        isDoc.Status = 0;
        isDoc.Read();
        Console.WriteLine("IStorable Status: {0}", isDoc.Status);
    }
}
