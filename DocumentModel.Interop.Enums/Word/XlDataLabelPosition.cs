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
  /// Data label is positioned below the data point. xlLabelPositionOutsideEnd2 Data label is positioned outside the
  /// data point at the top edge. xlLabelPositionInsideEnd3 Data label is positioned inside the data point at the
  /// top edge. xlLabelPositionInsideBase4 Data label is positioned inside the data point at the bottom edge.
  /// </summary>
  Below = 1,
  /// <summary>
  /// Specifies where the data label is positioned.
  /// </summary>
  OutsideEnd = 2,
  /// <summary>
  /// Specifies where the data label is positioned.
  /// </summary>
  InsideEnd = 3,
  /// <summary>
  /// Specifies where the data label is positioned.
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
  /// Specifies where the data label is positioned.
  /// </summary>
  Right = -4152,
  /// <summary>
  /// Specifies where the data label is positioned.
  /// </summary>
  Left = -4131,
  /// <summary>
  /// Specifies where the data label is positioned.
  /// </summary>
  Center = -4108
}
