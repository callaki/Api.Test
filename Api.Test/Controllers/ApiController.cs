using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Test.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
       
        [HttpGet]
        public Response<List<OGRENCILER>> OgrenciListesi()
        {
            Response<List<OGRENCILER>> res = new();

            dbcontext db = new();

            var data = db.OGRENCILER.AsNoTracking().ToList();
            if (data.Any())
            {
                res.result = data;
                res.status = true;
                res.message = data.Count() + " adet sonuç bulundu.";
            }
            else
            {
                res.message = "Sonuç bulunamadı.";
            }

            return res;
        }

        [HttpPost]
        public Response<OGRENCILER> OgrenciBul(OGRENCILER req)
        {
            Response<OGRENCILER> res = new();

            dbcontext db = new();

            var data = db.OGRENCILER.FirstOrDefault(x=>x.ID==req.ID);
            if (data!=null)
            {
                res.result = data;
                res.status = true;
            }
            else
            {
                res.message = "Sonuç bulunamadı.";
            }

            return res;
        }


    }
}
