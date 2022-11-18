namespace DocumentModel.Drawing;

/// <summary>
/// Rectangle Alignments
/// </summary>
public enum RectangleAlignment
{
  /// <summary>
  /// Rectangle Alignment Enum ( Top Left ).
  /// </summary>
  [XmlEnum("tl")]
  TopLeft,
  
  /// <summary>
  /// Rectangle Alignment Enum ( Top ).
  /// </summary>
  [XmlEnum("t")]
  Top,
  
  /// <summary>
  /// Rectangle Alignment Enum ( Top Right ).
  /// </summary>
  [XmlEnum("tr")]
  TopRight,
  
  /// <summary>
  /// Rectangle Alignment Enum ( Left ).
  /// </summary>
  [XmlEnum("l")]
  Left,
  
  /// <summary>
  /// Rectangle Alignment Enum ( Center ).
  /// </summary>
  [XmlEnum("ctr")]
  Center,
  
  /// <summary>
  /// Rectangle Alignment Enum ( Right ).
  /// </summary>
  [XmlEnum("r")]
  Right,
  
  /// <summary>
  /// Rectangle Alignment Enum ( Bottom Left ).
  /// </summary>
  [XmlEnum("bl")]
  BottomLeft,
  
  /// <summary>
  /// Rectangle Alignment Enum ( Bottom ).
  /// </summary>
  [XmlEnum("b")]
  Bottom,
  
  /// <summary>
  /// Rectangle Alignment Enum ( Bottom Right ).
  /// </summary>
  [XmlEnum("br")]
  BottomRight,
  
}
