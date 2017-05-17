namespace homework.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("AccountBook")]
    public partial class AccountBook
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "����")]
        public int Categoryyy { get; set; }
        [Required]
        [Range(0, Int32.MaxValue)]
        [Display(Name = "���B")]
        public int Amounttt { get; set; }
        [Required]        
        [Remote("Index", "Overtoday", ErrorMessage = "���~")]
        [Display(Name = "���")]
        public DateTime Dateee { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "�Ƶ�")]
        public string Remarkkk { get; set; }
    }
}
