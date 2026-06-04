
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies how blank
/// cells are plotted on a chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xldisplayblanksas?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("XlDisplayBlanksAs")]
public enum DisplayBlanksAs
{
  /// <summary>
  /// Values are interpolated into the chart.
  /// </summary>
  [OfficeInteropEnumValue("xlInterpolated")]
  Interpolated = 3,
  /// <summary>
  /// Blank cells are not plotted.
  /// </summary>
  [OfficeInteropEnumValue("xlNotPlotted")]
  NotPlotted = 1,
  /// <summary>
  /// Blanks are plotted as zero.
  /// </summary>
  [OfficeInteropEnumValue("xlZero")]
  Zero = 2
}
