namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the LightRigDirectionValues enumeration.
/// </summary>
public enum LightRigDirection
{
  /// <summary>
  /// tl.
  /// </summary>
  [XmlEnum("tl")]
  TopLeft,
  
  /// <summary>
  /// t.
  /// </summary>
  [XmlEnum("t")]
  Top,
  
  /// <summary>
  /// tr.
  /// </summary>
  [XmlEnum("tr")]
  TopRight,
  
  /// <summary>
  /// l.
  /// </summary>
  [XmlEnum("l")]
  Left,
  
  /// <summary>
  /// r.
  /// </summary>
  [XmlEnum("r")]
  Right,
  
  /// <summary>
  /// bl.
  /// </summary>
  [XmlEnum("bl")]
  BottomLeft,
  
  /// <summary>
  /// b.
  /// </summary>
  [XmlEnum("b")]
  Bottom,
  
  /// <summary>
  /// br.
  /// </summary>
  [XmlEnum("br")]
  BottomRight,
  
}
