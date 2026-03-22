
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies how blank
/// cells are plotted on a chart.
/// </summary>
public enum XlDisplayBlanksAs
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies how blank
  /// cells are plotted on a chart.
  /// </summary>
  xlInterpolated = 3,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies how blank
  /// cells are plotted on a chart.
  /// </summary>
  xlNotPlotted = 1,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Blanks are plotted
  /// as zero. xlInterpolated3 You should access and use this enumeration from the Excel primary interop assembly
  /// (PIA). Values are interpolated into the chart.
  /// </summary>
  xlZero = 2
}
