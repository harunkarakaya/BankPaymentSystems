using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ENTITIES
{
    public class Payment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }      
        public int CreditCardNumber { get; set; }
        [StringLength(70)]
        public string Owner { get; set; }
        [StringLength(3)]
        public string CCV { get; set; }
        [StringLength(10)]
        public string CreditCardHolder { get; set; }
        public decimal Amount { get; set; }
        [StringLength(70)]
        public string BankName { get; set; }
    }
}
