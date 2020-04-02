using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Imobiliaria
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\imoveis.json");
            List<Imoveis> imoveis = JsonConvert.DeserializeObject<List<Imoveis>>(json);

            foreach (var item in imoveis)
            {
                // CATEGORIA
                item.Categoria = item.Categoria.ToUpper();
                if (item.Categoria.Contains("AP"))
                {
                    item.Categoria = "APARTAMENTO";
                }
                if (item.Categoria.Contains("CAS"))
                {
                    item.Categoria = "CASA";
                }

                // CIDADE
                item.Cidade = item.Cidade.ToUpper();
                if (item.Cidade.Contains("ST"))
                {
                    item.Cidade = item.Cidade.Replace("ST.", "SANTA");
                }
                if (item.Cidade.Contains("TIBA"))
                {
                    item.Cidade = "CURITIBA";
                }

                // BAIRRO
                item.Bairro = item.Bairro.ToUpper();

                // STATUS
                item.Status = item.Status.ToUpper();
                item.Status = item.Status.Replace(" E ", ",");

                // AREA TOTAL
                item.Area_total = item.Area_total.Replace(".", ",");
                if (!item.Area_total.Contains(","))
                {
                    item.Area_total = item.Area_total + ",00";
                }

                // AREA PRIVATIVA
                item.Area_privativa = item.Area_privativa.Replace(".", ",");
                if (!item.Area_privativa.Contains(","))
                {
                    item.Area_privativa = item.Area_privativa + ",00";
                }

                // CONDOMINIO
                item.Condominio = item.Condominio.Replace(".", ",");
                if (item.Condominio == null || item.Condominio == "0")
                {
                    item.Condominio = "0,00";
                }
                if (!item.Condominio.Contains(","))
                {
                    item.Condominio = item.Condominio + ",00";
                }
                else
                {
                    item.Condominio = item.Condominio.ToString().Replace("R$", "");
                }

                // DEPENDENCIA
                if (item.Dependencia == "NÃO")
                {
                    item.Dependencia = "NAO";
                }
                if (item.Dependencia == null)
                {
                    item.Dependencia = "NAO INFORMADO";
                }

                // SACADA
                if (item.Sacada == "NÃO" || item.Sacada == "N")
                {
                    item.Sacada = "NAO";
                }
                if (item.Sacada == null)
                {
                    item.Sacada = "NAO INFORMADO";
                }

                // PORTARIA
                item.Portaria = item.Portaria.ToUpper();
                if (item.Portaria == "NÃO" || item.Portaria == "N")
                {
                    item.Portaria = "NAO";
                }
                if (item.Portaria == null)
                {
                    item.Portaria = "NAO INFORMADO";
                }

                // ELEVADOR
                item.Elevador = item.Elevador.ToUpper();
                if (item.Elevador == "NÃO" || item.Elevador == "N")
                {
                    item.Elevador = "NAO";
                }
                if (item.Elevador == null)
                {
                    item.Elevador = "NAO INFORMADO";
                }

                // CHURRASQUEIRA
                item.Churrasqueira = item.Churrasqueira.ToUpper();
                if (item.Churrasqueira.Contains("SIM"))
                {
                    item.Churrasqueira = "PRIVATIVA";
                }
                if (item.Churrasqueira.Contains("NÃO"))
                {
                    item.Churrasqueira = "NAO";
                }

                // DORMITORIOS
                item.Dormitorios = item.Dormitorios.ToUpper();
                if (item.Dormitorios == "TRÊS")
                {
                    item.Dormitorios = "3";
                }
                switch (item.Dormitorios)
                {
                    case null:
                        item.Dormitorios = "0";
                        break;
                    case "UM":
                        item.Dormitorios = "1";
                        break;
                    case "DOIS":
                        item.Dormitorios = "2";
                        break;
                    case "TRES":
                        item.Dormitorios = "3";
                        break;
                    case "QUATRO":
                        item.Dormitorios = "4";
                        break;
                    case "CINCO":
                        item.Dormitorios = "5";
                        break;
                    case "SEIS":
                        item.Dormitorios = "6";
                        break;
                    case "SETE":
                        item.Dormitorios = "7";
                        break;
                    case "OITO":
                        item.Dormitorios = "8";
                        break;
                    case "NOVE":
                        item.Dormitorios = "9";
                        break;
                }

                // SUITES
                item.Suites = item.Suites.ToUpper();
                if (item.Suites == "TRÊS")
                {
                    item.Suites = "3";
                }
                switch (item.Suites)
                {
                    case null:
                        item.Suites = "0";
                        break;
                    case "UM":
                        item.Suites = "1";
                        break;
                    case "DOIS":
                        item.Suites = "2";
                        break;
                    case "TRES":
                        item.Suites = "3";
                        break;
                    case "QUATRO":
                        item.Suites = "4";
                        break;
                    case "CINCO":
                        item.Suites = "5";
                        break;
                    case "SEIS":
                        item.Suites = "6";
                        break;
                    case "SETE":
                        item.Suites = "7";
                        break;
                    case "OITO":
                        item.Suites = "8";
                        break;
                    case "NOVE":
                        item.Suites = "9";
                        break;
                }

                // VAGAS
                item.Vagas = item.Vagas.ToUpper();
                if (item.Vagas == "TRÊS")
                {
                    item.Vagas = "3";
                }
                switch (item.Vagas)
                {
                    case null:
                        item.Vagas = "0";
                        break;
                    case "UM":
                        item.Vagas = "1";
                        break;
                    case "DOIS":
                        item.Vagas = "2";
                        break;
                    case "TRES":
                        item.Vagas = "3";
                        break;
                    case "QUATRO":
                        item.Vagas = "4";
                        break;
                    case "CINCO":
                        item.Vagas = "5";
                        break;
                    case "SEIS":
                        item.Vagas = "6";
                        break;
                    case "SETE":
                        item.Vagas = "7";
                        break;
                    case "OITO":
                        item.Vagas = "8";
                        break;
                    case "NOVE":
                        item.Vagas = "9";
                        break;
                }

                // BANHEIROS
                item.Banheiros = item.Banheiros.ToUpper();
                if (item.Banheiros == "TRÊS")
                {
                    item.Banheiros = "3";
                }
                switch (item.Banheiros)
                {
                    case null:
                        item.Banheiros = "0";
                        break;
                    case "UM":
                        item.Banheiros = "1";
                        break;
                    case "DOIS":
                        item.Banheiros = "2";
                        break;
                    case "TRES":
                        item.Banheiros = "3";
                        break;
                    case "QUATRO":
                        item.Banheiros = "4";
                        break;
                    case "CINCO":
                        item.Banheiros = "5";
                        break;
                    case "SEIS":
                        item.Banheiros = "6";
                        break;
                    case "SETE":
                        item.Banheiros = "7";
                        break;
                    case "OITO":
                        item.Banheiros = "8";
                        break;
                    case "NOVE":
                        item.Banheiros = "9";
                        break;
                }

                // UNIDADE FEDERATIVA
                item.Uf = item.Uf.ToUpper();

                // LATITUDE
                item.Latitude = item.Latitude.ToString().Replace(".", ",");

                // longitude
                item.Longitude = item.Longitude.ToString().Replace(".", ",");

                // VALOR DE VENDA
                if (item.Valor_venda == null)
                {
                    item.Valor_venda = "0,00";
                }
                else
                {
                    item.Valor_venda = item.Valor_venda.ToString().Replace("R$", "");
                }
                // VALOR ALUGUEL
                if (item.Valor_aluguel == null)
                {
                    item.Valor_aluguel = "0,00";
                }
                else
                {
                    item.Valor_aluguel = item.Valor_aluguel.ToString().Replace("R$", "");
                    item.Valor_aluguel = item.Valor_aluguel.ToString().Replace(".", ",");
                }
            }
            string path = @"C:\TEMP\JsonTratado.json";
            XmlSerializer xmlSerializer = new XmlSerializer(imoveis.GetType());
            xmlSerializer.Serialize(Console.Out, imoveis);

            File.WriteAllText(path, JsonConvert.SerializeObject(imoveis));

            Console.Clear();
            Console.WriteLine("TRATAMENTO CONCLUÍDO: " + path);
            Console.ReadKey();
        }
    }
}
