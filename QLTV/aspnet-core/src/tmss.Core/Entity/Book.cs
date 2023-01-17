using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace tmss.Entity
{
    [Table("Sach")]
    public class Sach : Entity<int>, IEntity<int>
    {
        public int MaSach { get; set; }
        public int? MaTL { get; set; }
        public string TenSach { get; set; }
        public string TenTacGia { get; set; }
        public int? SoLuong { get; set; }
        public long? Gia { get; set; }
    }
}
