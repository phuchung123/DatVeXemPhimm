﻿namespace DatVeXemPhim.Models
{
    public class TheLoaiPhim
    {
        public int iD { get; set; }
        public string tenLoaiPhim { get; set; }

        public ICollection<Phim> Phims { get; set; }
    }
}
