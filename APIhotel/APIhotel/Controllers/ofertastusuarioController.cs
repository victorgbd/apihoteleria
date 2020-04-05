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
        // GET api/values?id1=2&id2=2
        public IEnumerable<Models.Hotel.oferta_det_02> Get(string idofer,string idtipcli)
        {
            IEnumerable<Models.Hotel.oferta_det_02> rq;
            using (Models.Hotel.hoteleriaEntities db = new Models.Hotel.hoteleriaEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                rq = db.oferta_det_02.Where(s => s.id_oferta_det02 == idofer && s.id_t_cliente_det02 == idtipcli).ToList();
            }
            return rq;
        }
    }
}
