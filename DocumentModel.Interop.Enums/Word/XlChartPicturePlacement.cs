namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the placement of a user-selected picture on a bar in a 3-D bar or column.
/// </summary>
public enum XlChartPicturePlacement
{
  /// <summary>
  /// Display on sides.
  /// </summary>
  xlSides = unchecked((int)1),
  /// <summary>
  /// Display on end.
  /// </summary>
  xlEnd = unchecked((int)2),
  /// <summary>
  /// Display on end and sides.
  /// </summary>
  xlEndSides = unchecked((int)3),
  /// <summary>
  /// Display on front.
  /// </summary>
  xlFront = unchecked((int)4),
  /// <summary>
  /// Display on front and sides.
  /// </summary>
  xlFrontSides = unchecked((int)5),
  /// <summary>
  /// Display on front and end.
  /// </summary>
  xlFrontEnd = unchecked((int)6),
  /// <summary>
  /// Display on all faces.
  /// </summary>
  xlAllFaces = unchecked((int)7)
}
