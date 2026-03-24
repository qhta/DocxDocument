namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the margin where revision balloons should be displayed.
/// </summary>
public enum WdRevisionsBalloonMargin
{
  /// <summary>
  /// Left margin.
  /// </summary>
  LeftMargin = unchecked((int)0),
  /// <summary>
  /// Right margin. default.
  /// </summary>
  RightMargin = unchecked((int)1)
}
