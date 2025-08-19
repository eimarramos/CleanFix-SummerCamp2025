using Domain.Common.Interfaces;

namespace Domain.Entities;

public class Solicitation : IEntity
{
    public int Id { get; set; } // Identificador �nico de la solicitud
    public string? Description { get; set; } // Descripci�n de la solicitud
    public DateTime Date { get; set; } // Fecha de la solicitud
    public string Address { get; set; } // Direcci�n donde se solicita el servicio
    public string? Status { get; set; } // Estado de la solicitud (e.g., pendiente, en proceso, completada)
    public double MaintenanceCost { get; set; } // Costo de mantenimiento asociado a la solicitud
    public IssueType Type { get; set; } // Tipo de incidencia asociada a la solicitud
}
