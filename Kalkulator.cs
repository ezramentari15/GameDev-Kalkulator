Console.WriteaLine("Masukan Angka");
Console.WriteaLine("1. Penjumlahan");
Console.WriteaLine("2. Pengurangan");
Console.WriteaLine("3. Perkalian");
Console.WriteaLine("4. Pembagian");

int inputPengguna = int.Parse(Console.ReadLine());
Console.WriteaLine("Masukkan Angka Pertama");
int angka1 = int.Parse(Console.ReadLine());
Console.WriteaLine("Masukkan Angka Kedua");
int angka2 = int.Parse(Console.ReadLine());

switch (inputPengguna)
{
    case 1:
    int Penjumlahan = angka1 + angka2;
    Console.WriteaLine(Penjumlahan);
    break;

    case 2:
    int Pengurangan = angka1 - angka2;
    Console.WriteaLine(Pengurangan);
    break;

    case 3:
    int Perkalian = angka1 * angka2;
    Console.WriteaLine(Perkalian);
    break;

    case 4:
    int Pembagian = angka1 / angka2;
    Console.WriteaLine(Pembagian);
    break;
}