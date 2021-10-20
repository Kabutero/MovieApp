using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    class MovieTestService : IMovieService
    {
        public List<MovieCardResponseModel> GetTop30RevenueMovies()
        {
            throw new NotImplementedException();
        }
    }
}
