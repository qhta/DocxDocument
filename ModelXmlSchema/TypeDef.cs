using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ModelXmlSchema;
[Index(nameof(Name), nameof(NamespaceId), IsUnique = true)]
[Index(nameof(Name),IsUnique = false)]
[Index(nameof(NamespaceId), IsUnique = false)]
public abstract class TypeDef
{
  /// <summary>
  /// Unique identifier for the type definition.
  /// </summary>
  [Key]
  public int Id { get; set; }

  /// <summary>
  /// RefName of this type definition.
  /// </summary>
  [MaxLength(255)]
  [Required]
  public required string Name { get; set; }

  /// <summary>
  /// Unique identifier of the namespace where the type is defined.
  /// </summary>
  public int NamespaceId { get; set; }

  /// <summary>
  /// Indicates if the type is a simple type or a complex type.
  /// </summary>
  [Column(TypeName = "bit")] 
  public bool IsComplex { get; set; }

  /// <summary>
  /// Identifier of the base type.
  /// </summary>
  public int? BaseTypeId { get; set; }

  /// <summary>
  /// Navigation property for the namespace where this type is defined.
  /// </summary>
  [Required]
  public Namespace Namespace { get; set; } = null!;

  /// <summary>
  /// Navigation property for the base type.
  /// </summary>
  public TypeDef? BaseType { get; set; }

  /// <summary>
  /// Full name of the type containing the namespace prefix and the name.
  /// </summary>
  [NotMapped]
  public string FullName => Namespace.Prefix + ":" + Name;

  /// <summary>
  /// Returns the full name of the type.
  /// </summary>
  /// <param name="ns">Namespace that contains this type directly.</param>
  /// <param name="name">Name of the type</param>
  /// <returns></returns>
  public static string GetFullName(Namespace ns, string name)
  {
    return ns.Prefix + ":" + name;
  }
}
