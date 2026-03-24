namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the axis type.
/// </summary>
public enum XlAxisType
{
  /// <summary>
  /// Axis displays categories.
  /// </summary>
  Category = unchecked((int)1),
  /// <summary>
  /// Axis displays values.
  /// </summary>
  Value = unchecked((int)2),
  /// <summary>
  /// Axis displays data series.
  /// </summary>
  SeriesAxis = unchecked((int)3)
}
