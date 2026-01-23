namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Specifies rectangle alignment options for positioning and layout in WordprocessingML drawings.
/// This enumeration provides values for various alignment positions, supporting precise control over the placement of rectangles and graphical elements within the document.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum RectangleAlignmentKind
{

  /// <summary>
  /// No alignment specified.
  /// </summary>
  None,

  /// <summary>
  /// Top left alignment.
  /// </summary>
  TopLeft,

  /// <summary>
  /// Top alignment.
  /// </summary>
  Top,

  /// <summary>
  /// Top right alignment.
  /// </summary>
  TopRight,

  /// <summary>
  /// Left alignment.
  /// </summary>
  Left,

  /// <summary>
  /// Center alignment.
  /// </summary>
  Center,

  /// <summary>
  /// Right alignment.
  /// </summary>
  Right,

  /// <summary>
  /// Bottom left alignment.
  /// </summary>
  BottomLeft,

  /// <summary>
  /// Bottom alignment.
  /// </summary>
  Bottom,

  /// <summary>
  /// Bottom right alignment.
  /// </summary>
  BottomRight
}