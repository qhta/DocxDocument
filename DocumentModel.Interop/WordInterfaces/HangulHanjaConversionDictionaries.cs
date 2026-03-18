namespace DocumentModel.Interop;

/// <summary>
/// A collection of Dictionary objects that includes the active custom Hangul-Hanja conversion dictionaries.
/// </summary>
public partial interface HangulHanjaConversionDictionaries : InteropObject, InteropCollection<Dictionary>
{
  /// <summary>
  /// The maximum.
  /// </summary>
  public int Maximum { get; }

  /// <summary>
  /// The active custom dictionary.
  /// </summary>
  public Dictionary ActiveCustomDictionary { get; set; }

  /// <summary>
  /// The builtin dictionary.
  /// </summary>
  public Dictionary BuiltinDictionary { get; }
}
