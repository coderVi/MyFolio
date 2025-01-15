using System.ComponentModel.DataAnnotations;

namespace Folio.Models{
    public class AdminModel{
        [Key]
        public int AdminID { get; set; }
        public string Kadi { get; set; }
        public string Sifre{ get; set; }
    }
}