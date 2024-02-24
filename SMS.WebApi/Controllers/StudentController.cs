using Microsoft.AspNetCore.Mvc;
using SMS.WebApi.Repository;
using SMS.WebApi.VmModel;

namespace SMS.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentController(IStudentRepository studentRepository) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<VmStudent>> Getall(CancellationToken cancellationToken)
    {
        var data = await studentRepository.GetAllAsync(cancellationToken);
        return Ok(data);
    }

    [HttpPost]
    public async Task<ActionResult<VmStudent>> Create(CancellationToken cancellationToken,VmStudent student)
    {
        var data = await studentRepository.InsertAsync(student,cancellationToken);
        return Ok(data);
    }
    [HttpPut("{id:int}")]
    public async Task<ActionResult<VmStudent>> Update(int id,CancellationToken cancellationToken, VmStudent student)
    {
        var data = await studentRepository.UpDateAsync(id,student, cancellationToken);
        return Ok(data);
    }
    [HttpDelete("{id:int}")]
    public async Task<ActionResult<VmStudent>> Delete(int id, CancellationToken cancellationToken)
    {
        var data = await studentRepository.DeleteAsync(id, cancellationToken);
        return Ok(data);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<VmStudent>> GetbyId(int id, CancellationToken cancellationToken)
    {
        var data = await studentRepository.GetByIdAsync(id,  cancellationToken);
        return Ok(data);
    }
}
