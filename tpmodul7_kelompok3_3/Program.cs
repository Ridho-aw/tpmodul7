using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
public class namaLengkap
{
    [JsonPropertyName("Nama Depan")]
    public string namaDepan { get; set; }

    [JsonPropertyName("Nama Belakang")]
    public string namaBelakang { get; set; }
}
public class DataMahasiswa103082400024
{
    public namaLengkap Nama { get; set; }
    public string nim { get; set; }
    public string fakultas { get; set; }

    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("tp7_1_103082400024.json");

        DataMahasiswa103082400024 data = JsonSerializer.Deserialize<DataMahasiswa103082400024>(jsonString);

        Console.WriteLine($"Nama {data.Nama.namaDepan} {data.Nama.namaBelakang} dengan nim {data.nim} dari fakultas {data.fakultas}");
    }
}
public class MataKuliah
{
    [JsonPropertyName("code")]
    public string kode { get; set; }
    [JsonPropertyName("name")]
    public string Nama { get; set; }
}
public class KuliahMahasiswa103082400024 
{
    public List<MataKuliah> mk { get; set; }
    
    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("tp7_2_103082400024.json");

        KuliahMahasiswa103082400024 data = JsonSerializer.Deserialize<KuliahMahasiswa103082400024>(jsonString);

        Console.WriteLine("Daftar mata kuliah yang diambil.");
        for (int i = 0; i < data.mk.Count; i++)
        {
            Console.WriteLine($"MK {i+1} {data.mk[i].kode} dengan nama mata kuliah {data.mk[i].Nama}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        DataMahasiswa103082400024.ReadJSON();
        KuliahMahasiswa103082400024.ReadJSON();
    }
}