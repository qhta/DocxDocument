namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of separator to place between items.
/// </summary>
public enum WdSeparatorType
{
  /// <summary>
  /// A hyphen.
  /// </summary>
  Hyphen = unchecked((int)0),
  /// <summary>
  /// A period.
  /// </summary>
  Period = unchecked((int)1),
  /// <summary>
  /// A colon.
  /// </summary>
  Colon = unchecked((int)2),
  /// <summary>
  /// An emphasized dash.
  /// </summary>
  EmDash = unchecked((int)3),
  /// <summary>
  /// A standard dash.
  /// </summary>
  EnDash = unchecked((int)4)
}
