using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace tmss.ApiDto.BookDto
{
    public class BookForViewDto : Entity<int>
    {
        public int MaSach { get; set; }
        public int? MaTL { get; set; }
        public string TenSach { get; set; }
        public string TenTacGia { get; set; }
        public int? SoLuong { get; set; }
        public long? Gia { get; set; }
    }
}
