namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single cascading style sheet attached to a web document.
/// </summary>
public partial interface StyleSheet : InteropObject
{
  /// <summary>
  /// The full name.
  /// </summary>
  public string FullName { get; }

  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// The path.
  /// </summary>
  public string Path { get; }

  /// <summary>
  /// The type.
  /// </summary>
  public WdStyleSheetLinkType Type { get; set; }

  /// <summary>
  /// The title.
  /// </summary>
  public string Title { get; set; }
}
