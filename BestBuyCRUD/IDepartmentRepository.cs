using System;
using System.Collections.Generic;

namespace BestBuyCRUD
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments();
        void CreateDepartment(string Name);
    }
}
