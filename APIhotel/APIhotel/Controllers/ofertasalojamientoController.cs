using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIhotel.Controllers
{
    public class ofertasalojamientoController : ApiController
    {
        // GET api/ofertasalojamiento
        public IEnumerable<Models.Hotel.oferta_det_01> Get()
        {
            IEnumerable<Models.Hotel.oferta_det_01> rq;
            using (Models.Hotel.hoteleriaEntities db = new Models.Hotel.hoteleriaEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                rq = db.oferta_det_01.ToList();
            }
            return rq;
        }
        public IEnumerable<Models.Hotel.oferta_det_01> Get(string idofer, string idtipaloja)
        {
            IEnumerable<Models.Hotel.oferta_det_01> rq;
            using (Models.Hotel.hoteleriaEntities db = new Models.Hotel.hoteleriaEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                rq = db.oferta_det_01.Where(s => s.id_oferta_det01 == idofer && s.id_t_aloj_det01 == idtipaloja).ToList();
            }
            return rq;
        }
    }
}
