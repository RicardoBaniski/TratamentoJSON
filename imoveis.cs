using System.Collections.Generic;

namespace Imobiliaria
{
    public class Imoveis
    {
        public string Id { get; set; }
        public string Categoria { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Bairro { get; set; }
        public string Status { get; set; }
        public string Area_total { get; set; }
        public string Area_privativa { get; set; }
        public string Iptu { get; set; }
        public string Condominio { get; set; }
        public string Dependencia { get; set; }
        public string Sacada { get; set; }
        public string Portaria { get; set; }
        public string Elevador { get; set; }
        public string Churrasqueira { get; set; }
        public string Dormitorios { get; set; }
        public string Suites { get; set; }
        public string Vagas { get; set; }
        public string Banheiros { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Descricao { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Valor_venda { get; set; }
        public string Valor_aluguel { get; set; }
        public string Mostrar_mapa { get; set; }
        public string Imagem_principal { get; set; }
        public List<string> Imagens { get; set; }
    }
}
