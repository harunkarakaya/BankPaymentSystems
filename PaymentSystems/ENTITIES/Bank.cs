using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ENTITIES
{
    public class Bank
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int BinCode { get; set; }
        public int BankCode { get; set; }
        [StringLength(100)]
        public string BankName { get; set; }
        [StringLength(5)]
        public string CardType { get; set; }
        [StringLength(50)]
        public string Organization { get; set; }
        public bool IsCommercialCard { get; set; }
        public bool IsSupportInstallment { get; set; }
        public bool IsActive { get; set; }
    }
}
