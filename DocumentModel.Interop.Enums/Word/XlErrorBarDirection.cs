namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies which axis values are to receive error bars.
/// </summary>
public enum XlErrorBarDirection
{
  /// <summary>
  /// Bars run parallel to the X axis for Y-axis values.
  /// </summary>
  xlChartY = unchecked((int)1),
  /// <summary>
  /// Specifies which axis values are to receive error bars.
  /// </summary>
  xlChartX = unchecked((int)-4168)
}
