namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DocumentConformance enumeration.
/// </summary>
public enum DocumentConformance
{
  /// <summary>
  /// transitional.
  /// </summary>
  [XmlEnum("transitional")]
  transitional,
  
  /// <summary>
  /// strict.
  /// </summary>
  [XmlEnum("strict")]
  strict,
  
}
