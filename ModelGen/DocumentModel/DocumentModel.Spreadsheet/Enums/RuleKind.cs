namespace DocumentModel.Spreadsheet;

/// <summary>
/// Top N Evaluation Type
/// </summary>
public enum RuleKind
{
  /// <summary>
  /// Top N None.
  /// </summary>
  None,
  
  /// <summary>
  /// All.
  /// </summary>
  All,
  
  /// <summary>
  /// Row Top N.
  /// </summary>
  Row,
  
  /// <summary>
  /// Column Top N.
  /// </summary>
  Column,
  
}
