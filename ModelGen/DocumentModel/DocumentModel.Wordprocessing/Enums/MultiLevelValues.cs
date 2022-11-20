namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MultiLevelValues enumeration.
/// </summary>
public enum MultiLevelValues
{
  /// <summary>
  /// Single Level Numbering Definition.
  /// </summary>
  [XmlEnum("singleLevel")]
  SingleLevel,
  
  /// <summary>
  /// Multilevel Numbering Definition.
  /// </summary>
  [XmlEnum("multilevel")]
  Multilevel,
  
  /// <summary>
  /// Hybrid Multilevel Numbering Definition.
  /// </summary>
  [XmlEnum("hybridMultilevel")]
  HybridMultilevel,
  
}
