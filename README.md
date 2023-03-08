# PBKK_TugasKalkulator_5025201229

| | |
| :--- | :---: |
| Kelas | Pemrograman Berbasis Kerangka Kerja D |
| Dosen Pengampu | Fajar Baskoro, S.Kom., M.T. |
| Nama | Surya Abdillah |
| NRP | 5025201229 |

## Deskripsi Tugas
Membuat sebuah program kalkulator sederhana dengan menggunakan Windows Form .NET. Tampilan dari program yang akan dibuat sebagai berikut:

![image](https://user-images.githubusercontent.com/97737970/223646800-5580671f-f280-4a5b-b666-e7cc689f02af.png)

## Jawaban

### 1. Membuat desain dari form yang akan dibuat

![image](https://user-images.githubusercontent.com/97737970/223647082-5545b537-399b-4796-8347-c7e2268b09b2.png)

### 2. Menuliskan kode program

> Klik dua kali pada elemen form yang akan diberi kode, akan muncul tampilan sebagai berikut

![image](https://user-images.githubusercontent.com/97737970/223647333-5181f4a4-762d-4c37-94b5-f9d20809117b.png)

> Memasukkan kode program berikut pada button operasi `+`

```
int nilai1 = int.Parse(textBox1.Text);
int nilai2 = int.Parse(textBox2.Text);
int hasil = nilai1 + nilai2;
textBox3.Text = hasil.ToString();
```

> Lakukan pada button operasi lain dengan mengganti operasi yang sesuai pada `int hasil = nilai1 + nilai2;`

| Operasi | Kode |
|:---:| :--- |
| Penjumlahan | `+` |
| Perkalian | `*` |
| Pembagian | `/` |
| Pengurangan | `-` |
| Modulo | `%` |
| Pangkat | `Math.Pow(nilai1, nilai2)` |

> Beri kode pada elemen button `C`

```
textBox1.Text = "";
textBox2.Text = "";
textBox3.Text = "";
```

### 3. Percobaan

![image](https://user-images.githubusercontent.com/97737970/223650742-d2efac71-dca3-4c16-8bd1-0c7c18f789df.png)

![image](https://user-images.githubusercontent.com/97737970/223650832-9b6c45a8-557a-4e27-bb30-c7c6d9a2fb26.png)

![image](https://user-images.githubusercontent.com/97737970/223650897-aefb1c9d-5c81-4d08-8010-c1b0eadb3a6e.png)

![image](https://user-images.githubusercontent.com/97737970/223651014-27dd4e6e-02e5-4c50-86a9-b18785561e0c.png)

![image](https://user-images.githubusercontent.com/97737970/223651072-7454c6d8-4683-499e-b892-783538e88e99.png)

![image](https://user-images.githubusercontent.com/97737970/223651145-175f932e-6bde-4f25-baed-f914adac169d.png)

## Referensi

https://youtu.be/ezkqjNuMGis
