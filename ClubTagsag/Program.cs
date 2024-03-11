using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net.Http;
using ClubTagsagKonzolos;
using System.Text.Json;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace ClubTagsag
{
    internal class Program
        {
            static async Task Main(string[] args)
            {
                string endpointUrl = "https://retoolapi.dev/OEDUXm/member";

                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        HttpResponseMessage response = await client.GetAsync(endpointUrl);

                        if (response.IsSuccessStatusCode)
                        {
                            string responseBody = await response.Content.ReadAsStringAsync();

                            Members[] members = JsonSerializer.Deserialize<Members[]>(responseBody);

                            int tagokSzama = members.Length;
                            Console.WriteLine($"Hány tag van: {tagokSzama}");

                            String utoljaraBelepettNev = utoljaraBelepett(members);
                            Console.WriteLine($"Ki lépett be legutoljára: {utoljaraBelepettNev}");

                            var erdeklodesiKorok = Erdeklodes(members);
                            foreach (var erdeklodesikor in erdeklodesiKorok)
                            {
                                Console.WriteLine($"Érdeklődési kör: {erdeklodesikor.Key}, Tagok száma: {erdeklodesikor.Value}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Hiba történt a végpont elérésénél: {response.StatusCode}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hiba történt: {ex.Message}");
                }

                Console.ReadLine();
            }

            static Dictionary<string, int> Erdeklodes(Members[] members)
            {
                var szamol = new Dictionary<string, int>();

                foreach (var member in members)
                {
                    if (!szamol.ContainsKey(member.Interest))
                    {
                        szamol[member.Interest] = 0;
                    }
                    szamol[member.Interest]++;
                }

                return szamol;
            }
            static string utoljaraBelepett(Members[] members)
            {
                Members utoljaraBelepett = members[0];
                foreach (var member in members)
                {

                    if (DateTime.Parse(member.Entry) > DateTime.Parse(utoljaraBelepett.Entry))
                    {
                        utoljaraBelepett = member;
                    }

                }
                return utoljaraBelepett.Fullname;
            }
        }
    }


 
