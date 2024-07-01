using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelXmlSchema;

/// <summary>
/// Simple union type.
/// </summary>
public class UnionType: SimpleType
{
  /// <summary>
  /// UnionMembers for the simple type.
  /// </summary>
  public virtual ICollection<UnionMember> UnionMembers { get; set; } = null!;

  /// <summary>
  /// Dictionary of UnionMembers for the simple type.
  /// </summary>
  [NotMapped]
  public Dictionary<string, UnionMember> UnionMembersDictionary
  {
    get => _UnionMembersDictionary ??= new Dictionary<string, UnionMember>();
    set => _UnionMembersDictionary = value;
  }
  private Dictionary<string, UnionMember>? _UnionMembersDictionary;

}
