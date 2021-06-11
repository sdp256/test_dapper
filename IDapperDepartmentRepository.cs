using System.Collections.Generic;

namespace test_dapper
{
    public interface IDapperDepartmentRepository
    {
        public IEnumerable<Department> GetDepartments();
    }
}