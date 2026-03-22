namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the margin where revision balloons should be displayed.
/// </summary>
public enum WdRevisionsBalloonMargin
{
  /// <summary>
  /// Left margin.
  /// </summary>
  wdLeftMargin = unchecked((int)0),
  /// <summary>
  /// Right margin. default.
  /// </summary>
  wdRightMargin = unchecked((int)1)
}
