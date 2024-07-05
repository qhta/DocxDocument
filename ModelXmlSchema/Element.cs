using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelXmlSchema;

/// <summary>
/// Represents an element in a schema.
/// </summary>
public class Element: Particle
{
  /// <summary>
  /// Identifier of the namespace that this element refers to.
  /// Applies to the element which is a reference to another element.
  /// </summary>
  public int? RefElementId { get; set; }

  /// <summary>
  /// Name of this element or the referred element.
  /// </summary>
  [MaxLength(255)]
  [Column("Name")]
  public string? Name { get; set; }

  /// <summary>
  /// Identifier of the type of the element refers to.
  /// Applies to the element which is a reference to another element.
  /// </summary>
  public int? RefTypeId { get; set; }

  /// <summary>
  /// Navigation property to the element that this element refers to.
  /// </summary>
  public Element? RefElement { get; set; }

  /// <summary>
  /// Navigation property to the type of the element refers to.
  /// </summary>
  public ComplexType? RefType { get; set; }

  /// <summary>
  /// Full name of the element containing the namespace prefix and the name.
  /// </summary>
  [NotMapped]
  public string FullName => (HostingNamespace?.Prefix ?? "") + ":" + Name;

  /// <summary>
  /// Returns the full name of the attribute.
  /// </summary>
  /// <param name="ns">Namespace that contains this attribute directly or indirectly</param>
  /// <param name="name">Name of the attribute</param>
  /// <returns></returns>
  public static string GetFullName(Namespace ns, string name)
  {
    return ns.Prefix + ":" + name;
  }
}
