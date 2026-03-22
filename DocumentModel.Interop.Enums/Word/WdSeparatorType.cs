namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of separator to place between items.
/// </summary>
public enum WdSeparatorType
{
  /// <summary>
  /// A hyphen.
  /// </summary>
  wdSeparatorHyphen = unchecked((int)0),
  /// <summary>
  /// A period.
  /// </summary>
  wdSeparatorPeriod = unchecked((int)1),
  /// <summary>
  /// A colon.
  /// </summary>
  wdSeparatorColon = unchecked((int)2),
  /// <summary>
  /// An emphasized dash.
  /// </summary>
  wdSeparatorEmDash = unchecked((int)3),
  /// <summary>
  /// A standard dash.
  /// </summary>
  wdSeparatorEnDash = unchecked((int)4)
}
