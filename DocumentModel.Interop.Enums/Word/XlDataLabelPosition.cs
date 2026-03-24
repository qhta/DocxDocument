namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies where the data label is positioned.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xldatalabelposition?view=office-pia` for Office interop details.
/// </remarks>
public enum XlDataLabelPosition
{
  /// <summary>
  /// Data label is positioned above the data point.
  /// </summary>
  Above = 0,
  /// <summary>
  /// Data label is positioned below the data point.
  /// </summary>
  Below = 1,
  /// <summary>
  /// Data label is positioned outside the data point at the top edge.
  /// </summary>
  OutsideEnd = 2,
  /// <summary>
  /// Data label is positioned inside the data point at the top edge.
  /// </summary>
  InsideEnd = 3,
  /// <summary>
  /// Data label is positioned inside the data point at the bottom edge.
  /// </summary>
  InsideBase = 4,
  /// <summary>
  /// 1st_Word12 sets the position of the data label.
  /// </summary>
  BestFit = 5,
  /// <summary>
  /// Data labels are in multiple positions.
  /// </summary>
  Mixed = 6,
  /// <summary>
  /// Data label is in a custom position.
  /// </summary>
  Custom = 7,
  /// <summary>
  /// Data label is positioned to the right of the data point.
  /// </summary>
  Right = -4152,
  /// <summary>
  /// Data label is positioned to the left of the data point.
  /// </summary>
  Left = -4131,
  /// <summary>
  /// Data label is centered on the data point or is inside a bar or pie chart.
  /// </summary>
  Center = -4108
}
