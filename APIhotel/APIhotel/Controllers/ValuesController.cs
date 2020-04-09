using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIhotel.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Models.Hotel.Tipo_Usuario> Get()
        {
            IEnumerable<Models.Hotel.Tipo_Usuario> rq;
            using (Models.Hotel.hotelEntities db = new Models.Hotel.hotelEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                rq = db.Tipo_Usuario.ToList();
            }
            return rq;
        }

        // GET api/values?id1=2&id2=2
        public IEnumerable<Models.Hotel.Tipo_Usuario> Get(string id1)
        {
            IEnumerable<Models.Hotel.Tipo_Usuario> rq;
            using (Models.Hotel.hotelEntities db = new Models.Hotel.hotelEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                rq = db.Tipo_Usuario.Where(s=>s.id_T_Usuario==id1).ToList();
            }
            return rq;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
