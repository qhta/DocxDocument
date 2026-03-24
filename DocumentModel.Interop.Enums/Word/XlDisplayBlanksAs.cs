namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how blank cells are plotted on a chart.
/// </summary>
public enum XlDisplayBlanksAs
{
  /// <summary>
  /// Blank cells are not plotted.
  /// </summary>
  NotPlotted = 1,
  /// <summary>
  /// Blanks are plotted as zero.
  /// </summary>
  Zero = 2,
  /// <summary>
  /// Values are interpolated into the chart.
  /// </summary>
  Interpolated = 3
}
