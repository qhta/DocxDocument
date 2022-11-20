namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ConformanceClassValues enumeration.
/// </summary>
public enum ConformanceClassValues
{
  /// <summary>
  /// strict.
  /// </summary>
  [XmlEnum("strict")]
  Strict,
  
  /// <summary>
  /// transitional.
  /// </summary>
  [XmlEnum("transitional")]
  Transitional,
  
}
