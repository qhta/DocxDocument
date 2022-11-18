namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the PivotEditValueTypeValues enumeration.
/// </summary>
public enum PivotEditValueType
{
  /// <summary>
  /// number.
  /// </summary>
  [XmlEnum("number")]
  Number,
  
  /// <summary>
  /// dateTime.
  /// </summary>
  [XmlEnum("dateTime")]
  DateTime,
  
  /// <summary>
  /// string.
  /// </summary>
  [XmlEnum("string")]
  String,
  
  /// <summary>
  /// boolean.
  /// </summary>
  [XmlEnum("boolean")]
  Boolean,
  
  /// <summary>
  /// error.
  /// </summary>
  [XmlEnum("error")]
  Error,
  
}
