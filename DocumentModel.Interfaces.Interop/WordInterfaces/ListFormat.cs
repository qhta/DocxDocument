namespace DocumentModel.Interop;

/// <summary>
/// Represents the list formatting attributes that can be applied to the paragraphs in a range.
/// </summary>
public partial interface ListFormat : InteropObject
{
  /// <summary>
  /// The list level number.
  /// </summary>
  public int ListLevelNumber { get; set; }

  /// <summary>
  /// The list.
  /// </summary>
  public List List { get; }

  /// <summary>
  /// The list template.
  /// </summary>
  public ListTemplate ListTemplate { get; }

  /// <summary>
  /// The list value.
  /// </summary>
  public int ListValue { get; }

  /// <summary>
  /// The single list.
  /// </summary>
  public bool SingleList { get; }

  /// <summary>
  /// The single list template.
  /// </summary>
  public bool SingleListTemplate { get; }

  /// <summary>
  /// The list type.
  /// </summary>
  public WdListType ListType { get; }

  /// <summary>
  /// The list string.
  /// </summary>
  public string ListString { get; }

  /// <summary>
  /// The list picture bullet.
  /// </summary>
  public InlineShape ListPictureBullet { get; }
}
