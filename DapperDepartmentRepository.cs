using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace test_dapper
{
    public class DapperDepartmentRepository : IDapperDepartmentRepository
    {
        private readonly IDbConnection _conn;
        public DapperDepartmentRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Department> GetDepartments()
        {
            return _conn.Query<Department>("SELECT * FROM Departments");
        }
    }
}
