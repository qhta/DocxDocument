namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableVerticalAlignmentValues enumeration.
/// </summary>
public enum TableVerticalAlignment
{
  /// <summary>
  /// top.
  /// </summary>
  [XmlEnum("top")]
  Top,
  
  /// <summary>
  /// center.
  /// </summary>
  [XmlEnum("center")]
  Center,
  
  /// <summary>
  /// bottom.
  /// </summary>
  [XmlEnum("bottom")]
  Bottom,
  
}
