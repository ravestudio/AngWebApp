using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngWebApp.Controllers
{
    public class PostsController : ApiController
    {
        private IList<Models.Post> postlist = new List<Models.Post>();

        public PostsController()
        {
            postlist.Add(new Models.Post()
            {
                id = 1,
                title = "Simple title1",
                content = "Sample content...",
                permalink = "simple-title1",
                author = "Sandeep",
                datePublished = DateTime.Parse("2012.04.04", System.Globalization.CultureInfo.InvariantCulture)
            });

            postlist.Add(new Models.Post()
            {
                id = 2,
                title = "Simple title2",
                content = "Sample content...",
                permalink = "simple-title2",
                author = "Sandeep",
                datePublished = DateTime.Parse("2014.10.25", System.Globalization.CultureInfo.InvariantCulture)
            });
            postlist.Add(new Models.Post()
            {
                id = 3,
                title = "Simple title3",
                content = "Sample content...",
                permalink = "simple-title3",
                author = "Sandeep",
                datePublished = DateTime.Parse("2009.09.04", System.Globalization.CultureInfo.InvariantCulture)
            });
        }

        // GET: api/Posts
        public IEnumerable<Models.Post> Get()
        {
            return postlist.ToList();
        }

        // GET: api/Posts/5
        public Models.Post Get(int id)
        {
            return postlist.Single(p => p.id == id);
        }

        // POST: api/Posts
        public void Post([FromBody]Models.Post value)
        {
            this.postlist.Add(value);
        }

        // PUT: api/Posts/5
        public void Put(int id, [FromBody]Models.Post value)
        {
        }

        // DELETE: api/Posts/5
        public void Delete(int id)
        {
        }
    }
}
