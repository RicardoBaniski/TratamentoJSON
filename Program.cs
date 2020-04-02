using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Script.Serialization;
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
                if (item.Categoria.Contains("CASA"))
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

                // UNIDADE FEDERATIVA
                item.Uf = item.Uf.ToUpper();

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
                Console.WriteLine(item.Elevador);
            }
            Console.ReadKey();

            string path = @"C:\TEMP\JsonTratado.json";
            XmlSerializer xmlSerializer = new XmlSerializer(imoveis.GetType());
            xmlSerializer.Serialize(Console.Out, imoveis);

            File.WriteAllText(path, JsonConvert.SerializeObject(imoveis));
        }
    }
}
