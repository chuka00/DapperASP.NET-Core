using Dapper;
using DapperASP.NET_Core.Context;
using DapperASP.NET_Core.Contracts;
using DapperASP.NET_Core.Entities;

namespace DapperASP.NET_Core.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DapperContext _context;
        public CompanyRepository(DapperContext context) => _context = context;

        public async Task<IEnumerable<Company>> GetCompanies()
        {
            var query = "SELECT * FROM Companies";
            using(var connection = _context.CreateConnection())
            {
                var companies = await connection.QueryAsync<Company>(query);
                return companies.ToList();
            }
        }
    }
}
