namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the axis type.
/// </summary>
public enum XlAxisType
{
  /// <summary>
  /// Axis displays categories.
  /// </summary>
  xlCategory = unchecked((int)1),
  /// <summary>
  /// Axis displays values.
  /// </summary>
  xlValue = unchecked((int)2),
  /// <summary>
  /// Axis displays data series.
  /// </summary>
  xlSeriesAxis = unchecked((int)3)
}
