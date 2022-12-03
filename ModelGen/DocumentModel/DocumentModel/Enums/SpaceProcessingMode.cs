namespace DocumentModel;

/// <summary>
/// Defines the SpaceProcessingModeValues enumeration.
/// </summary>
public enum SpaceProcessingMode
{
  /// <summary>
  /// default.
  /// </summary>
  [XmlEnum("default")]
  Default,
  
  /// <summary>
  /// preserve.
  /// </summary>
  [XmlEnum("preserve")]
  Preserve,
  
}
