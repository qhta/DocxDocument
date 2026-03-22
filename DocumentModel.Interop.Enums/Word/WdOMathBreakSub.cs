namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Office Word handles a subtraction operator that falls before a line break.
/// </summary>
public enum WdOMathBreakSub
{
  /// <summary>
  /// Specifies how Microsoft Office Word handles a subtraction operator that falls before a line break.
  /// </summary>
  wdOMathBreakSubMinusMinus = unchecked((int)0),
  /// <summary>
  /// Specifies how Microsoft Office Word handles a subtraction operator that falls before a line break.
  /// </summary>
  wdOMathBreakSubPlusMinus = unchecked((int)1),
  /// <summary>
  /// Specifies how Microsoft Office Word handles a subtraction operator that falls before a line break.
  /// </summary>
  wdOMathBreakSubMinusPlus = unchecked((int)2)
}
