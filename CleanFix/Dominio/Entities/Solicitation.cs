using Domain.Common.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Solicitation : IEntity
{
    public int Id { get; set; } // Identificador �nico de la solicitud
    public string? Description { get; set; } // Descripci�n de la solicitud
    public DateTime Date { get; set; } // Fecha de la solicitud
    public string Address { get; set; } // Direcci�n donde se solicita el servicio
    public double MaintenanceCost { get; set; } // Costo de mantenimiento asociado a la solicitud
    public int IssueTypeId { get; set; }
    public int ApartmentAmount { get; set; }
    public IssueType IssueType { get; set; } // Id del tipo de incidencia asociada a la solicitud
    public int RequestId { get; set; } // C�digo del request de speculab
    [Timestamp]
    public byte[] RowVersion { get; set; } // Propiedad para controlar la concurrencia
}
