namespace DocumentModel.Drawings;

/// <summary>
/// Line End Length
/// </summary>
public enum LineEndLengthKind
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
