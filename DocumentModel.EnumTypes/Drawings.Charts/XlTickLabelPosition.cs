namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the position of tick-mark labels on the specified axis.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlticklabelposition?view=office-pia` for Office interop details.
/// </remarks>
public enum XlTickLabelPosition
{
  /// <summary>
  /// Next to axis (where axis is not at either side of the chart).
  /// </summary>
  NextToAxis = 4,
  /// <summary>
  /// No tick marks.
  /// </summary>
  None = -4142,
  /// <summary>
  /// Bottom or left side of the chart.
  /// </summary>
  Low = -4134,
  /// <summary>
  /// Top or right side of the chart.
  /// </summary>
  High = -4127
}

