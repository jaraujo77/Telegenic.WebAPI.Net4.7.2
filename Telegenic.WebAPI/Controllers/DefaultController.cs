﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Telegenic.Repository;
using Telegenic.Repository.Interfaces;

namespace Telegenic.WebAPI.Controllers
{
    public class DefaultController : ApiController
    {
        private readonly GenreRepository _genreRepository;

        //public DefaultController() { }

        public DefaultController(IGenreRepository genreRepository)
        {
            _genreRepository = (GenreRepository)genreRepository;
        }

        //public IHttpActionResult GetSample()
        //{
        //    string[] sample = new string[] { "value1", "value2" };

        //    if (sample == null || sample.Length == 0)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(sample);
        //}

        public IHttpActionResult GetAllGenre()
        {
            var genres = _genreRepository.GetAll();

            if (!genres.Any())
            {
                return NotFound();
            }

            return Ok(genres);
        }
    }
}
