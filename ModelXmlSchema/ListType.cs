using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelXmlSchema;

/// <summary>
/// Simple list type.
/// </summary>
public class ListType: SimpleType
{
  /// <summary>
  /// ListItems for the simple type.
  /// </summary>
  public virtual ICollection<ListItem> ListItems { get; set; } = null!;

  /// <summary>
  /// Dictionary of ListItems for the simple type.
  /// </summary>
  [NotMapped]
  public Dictionary<string, ListItem> ListItemsDictionary
  {
    get => _ListItemsDictionary ??= new Dictionary<string, ListItem>();
    set => _ListItemsDictionary = value;
  }
  private Dictionary<string, ListItem>? _ListItemsDictionary;
}
