
int chon;
int chon_2;
List<CanBo> danhSachBai1= new List<CanBo>();

do
{
    Console.WriteLine("----MENU BAI TAP----");
    Console.WriteLine("Hay lua chon bai tap");
    Console.WriteLine("1. Bai 1");
    chon_2 = int.Parse(Console.ReadLine());

    switch (chon_2)
    {
        case 1:
            do
            {
                Console.WriteLine("Chon phan loai can bo muon nhap");
                Console.WriteLine("1. Cong nhan");
                Console.WriteLine("2. Ky su");
                Console.WriteLine("3. Nhan vien");
                Console.WriteLine("4. In danh sach CB");
                chon = int.Parse(Console.ReadLine());

                QLCB qlcb = new QLCB();
                switch (chon)
                {
                    case 1:
                        qlcb.NhapCongNhan();
                        break;

                    case 2:
                        qlcb.NhapKySu();
                        break;

                    case 3:
                        qlcb.NhapNhanVien();
                        break;

                    case 4:
                        qlcb.InDanhSach();
                        break;

                    default:
                        Console.WriteLine("Hay nhap lai yeu cau");
                        break;
                }
            }
            while (chon >= 1 && chon <= 4);
            break;
    }    
}
while (chon_2 >= 1 && chon_2 <= 1);

class CanBo
{
    public string HoTen { get; set; }
    public int Tuoi { get; set; }
    public string GioiTinh { get; set; }
    public string DiaChi { get; set; }
}

class CongNhan : CanBo
{
    public int Bac { get; set; }

}

class KySu : CanBo
{
    public string NganhDaoTao { get; set; }

}

class NhanVien : CanBo
{
    public string CongViec { get; set; }
}
class QLCB
{
    List<CanBo> danhSachCanBo = new List<CanBo>();
    public void NhapCongNhan()
    {
        Console.Write("Nhap ten can bo:");
        string hoTenCanBo = Console.ReadLine();
        Console.WriteLine("Ten can bo la: " + hoTenCanBo);
        Console.Write("Nhap bac cua can bo:");
        string bacCanBo = Console.ReadLine();
        Console.WriteLine("Bac can bo la: " + bacCanBo);
        Console.Write("Nhap tuoi can bo:");
        string tuoiCanBo = Console.ReadLine();
        Console.WriteLine("Tuoi can bo la: " + tuoiCanBo);
        Console.Write("Nhap gioi tinh can bo:");
        string gioiTinhCanBo = Console.ReadLine();
        Console.WriteLine("Gioi tinh can bo la: " + gioiTinhCanBo);
        Console.Write("Nhap dia chi can bo:");
        string diaChiCanBo = Console.ReadLine();
        Console.WriteLine("dia chi can bo la: " + diaChiCanBo);

        CongNhan congNhan = new CongNhan();
        congNhan.HoTen = hoTenCanBo;
        congNhan.Bac = int.Parse(bacCanBo);
        congNhan.Tuoi = int.Parse(tuoiCanBo);
        congNhan.GioiTinh = gioiTinhCanBo;
        congNhan.DiaChi = diaChiCanBo;

        danhSachCanBo.Add(congNhan);
    }
    public void NhapKySu()
    {
        Console.Write("Nhap ten can bo:");
        string hoTenCanBo = Console.ReadLine();
        Console.Write("Nhap nganh dao tao cua can bo:");
        string nganhDaoTaoCanBo = Console.ReadLine();
        Console.Write("Nhap tuoi can bo:");
        string tuoiCanBo = Console.ReadLine();

        Console.Write("Nhap gioi tinh can bo:");
        string gioiTinhCanBo = Console.ReadLine();
        Console.Write("Nhap dia chi can bo:");
        string diaChiCanBo = Console.ReadLine();

        KySu kySu = new KySu();
        kySu.HoTen = hoTenCanBo;
        kySu.NganhDaoTao = nganhDaoTaoCanBo;
        kySu.Tuoi = int.Parse(tuoiCanBo);
        kySu.GioiTinh = gioiTinhCanBo;
        kySu.DiaChi = diaChiCanBo;

        danhSachCanBo.Add(kySu);
    }
    public void NhapNhanVien()
    {
        Console.Write("Nhap ten can bo:");
        string hoTenCanBo = Console.ReadLine();
        Console.Write("Nhap cong viec cua can bo:");
        string congViecCanBo = Console.ReadLine();
        Console.Write("Nhap tuoi can bo:");
        string tuoiCanBo = Console.ReadLine();
        Console.Write("Nhap gioi tinh can bo:");
        string gioiTinhCanBo = Console.ReadLine();
        Console.Write("Nhap dia chi can bo:");
        string diaChiCanBo = Console.ReadLine();


        NhanVien nhanVien = new NhanVien();
        nhanVien.HoTen = hoTenCanBo;
        nhanVien.CongViec = congViecCanBo;
        nhanVien.Tuoi = int.Parse(tuoiCanBo);
        nhanVien.GioiTinh = gioiTinhCanBo;
        nhanVien.DiaChi = diaChiCanBo;

        danhSachCanBo.Add(nhanVien);
    }
    public void InDanhSach()
    {
        Console.WriteLine("Danh sach can bo:");
        foreach (var canBo in danhSachCanBo)
        {
            Console.WriteLine(canBo.HoTen);
        }
    }

}

