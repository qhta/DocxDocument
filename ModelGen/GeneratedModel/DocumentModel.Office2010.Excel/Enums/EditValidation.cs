namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the EditValidationValues enumeration.
/// </summary>
public enum EditValidation
{
  /// <summary>
  /// text.
  /// </summary>
  [XmlEnum("text")]
  Text,
  
  /// <summary>
  /// integer.
  /// </summary>
  [XmlEnum("integer")]
  Integer,
  
  /// <summary>
  /// number.
  /// </summary>
  [XmlEnum("number")]
  Number,
  
  /// <summary>
  /// reference.
  /// </summary>
  [XmlEnum("reference")]
  Reference,
  
  /// <summary>
  /// formula.
  /// </summary>
  [XmlEnum("formula")]
  Formula,
  
}
