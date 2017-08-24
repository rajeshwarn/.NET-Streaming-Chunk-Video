using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VideoStreamLib;

namespace VideoStreamAPI.Controllers
{
    [RoutePrefix("api/videos")]
    public class VideosController : ApiController
    {
        [Route("play")]
        [HttpGet]
        public HttpResponseMessage Play(string f)
        {
            return new VideoStream().StreamVideo(Path.Combine(@"C:\F2F\", f), base.Request.Headers.Range,1);
        }
    }
}
