using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NbaPlayersManager.Models;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace NbaPlayersManager.Infrastructure
{
    public class RankingRepo : IRankingRepo
    {
        private readonly IConfiguration _configuration;
        public RankingRepo(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public Task<IEnumerable<Ranking>> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.Rankings", connection))
                {
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        { 
                            Ranking r = new Ranking();
                            r.PlayerName = reader["PlayerName"].ToString();
                        }
                    }
                }
            }
            return null;
        }
    }
}
