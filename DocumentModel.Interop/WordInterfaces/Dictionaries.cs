namespace DocumentModel.Interop;

/// <summary>
/// A collection of Dictionary objects that includes the active custom spelling dictionaries.
/// </summary>
public partial interface Dictionaries : InteropObject, InteropCollection<Dictionary>
{
  /// <summary>
  /// The maximum.
  /// </summary>
  public int Maximum { get; }

  /// <summary>
  /// The active custom dictionary.
  /// </summary>
  public Dictionary ActiveCustomDictionary { get; set; }
}
