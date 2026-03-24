namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the preferred unit of measure to use when measuring the width of an item.
/// </summary>
public enum WdPreferredWidthType
{
  /// <summary>
  /// Specifies the preferred unit of measure to use when measuring the width of an item.
  /// </summary>
  Auto = 1,
  /// <summary>
  /// Measure the current item width using a specified percentage.
  /// </summary>
  Percent = 2,
  /// <summary>
  /// Measure the current item width using a specified number of points.
  /// </summary>
  Points = 3
}
