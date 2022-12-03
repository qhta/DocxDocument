namespace DocumentModel.Drawings;

/// <summary>
/// Size Represents
/// </summary>
public enum SizeRepresentsKind
{
  /// <summary>
  /// Bubble Size Represents Area.
  /// </summary>
  [XmlEnum("area")]
  Area,
  
  /// <summary>
  /// Bubble Size Represents Width.
  /// </summary>
  [XmlEnum("w")]
  Width,
  
}
