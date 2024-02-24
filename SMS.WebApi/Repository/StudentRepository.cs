using AutoMapper;
using SMS.WebApi.DataBaseContext;
using SMS.WebApi.Models;
using SMS.WebApi.Service;
using SMS.WebApi.VmModel;

namespace SMS.WebApi.Repository;

public class StudentRepository : CommonService<Student, VmStudent>, IStudentRepository
{
    public StudentRepository(IMapper mapper, ApplicationDB dbcontext) : base(mapper, dbcontext)
    {
    }
}
