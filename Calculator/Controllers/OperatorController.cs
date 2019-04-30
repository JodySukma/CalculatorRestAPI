using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperatorController : Controller
    {
        public double Hasil;

        [HttpGet]
        public double Pertambahan() => Hasil;

        [HttpPost("Pertambahan/{nilai_1}/{nilai_2}")]
        public double Pertambahan(int nilai_1, int nilai_2) => Hasil = nilai_1 + nilai_2;

        [HttpGet]
        public double Pengurangan() => Hasil;

        [HttpPost("Pengurangan/{nilai_1}/{nilai_2}")]
        public double Pengurangan(int nilai_1, int nilai_2) => nilai_1 - nilai_2;

        [HttpGet]
        public double Pembagian() => Hasil;

        [HttpPost("Pembagian/{nilai_1}/{nilai_2}")]
        public double Pembagian(int nilai_1, int nilai_2) => nilai_1 / nilai_2;

        [HttpGet]
        public double Perkalian() => Hasil;

        [HttpPost("Perkalian/{nilai_1}/{nilai_2}")]
        public double Perkalian(int nilai_1, int nilai_2) => nilai_1 * nilai_2;
    }
}