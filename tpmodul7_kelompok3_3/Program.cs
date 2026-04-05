using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;


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

    public static void Main(string[] args)
    {
        ReadJSON();
    }
}