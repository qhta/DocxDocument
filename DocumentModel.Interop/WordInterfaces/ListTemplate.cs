namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single list template that includes all the formatting that defines a list.
/// </summary>
public partial interface ListTemplate : InteropObject
{
  /// <summary>
  /// The outline numbered.
  /// </summary>
  public bool OutlineNumbered { get; set; }

  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// The list levels.
  /// </summary>
  public ListLevels ListLevels { get; }
}
