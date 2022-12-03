namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the NumberSpacingValues enumeration.
/// </summary>
public enum NumberSpacingKind
{
  /// <summary>
  /// default.
  /// </summary>
  [XmlEnum("default")]
  Default,
  
  /// <summary>
  /// proportional.
  /// </summary>
  [XmlEnum("proportional")]
  Proportional,
  
  /// <summary>
  /// tabular.
  /// </summary>
  [XmlEnum("tabular")]
  Tabular,
  
}
