namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies where the data label is positioned.
/// </summary>
public enum XlDataLabelPosition
{
  /// <summary>
  /// Data label is positioned above the data point.
  /// </summary>
  Above = unchecked((int)0),
  /// <summary>
  /// Data label is positioned below the data point. xlLabelPositionOutsideEnd2 Data label is positioned outside the
  /// data point at the top edge. xlLabelPositionInsideEnd3 Data label is positioned inside the data point at the
  /// top edge. xlLabelPositionInsideBase4 Data label is positioned inside the data point at the bottom edge.
  /// </summary>
  Below = unchecked((int)1),
  /// <summary>
  /// Specifies where the data label is positioned.
  /// </summary>
  OutsideEnd = unchecked((int)2),
  /// <summary>
  /// Specifies where the data label is positioned.
  /// </summary>
  InsideEnd = unchecked((int)3),
  /// <summary>
  /// Specifies where the data label is positioned.
  /// </summary>
  InsideBase = unchecked((int)4),
  /// <summary>
  /// 1st_Word12 sets the position of the data label.
  /// </summary>
  BestFit = unchecked((int)5),
  /// <summary>
  /// Data labels are in multiple positions.
  /// </summary>
  Mixed = unchecked((int)6),
  /// <summary>
  /// Data label is in a custom position.
  /// </summary>
  Custom = unchecked((int)7),
  /// <summary>
  /// Specifies where the data label is positioned.
  /// </summary>
  Right = unchecked((int)-4152),
  /// <summary>
  /// Specifies where the data label is positioned.
  /// </summary>
  Left = unchecked((int)-4131),
  /// <summary>
  /// Specifies where the data label is positioned.
  /// </summary>
  Center = unchecked((int)-4108)
}
