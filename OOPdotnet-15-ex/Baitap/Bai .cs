namespace BaiTap1
{
    class CanBo
    {
        protected string HoTen { get; set; }
        protected int Tuoi { get; set; }
        protected string GioiTinh { get; set; }
        protected string DiaChi { get; set; }
    }

    class CongNhan : CanBo
    {
        public int Bac { get; set; }
        public CongNhan() 
        {
            HoTen = "";
            Tuoi = 0;
            GioiTinh = "";
            DiaChi = "";
            Bac = 0;
        }
    }

    class KySu : CanBo
    {
        public string NganhDaoTao { get; set; }
        public KySu()
        {
            HoTen = "";
            Tuoi = 0;
            GioiTinh = "";
            DiaChi = "";
            NganhDaoTao = "";
        }
    }

    class NhanVien : CanBo
    {
        public string CongViec { get; set; }
        public NhanVien()
        {
            HoTen = "";
            Tuoi = 0;
            GioiTinh = "";
            DiaChi = "";
            CongViec = "";
        }
    }

    class QLCB
    {
        protected List<CanBo> danhSachCanBo = new List<CanBo>();

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
            congNhan.

        }

    }
}