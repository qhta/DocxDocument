namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how blank cells are plotted on a chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xldisplayblanksas?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlDisplayBlanksAs))]
public enum DisplayBlanksAs
{
  /// <summary>
  /// Blank cells are not plotted.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlDisplayBlanksAs.xlNotPlotted))]
  NotPlotted = 1,
  /// <summary>
  /// Blanks are plotted as zero.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlDisplayBlanksAs.xlZero))]
  Zero = 2,
  /// <summary>
  /// Values are interpolated into the chart.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlDisplayBlanksAs.xlInterpolated))]
  Interpolated = 3
}
