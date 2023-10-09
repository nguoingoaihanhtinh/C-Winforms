using System;


int thang; int nam;
Console.WriteLine("Nhap vao thang, nam: ");
thang = Convert.ToInt32(Console.ReadLine());
nam = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("So ngay = " + DateTime.DaysInMonth(nam, thang));
