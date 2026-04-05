using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


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

    public static void Main(string[] args)
    {
        ReadJSON();
    }
}