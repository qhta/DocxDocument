namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of salutation to use for a letter.
/// </summary>
public enum WdSalutationType
{
  /// <summary>
  /// Informal salutation.
  /// </summary>
  Informal = 0,
  /// <summary>
  /// Format salutation.
  /// </summary>
  Formal = 1,
  /// <summary>
  /// Business salutation
  /// </summary>
  Business = 2,
  /// <summary>
  /// Custom salutation.
  /// </summary>
  Other = 3
}
