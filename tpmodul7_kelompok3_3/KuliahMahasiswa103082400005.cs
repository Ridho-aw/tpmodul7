using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace tpmodul7_kelompok3_3
{
    internal class KuliahMahasiswa103082400005
    {
        public class MataKuliah
        {
            [JsonPropertyName("code")]
            public string Code { get; set; }
            [JsonPropertyName("name")]
            public string Name { get; set; }
        }

        public class MataKuliahMahasiswa
        {
            [JsonPropertyName("mk")]
            public List<MataKuliah> DataMk { get; set; }
        }

        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("../../../tp7_2_103082400005.json");
            try
            {
                MataKuliahMahasiswa mk = JsonSerializer.Deserialize<MataKuliahMahasiswa>(jsonString);

                int jumlahDataMk = mk.DataMk.Count;

                for (int i = 0; i < jumlahDataMk; i++)
                {
                    Console.WriteLine($"MK {i + 1} {mk.DataMk[i].Code} - {mk.DataMk[i].Name}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Gagal memproses Json: {ex.Message}");
            }

        }



    }
}
