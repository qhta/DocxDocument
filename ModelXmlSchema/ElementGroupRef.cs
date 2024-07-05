using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelXmlSchema;

/// <summary>
/// Represents a reference to a group of elements.
/// </summary>
public class ElementGroupRef: Particle
{

  /// <summary>
  /// Identifier of the referenced group.
  /// </summary>
  public int? RefGroupId { get; set; }

  [MaxLength(255)]
  [Column("Name")]
  public required string Name { get; set; }

}
