Console.Write("Nama pelanggan: ");
String namaPelanggan = Console.ReadLine();

Console.Write("Jumlah halaman: ");
int jumlahHalaman = int.Parse(Console.ReadLine());

Console.Write("Harga per halaman: ");
int hargaPerHalaman = int.Parse(Console.ReadLine());

int subTotal = jumlahHalaman * hargaPerHalaman;
Console.WriteLine($"Sub Total: {subTotal}");

const int biayaAdmin = 2000;
Console.WriteLine($"Biaya Administrasi: {biayaAdmin}");

int totalBayar = subTotal + biayaAdmin;
Console.WriteLine($"Total Bayar: {totalBayar}");
