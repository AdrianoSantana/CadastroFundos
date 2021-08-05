using System;

namespace CadastroFundos_api.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        
        public bool Inactivated { get; set; }
        
        public DateTime CreatedAt { get; set; }
        
        public DateTime UpdatedAt { get; set; }
        
    }
}
