namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the horizontal or vertical position of a point on a pie chart, in points, from the top or left edge
/// of the object to the top or left edge of the chart area.
/// </summary>
public enum XlPieSliceLocation
{
  /// <summary>
  /// The horizontal coordinate (x).
  /// </summary>
  HorizontalCoordinate = unchecked((int)1),
  /// <summary>
  /// The vertical coordinate (y).
  /// </summary>
  VerticalCoordinate = unchecked((int)2)
}
