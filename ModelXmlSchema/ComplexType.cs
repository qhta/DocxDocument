using System.ComponentModel.DataAnnotations;

namespace ModelXmlSchema;

/// <summary>
/// Complex type definition.
/// </summary>
public class ComplexType: TypeDef
{
  /// <summary>
  /// Content type of the complex type.
  /// </summary>
  public ContentType ContentType { get; set; }

}
