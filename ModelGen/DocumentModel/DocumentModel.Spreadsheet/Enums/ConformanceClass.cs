namespace DocumentModel.Spreadsheet;

/// <summary>
/// Document Conformance Class Value
/// </summary>
public enum ConformanceClass
{
  /// <summary>
  /// Office Open XML Strict.
  /// </summary>
  [XmlEnum("strict")]
  Enumstrict,
  
  /// <summary>
  /// Office Open XML Transitional.
  /// </summary>
  [XmlEnum("transitional")]
  Enumtransitional,
  
}
