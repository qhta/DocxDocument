namespace DocumentModel.Spreadsheet;

/// <summary>
/// Top N Evaluation Type
/// </summary>
public enum RuleKind
{
  /// <summary>
  /// Top N None.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// All.
  /// </summary>
  [XmlEnum("all")]
  All,
  
  /// <summary>
  /// Row Top N.
  /// </summary>
  [XmlEnum("row")]
  Row,
  
  /// <summary>
  /// Column Top N.
  /// </summary>
  [XmlEnum("column")]
  Column,
  
}
