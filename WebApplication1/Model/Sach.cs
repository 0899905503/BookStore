using System;
using System.Collections.Generic;

namespace WebApplication1.Model
{
    public partial class Sach
    {
        public int Id { get; set; }
        public string Ten { get; set; } = null!;
        public string? Hinhanh { get; set; }
        public string? Mota { get; set; }
        public int? Daban { get; set; }
        public int? Maloaisach { get; set; }
    }
}
