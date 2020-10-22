using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess
{
    public interface IComputerData
    {
        Task<List<ComputerModel>> GetComputer();
        Task InsertComputer(ComputerModel computer);
        Task UpdateComputer(ComputerModel computer);
    }
}