namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the horizontal or vertical position of a point on a pie chart, in points, from the top or left edge
/// of the object to the top or left edge of the chart area.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlpieslicelocation?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlPieSliceLocation")]
public enum PieSliceLocation
{
  /// <summary>
  /// The horizontal coordinate (x).
  /// </summary>
  [InteropEnumValue("xlHorizontalCoordinate")]
  HorizontalCoordinate = 1,
  /// <summary>
  /// The vertical coordinate (y).
  /// </summary>
  [InteropEnumValue("xlVerticalCoordinate")]
  VerticalCoordinate = 2
}

