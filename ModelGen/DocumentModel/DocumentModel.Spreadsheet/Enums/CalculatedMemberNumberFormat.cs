namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CalculatedMemberNumberFormat enumeration.
/// </summary>
public enum CalculatedMemberNumberFormat
{
  /// <summary>
  /// default.
  /// </summary>
  [XmlEnum("default")]
  Default,
  
  /// <summary>
  /// number.
  /// </summary>
  [XmlEnum("number")]
  Number,
  
  /// <summary>
  /// percent.
  /// </summary>
  [XmlEnum("percent")]
  Percent,
  
}
