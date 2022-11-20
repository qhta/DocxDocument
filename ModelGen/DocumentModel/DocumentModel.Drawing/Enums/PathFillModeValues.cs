namespace DocumentModel.Drawing;

/// <summary>
/// Path Fill Mode
/// </summary>
public enum PathFillModeValues
{
  /// <summary>
  /// No Path Fill.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Normal Path Fill.
  /// </summary>
  [XmlEnum("norm")]
  Norm,
  
  /// <summary>
  /// Lighten Path Fill.
  /// </summary>
  [XmlEnum("lighten")]
  Lighten,
  
  /// <summary>
  /// Lighten Path Fill Less.
  /// </summary>
  [XmlEnum("lightenLess")]
  LightenLess,
  
  /// <summary>
  /// Darken Path Fill.
  /// </summary>
  [XmlEnum("darken")]
  Darken,
  
  /// <summary>
  /// Darken Path Fill Less.
  /// </summary>
  [XmlEnum("darkenLess")]
  DarkenLess,
  
}
