namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format of horizontal text set within vertical text.
/// </summary>
public enum WdHorizontalInVerticalType
{
  /// <summary>
  /// No formatting is applied to the horizontal text. wdHorizontalInVerticalFitInLine1 The horizontal text is sized
  /// to fit in the line of vertical text. wdHorizontalInVerticalResizeLine2 The line of vertical text is sized to
  /// accommodate the horizontal text.
  /// </summary>
  None = unchecked((int)0),
  /// <summary>
  /// Specifies the format of horizontal text set within vertical text.
  /// </summary>
  FitInLine = unchecked((int)1),
  /// <summary>
  /// Specifies the format of horizontal text set within vertical text.
  /// </summary>
  ResizeLine = unchecked((int)2)
}
