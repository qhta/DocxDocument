namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the horizontal or vertical position of a point on a pie chart, in points, from the top or left edge
/// of the object to the top or left edge of the chart area.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlpieslicelocation?view=office-pia` for Office interop details.
/// </remarks>
public enum PieSliceLocation
{
  /// <summary>
  /// The horizontal coordinate (x).
  /// </summary>
  HorizontalCoordinate = 1,
  /// <summary>
  /// The vertical coordinate (y).
  /// </summary>
  VerticalCoordinate = 2
}
