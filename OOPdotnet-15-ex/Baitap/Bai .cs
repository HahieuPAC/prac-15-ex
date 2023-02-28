namespace BaiTap1
{
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

            Console.WriteLine(danhSachCanBo.Count);
        }

    }
}
