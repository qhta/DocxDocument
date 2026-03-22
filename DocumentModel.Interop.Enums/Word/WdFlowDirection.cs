namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the direction in which text flows from one text column to the next.
/// </summary>
public enum WdFlowDirection
{
  /// <summary>
  /// Text in columns flows from left to right.
  /// </summary>
  wdFlowLtr = unchecked((int)0),
  /// <summary>
  /// Text in columns flows from right to left.
  /// </summary>
  wdFlowRtl = unchecked((int)1)
}
