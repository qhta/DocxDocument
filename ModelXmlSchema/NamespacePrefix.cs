using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ModelXmlSchema;

/// <summary>
/// Helper class to get the prefix of a namespace used in a file.
/// </summary>
public class NamespacePrefix
{
  /// <summary>
  /// Unique identifier of namespace.
  /// </summary>
  public int NamespaceId { get; set; }

  /// <summary>
  /// Prefix (short name) of the namespace used in the file.
  /// </summary>
  [MaxLength(10)]
  public string? Prefix { get; set; }

  /// <summary>
  /// Count of the namespace used in the files.
  /// </summary>
  public int Count { get; set; }
}
