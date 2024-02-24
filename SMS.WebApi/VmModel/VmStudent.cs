using AutoMapper;
using SMS.WebApi.Models;

namespace SMS.WebApi.VmModel;
[AutoMap(typeof(Student),ReverseMap =true)]
public class VmStudent
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Image { get; set; }
}
