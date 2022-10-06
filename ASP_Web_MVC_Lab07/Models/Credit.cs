using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcCreditApp1.Models
{
    public class Credit
    {
        // ID кредита
        public virtual int CreditId { get; set; }

        [DisplayName("Название")]
        [Required]
        public virtual string Head { get; set; }
        
        [DisplayName("Период, на который выдается кредит")]
        [Required]
        public virtual int Period { get; set; }
        
        [DisplayName("Максимальная сумма кредита")]
        [Required]
        public virtual int Sum { get; set; }
        
        [DisplayName("Процентная ставка")]
        [Required]
        public virtual int Procent { get; set; }

    }
}