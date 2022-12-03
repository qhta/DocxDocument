namespace DocumentModel.Drawings;

/// <summary>
/// Light Rig Direction
/// </summary>
public enum LightRigDirectionKind
{
  /// <summary>
  /// Top Left.
  /// </summary>
  [XmlEnum("tl")]
  TopLeft,
  
  /// <summary>
  /// Top.
  /// </summary>
  [XmlEnum("t")]
  Top,
  
  /// <summary>
  /// Top Right.
  /// </summary>
  [XmlEnum("tr")]
  TopRight,
  
  /// <summary>
  /// Left.
  /// </summary>
  [XmlEnum("l")]
  Left,
  
  /// <summary>
  /// Right.
  /// </summary>
  [XmlEnum("r")]
  Right,
  
  /// <summary>
  /// Bottom Left.
  /// </summary>
  [XmlEnum("bl")]
  BottomLeft,
  
  /// <summary>
  /// Bottom.
  /// </summary>
  [XmlEnum("b")]
  Bottom,
  
  /// <summary>
  /// Bottom Right.
  /// </summary>
  [XmlEnum("br")]
  BottomRight,
  
}
