namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CheckedValues enumeration.
/// </summary>
public enum CheckedKind
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
