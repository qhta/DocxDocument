namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of the legend on a chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xllegendposition?view=office-pia` for Office interop details.
/// </remarks>
public enum XlLegendPosition
{
  /// <summary>
  /// In the upper right-hand corner of the chart border.
  /// </summary>
  Corner = 2,
  /// <summary>
  /// Specifies the position of the legend on a chart.
  /// </summary>
  Custom = -4161,
  /// <summary>
  /// Specifies the position of the legend on a chart.
  /// </summary>
  Top = -4160,
  /// <summary>
  /// Specifies the position of the legend on a chart.
  /// </summary>
  Right = -4152,
  /// <summary>
  /// Specifies the position of the legend on a chart.
  /// </summary>
  Left = -4131,
  /// <summary>
  /// Specifies the position of the legend on a chart.
  /// </summary>
  Bottom = -4107
}
