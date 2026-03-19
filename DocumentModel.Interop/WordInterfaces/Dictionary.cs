namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a dictionary.
/// </summary>
public partial interface Dictionary : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// The path.
  /// </summary>
  public string Path { get; }

  /// <summary>
  /// The language id.
  /// </summary>
  public WdLanguageID LanguageID { get; set; }

  /// <summary>
  /// The read only.
  /// </summary>
  public bool ReadOnly { get; }

  /// <summary>
  /// The type.
  /// </summary>
  public WdDictionaryType Type { get; }

  /// <summary>
  /// The language specific.
  /// </summary>
  public bool LanguageSpecific { get; set; }
}
