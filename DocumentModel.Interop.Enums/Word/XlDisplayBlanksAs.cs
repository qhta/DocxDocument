namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how blank cells are plotted on a chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xldisplayblanksas?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlDisplayBlanksAs")]
public enum DisplayBlanksAs
{
  /// <summary>
  /// Blank cells are not plotted.
  /// </summary>
  [WordInteropEnumValue("xlNotPlotted")]
  NotPlotted = 1,
  /// <summary>
  /// Blanks are plotted as zero.
  /// </summary>
  [WordInteropEnumValue("xlZero")]
  Zero = 2,
  /// <summary>
  /// Values are interpolated into the chart.
  /// </summary>
  [WordInteropEnumValue("xlInterpolated")]
  Interpolated = 3
}
