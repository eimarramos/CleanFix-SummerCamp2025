using System.ComponentModel.DataAnnotations;
using AutoMapper;
using Domain.Entities;

namespace Application.Companies.Commands.UpdateCompany;
public class UpdateCompanyDto
{
    public int Id { get; set; }
    [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 100 caracteres.")]
    public string Name { get; set; }
    [StringLength(150, MinimumLength = 5, ErrorMessage = "La direcci�n debe tener entre 5 y 150 caracteres.")]
    public string Address { get; set; }
    [RegularExpression(@"^\d{9}$", ErrorMessage = "El n�mero debe tener 9 d�gitos.")]
    public string Number { get; set; }
    [EmailAddress(ErrorMessage = "El email no es v�lido.")]
    public string Email { get; set; }
    public IssueType Type { get; set; }
    [Range(1, 10000, ErrorMessage = "El precio debe estar entre 1 y 10000.")]
    public decimal Price { get; set; }
    [Range(1, 1000, ErrorMessage = "El tiempo de trabajo debe estar entre 1 y 1000 minutos.")]
    public int WorkTime { get; set; }
    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<UpdateCompanyDto, Company>();
        }
    }
}
