namespace DocumentModel.Interop.Word;

/// <summary>
/// Indicates which version of French to use when using the French language spelling checker dictionaries.
/// </summary>
public enum WdFrenchSpeller
{
  /// <summary>
  /// Use both Post Reform and Pre-Reform French dictionaries when checking French language spelling.
  /// </summary>
  Both = unchecked((int)0),
  /// <summary>
  /// Use only the Pre-Reform French dictionary when checking French language spelling.
  /// </summary>
  PreReform = unchecked((int)1),
  /// <summary>
  /// Use only the Post Reform French dictionary when checking French language spelling.
  /// </summary>
  PostReform = unchecked((int)2)
}
