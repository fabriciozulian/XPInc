using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace XPInc.Models
{
    public class Venda
    {
        public int Id { get; set; } 

        [JsonProperty("nome_Produto")]
        public string Produto { get; set; }
        public decimal Preco { get; set; }  
        public DateTime DataVenda { get; set; }
    }
}