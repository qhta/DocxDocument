namespace DocumentModel.Spreadsheet;

/// <summary>
/// Formula Type
/// </summary>
public enum CellFormulaKind
{
  /// <summary>
  /// Normal.
  /// </summary>
  Normal,
  
  /// <summary>
  /// Array Entered.
  /// </summary>
  Array,
  
  /// <summary>
  /// Table Formula.
  /// </summary>
  DataTable,
  
  /// <summary>
  /// Shared Formula.
  /// </summary>
  Shared,
  
}
