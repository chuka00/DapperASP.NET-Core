using DapperASP.NET_Core.Entities;

namespace DapperASP.NET_Core.Contracts
{
    public interface ICompanyRepository
    {
        public Task<IEnumerable<Company>> GetCompanies();
    }
}
