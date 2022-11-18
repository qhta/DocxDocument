namespace DocumentModel.Spreadsheet;

/// <summary>
/// Underline Types
/// </summary>
public enum Underline
{
  /// <summary>
  /// Single Underline.
  /// </summary>
  [XmlEnum("single")]
  Single,
  
  /// <summary>
  /// Double Underline.
  /// </summary>
  [XmlEnum("double")]
  Double,
  
  /// <summary>
  /// Accounting Single Underline.
  /// </summary>
  [XmlEnum("singleAccounting")]
  SingleAccounting,
  
  /// <summary>
  /// Accounting Double Underline.
  /// </summary>
  [XmlEnum("doubleAccounting")]
  DoubleAccounting,
  
  /// <summary>
  /// None.
  /// </summary>
  [XmlEnum("none")]
  None,
  
}
