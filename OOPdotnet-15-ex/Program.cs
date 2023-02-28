using BaiTap1;
Console.WriteLine("Chọn phân loại cán bộ muốn nhập");
int chon = int.Parse(Console.ReadLine());
switch (chon)
{
    case 1: 
        QLCB qlcb = new QLCB();
        qlcb.NhapCongNhan();
        break;
}    
