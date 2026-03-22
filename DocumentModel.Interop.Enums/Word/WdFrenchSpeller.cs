namespace DocumentModel.Interop.Word;

/// <summary>
/// Indicates which version of French to use when using the French language spelling checker dictionaries.
/// </summary>
public enum WdFrenchSpeller
{
  /// <summary>
  /// Use both Post Reform and Pre-Reform French dictionaries when checking French language spelling.
  /// </summary>
  wdFrenchBoth = unchecked((int)0),
  /// <summary>
  /// Use only the Pre-Reform French dictionary when checking French language spelling.
  /// </summary>
  wdFrenchPreReform = unchecked((int)1),
  /// <summary>
  /// Use only the Post Reform French dictionary when checking French language spelling.
  /// </summary>
  wdFrenchPostReform = unchecked((int)2)
}
