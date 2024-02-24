using SMS.WebApi.Models;
using SMS.WebApi.Service;
using SMS.WebApi.VmModel;

namespace SMS.WebApi.Repository;

public interface IStudentRepository :ICommonRepository<Student,VmStudent>
{
}
