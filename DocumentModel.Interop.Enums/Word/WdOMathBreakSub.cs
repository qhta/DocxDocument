namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Office Word handles a subtraction operator that falls before a line break.
/// </summary>
public enum WdOMathBreakSub
{
  /// <summary>
  /// Specifies how Microsoft Office Word handles a subtraction operator that falls before a line break.
  /// </summary>
  MinusMinus = unchecked((int)0),
  /// <summary>
  /// Specifies how Microsoft Office Word handles a subtraction operator that falls before a line break.
  /// </summary>
  PlusMinus = unchecked((int)1),
  /// <summary>
  /// Specifies how Microsoft Office Word handles a subtraction operator that falls before a line break.
  /// </summary>
  MinusPlus = unchecked((int)2)
}
