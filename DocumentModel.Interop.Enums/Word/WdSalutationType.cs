namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of salutation to use for a letter.
/// </summary>
public enum WdSalutationType
{
  /// <summary>
  /// Informal salutation.
  /// </summary>
  Informal = unchecked((int)0),
  /// <summary>
  /// Format salutation.
  /// </summary>
  Formal = unchecked((int)1),
  /// <summary>
  /// Business salutation
  /// </summary>
  Business = unchecked((int)2),
  /// <summary>
  /// Custom salutation.
  /// </summary>
  Other = unchecked((int)3)
}
