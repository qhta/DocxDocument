namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how blank cells are plotted on a chart.
/// </summary>
public enum XlDisplayBlanksAs
{
  /// <summary>
  /// Blank cells are not plotted.
  /// </summary>
  xlNotPlotted = unchecked((int)1),
  /// <summary>
  /// Blanks are plotted as zero.
  /// </summary>
  xlZero = unchecked((int)2),
  /// <summary>
  /// Values are interpolated into the chart.
  /// </summary>
  xlInterpolated = unchecked((int)3)
}
