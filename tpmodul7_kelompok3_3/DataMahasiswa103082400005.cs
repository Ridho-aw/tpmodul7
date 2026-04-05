using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace tpmodul7_kelompok3_3
{
    public class Mahasiswa
    {
        public class DetailNama
        {
            [JsonPropertyName("namaDepan")]
            public string NamaDepan { get; set; }
            [JsonPropertyName("namaBelakang")]
            public string NamaBelakang { get; set; }
        }

        [JsonPropertyName("nama")]
        public DetailNama Nama { get; set; }

        [JsonPropertyName("nim")]
        public string Nim { get; set; }

        [JsonPropertyName("fakultas")]
        public string Fakultas { get; set; }


    }


    internal class DataMahasiswa103082400005
    {
        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("../../../tp7_1_103082400005.json");

            try
            {
                //var options = new JsonSerializerOptions
                //{
                //    IncludeFields = true,
                //};

                Mahasiswa mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

                Console.WriteLine($"Nama: {mahasiswa.Nama.NamaDepan} {mahasiswa.Nama.NamaBelakang} " +
                    $"dengan nim {mahasiswa.Nim} " +
                    $"dari fakultas {mahasiswa.Fakultas}");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Gagal memproses JSON: " + ex.Message);
            }
                


        }

    }
}
