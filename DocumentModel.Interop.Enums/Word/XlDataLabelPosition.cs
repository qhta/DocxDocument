namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies where the data label is positioned.
/// </summary>
public enum XlDataLabelPosition
{
  /// <summary>
  /// Data label is positioned above the data point.
  /// </summary>
  xlLabelPositionAbove = unchecked((int)0),
  /// <summary>
  /// Data label is positioned below the data point. xlLabelPositionOutsideEnd2 Data label is positioned outside the
  /// data point at the top edge. xlLabelPositionInsideEnd3 Data label is positioned inside the data point at the
  /// top edge. xlLabelPositionInsideBase4 Data label is positioned inside the data point at the bottom edge.
  /// </summary>
  xlLabelPositionBelow = unchecked((int)1),
  /// <summary>
  /// Specifies where the data label is positioned.
  /// </summary>
  xlLabelPositionOutsideEnd = unchecked((int)2),
  /// <summary>
  /// Specifies where the data label is positioned.
  /// </summary>
  xlLabelPositionInsideEnd = unchecked((int)3),
  /// <summary>
  /// Specifies where the data label is positioned.
  /// </summary>
  xlLabelPositionInsideBase = unchecked((int)4),
  /// <summary>
  /// 1st_Word12 sets the position of the data label.
  /// </summary>
  xlLabelPositionBestFit = unchecked((int)5),
  /// <summary>
  /// Data labels are in multiple positions.
  /// </summary>
  xlLabelPositionMixed = unchecked((int)6),
  /// <summary>
  /// Data label is in a custom position.
  /// </summary>
  xlLabelPositionCustom = unchecked((int)7),
  /// <summary>
  /// Specifies where the data label is positioned.
  /// </summary>
  xlLabelPositionRight = unchecked((int)-4152),
  /// <summary>
  /// Specifies where the data label is positioned.
  /// </summary>
  xlLabelPositionLeft = unchecked((int)-4131),
  /// <summary>
  /// Specifies where the data label is positioned.
  /// </summary>
  xlLabelPositionCenter = unchecked((int)-4108)
}
