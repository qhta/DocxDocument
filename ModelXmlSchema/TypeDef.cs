using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ModelXmlSchema;
[Index(nameof(Name), nameof(NamespaceId), IsUnique = true)]
[Index(nameof(Name),IsUnique = false)]
[Index(nameof(NamespaceId), IsUnique = false)]
[Index(nameof(BaseNamespaceId), IsUnique = false)]
[Index(nameof(BaseTypeName), nameof(BaseNamespaceId), IsUnique=false)]
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
  public bool IsComplex { get; set; }

  /// <summary>
  /// Identifier of the namespace of the base type.
  /// </summary>
  public int? BaseNamespaceId { get; set; }

  /// <summary>
  /// RefName of the base type. It can be a simple type or a complex type.
  /// </summary>
  [MaxLength(255)]
  public string? BaseTypeName { get; set; }

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
  /// Navigation property for the namespace where the base type is defined.
  /// </summary>
  public Namespace? BaseTypeNamespace { get; set; } = null!;

  /// <summary>
  /// Navigation property for the base type.
  /// </summary>
  public TypeDef? BaseType { get; set; }
}
