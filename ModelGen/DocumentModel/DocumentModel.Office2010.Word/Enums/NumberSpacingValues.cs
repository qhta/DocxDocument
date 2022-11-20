namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the NumberSpacingValues enumeration.
/// </summary>
public enum NumberSpacingValues
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
