namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the CheckedValues enumeration.
/// </summary>
public enum CheckedValues
{
  /// <summary>
  /// Unchecked.
  /// </summary>
  [XmlEnum("Unchecked")]
  Unchecked,
  
  /// <summary>
  /// Checked.
  /// </summary>
  [XmlEnum("Checked")]
  Checked,
  
  /// <summary>
  /// Mixed.
  /// </summary>
  [XmlEnum("Mixed")]
  Mixed,
  
}
