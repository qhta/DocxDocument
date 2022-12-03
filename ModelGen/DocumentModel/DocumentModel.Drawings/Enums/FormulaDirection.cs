namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FormulaDirection enumeration.
/// </summary>
public enum FormulaDirection
{
  /// <summary>
  /// col.
  /// </summary>
  [XmlEnum("col")]
  Col,
  
  /// <summary>
  /// row.
  /// </summary>
  [XmlEnum("row")]
  Row,
  
}
