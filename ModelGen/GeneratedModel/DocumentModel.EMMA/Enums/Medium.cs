namespace DocumentModel.EMMA;

/// <summary>
/// Defines the MediumValues enumeration.
/// </summary>
public enum Medium
{
  /// <summary>
  /// acoustic.
  /// </summary>
  [XmlEnum("acoustic")]
  Acoustic,
  
  /// <summary>
  /// tactile.
  /// </summary>
  [XmlEnum("tactile")]
  Tactile,
  
  /// <summary>
  /// visual.
  /// </summary>
  [XmlEnum("visual")]
  Visual,
  
}
