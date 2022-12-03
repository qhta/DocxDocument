namespace DocumentModel.Spreadsheet;

/// <summary>
/// Data Validation Type
/// </summary>
public enum DataValidationKind
{
  /// <summary>
  /// None.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Whole Number.
  /// </summary>
  [XmlEnum("whole")]
  Whole,
  
  /// <summary>
  /// Decimal.
  /// </summary>
  [XmlEnum("decimal")]
  Decimal,
  
  /// <summary>
  /// List.
  /// </summary>
  [XmlEnum("list")]
  List,
  
  /// <summary>
  /// Date.
  /// </summary>
  [XmlEnum("date")]
  Date,
  
  /// <summary>
  /// Time.
  /// </summary>
  [XmlEnum("time")]
  Time,
  
  /// <summary>
  /// Text Length.
  /// </summary>
  [XmlEnum("textLength")]
  TextLength,
  
  /// <summary>
  /// Custom.
  /// </summary>
  [XmlEnum("custom")]
  Custom,
  
}
