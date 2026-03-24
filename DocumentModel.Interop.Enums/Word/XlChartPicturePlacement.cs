namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the placement of a user-selected picture on a bar in a 3-D bar or column.
/// </summary>
public enum XlChartPicturePlacement
{
  /// <summary>
  /// Display on sides.
  /// </summary>
  Sides = unchecked((int)1),
  /// <summary>
  /// Display on end.
  /// </summary>
  End = unchecked((int)2),
  /// <summary>
  /// Display on end and sides.
  /// </summary>
  EndSides = unchecked((int)3),
  /// <summary>
  /// Display on front.
  /// </summary>
  Front = unchecked((int)4),
  /// <summary>
  /// Display on front and sides.
  /// </summary>
  FrontSides = unchecked((int)5),
  /// <summary>
  /// Display on front and end.
  /// </summary>
  FrontEnd = unchecked((int)6),
  /// <summary>
  /// Display on all faces.
  /// </summary>
  AllFaces = unchecked((int)7)
}
