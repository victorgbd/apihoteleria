using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIhotel.Controllers
{
    public class ofertastusuarioController : ApiController
    {
        // GET api/ofertas
        public IEnumerable<Models.Hotel.oferta_det_02> Get()
        {
            IEnumerable<Models.Hotel.oferta_det_02> rq;
            using (Models.Hotel.hoteleriaEntities db = new Models.Hotel.hoteleriaEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                rq = db.oferta_det_02.ToList();
            }
            return rq;
        }
    }
}
