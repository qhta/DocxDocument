using System.ComponentModel.DataAnnotations;

namespace ModelXmlSchema;

/// <summary>
/// Represents any particles that can appear in any order.
/// </summary>
public class Any: Particle
{
  [MaxLength(255)]
  public string? Namespace { get; set; }

  public ContentProcessing? ProcessContents { get; set; }

}
