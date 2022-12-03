namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ParentLabelLayoutVal enumeration.
/// </summary>
public enum ParentLabelLayoutVal
{
  /// <summary>
  /// none.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// banner.
  /// </summary>
  [XmlEnum("banner")]
  Banner,
  
  /// <summary>
  /// overlapping.
  /// </summary>
  [XmlEnum("overlapping")]
  Overlapping,
  
}
