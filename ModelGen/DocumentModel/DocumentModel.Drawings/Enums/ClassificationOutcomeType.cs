namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ClassificationOutcomeType enumeration.
/// </summary>
public enum ClassificationOutcomeType
{
  /// <summary>
  /// none.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// hdr.
  /// </summary>
  [XmlEnum("hdr")]
  Hdr,
  
  /// <summary>
  /// ftr.
  /// </summary>
  [XmlEnum("ftr")]
  Ftr,
  
  /// <summary>
  /// watermark.
  /// </summary>
  [XmlEnum("watermark")]
  Watermark,
  
}
