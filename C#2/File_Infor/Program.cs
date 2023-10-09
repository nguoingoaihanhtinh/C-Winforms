using System;
using System.IO;
class Test
{
    public static void Main()
    {
        string path = Path.GetTempFileName();
        FileInfo fil = new FileInfo(path);
        using (StreamWriter sw = fil.CreateText())
        {
            sw.WriteLine("Hello");
            sw.WriteLine("And");
            sw.WriteLine("Welcome");
        }
        using (StreamReader sr = fil.OpenText())
        {
            string s = " ";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
        try
        {
            string path2 = Path.GetTempFileName();
            FileInfo fi2 = new FileInfo(path2);
            //Ensure that the target does not exist.
            fi2.Delete();
            //Copy the file.
            fil.CopyTo(path2);
            Console.WriteLine("{0} was copied to {1}.", path,
            path2);
            //Delete the newly created file.
            fi2.Delete();
            Console.WriteLine("{0} was successfully deleted.",
            path2);
        }


        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}",
            e.ToString());
        }
    }
}