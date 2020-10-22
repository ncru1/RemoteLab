using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess
{
    public class ComputerData : IComputerData
    {
        private readonly ISqlDataAccess _db;

        public ComputerData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ComputerModel>> GetComputer()
        {
            string sql = "SELECT * from dbo.RemoteLab";

            return _db.LoadData<ComputerModel, dynamic>(sql, new { });
        }

        public Task InsertComputer(ComputerModel computer)
        {
            string sql = @"INSERT INTO dbo.RemoteLab (FQDN, RDPStatus) VALUES (@FQDN, @RDPStatus);";

            return _db.SaveData(sql, computer);
        }

        public Task UpdateComputer(ComputerModel computer)
        {
            string sql = @"UPDATE dbo.RemoteLab SET RDPStatus = @RDPStatus WHERE FQDN = @FQDN;";

            return _db.SaveData(sql, computer);
        }


    }
}
