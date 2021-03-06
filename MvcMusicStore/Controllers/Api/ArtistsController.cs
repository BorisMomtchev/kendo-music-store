﻿using System.Linq;
using System.Web.Http;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers.Api
{
    public class ArtistsController : ApiController
    {
        readonly MusicStoreEntities storeDB = new MusicStoreEntities();

        // GET api/artists
        [Queryable]
        public IQueryable<Artist> Get()
        {
            storeDB.Configuration.ProxyCreationEnabled = false;
            return storeDB.Artists;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            storeDB.Dispose();
        }
    }
}
