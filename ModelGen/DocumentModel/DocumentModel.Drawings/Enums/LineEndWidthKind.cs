namespace DocumentModel.Drawings;

/// <summary>
/// Line End Width
/// </summary>
public enum LineEndWidthKind
{
  /// <summary>
  /// Small.
  /// </summary>
  [XmlEnum("sm")]
  Small,
  
  /// <summary>
  /// Medium.
  /// </summary>
  [XmlEnum("med")]
  Medium,
  
  /// <summary>
  /// Large.
  /// </summary>
  [XmlEnum("lg")]
  Large,
  
}
