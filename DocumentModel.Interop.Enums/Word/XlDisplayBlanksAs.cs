namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how blank cells are plotted on a chart.
/// </summary>
public enum XlDisplayBlanksAs
{
  /// <summary>
  /// Blank cells are not plotted.
  /// </summary>
  NotPlotted = unchecked((int)1),
  /// <summary>
  /// Blanks are plotted as zero.
  /// </summary>
  Zero = unchecked((int)2),
  /// <summary>
  /// Values are interpolated into the chart.
  /// </summary>
  Interpolated = unchecked((int)3)
}
