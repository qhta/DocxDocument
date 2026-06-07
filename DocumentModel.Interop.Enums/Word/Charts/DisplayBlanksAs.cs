namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how blank cells are plotted on a chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xldisplayblanksas?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlDisplayBlanksAs")]
public enum DisplayBlanksAs
{
  /// <summary>
  /// Blank cells are not plotted.
  /// </summary>
  [InteropEnumValue("xlNotPlotted")]
  NotPlotted = 1,
  /// <summary>
  /// Blanks are plotted as zero.
  /// </summary>
  [InteropEnumValue("xlZero")]
  Zero = 2,
  /// <summary>
  /// Values are interpolated into the chart.
  /// </summary>
  [InteropEnumValue("xlInterpolated")]
  Interpolated = 3
}

