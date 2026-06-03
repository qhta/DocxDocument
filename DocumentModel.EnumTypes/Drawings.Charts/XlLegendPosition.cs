namespace DocumentModel.Wordprocessing;

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
  /// A custom position.
  /// </summary>
  Custom = -4161,
  /// <summary>
  /// Above the chart.
  /// </summary>
  Top = -4160,
  /// <summary>
  /// Right of the chart.
  /// </summary>
  Right = -4152,
  /// <summary>
  /// Left of the chart.
  /// </summary>
  Left = -4131,
  /// <summary>
  /// Below the chart.
  /// </summary>
  Bottom = -4107
}

