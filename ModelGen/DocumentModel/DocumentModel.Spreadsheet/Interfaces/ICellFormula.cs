namespace DocumentModel.Spreadsheet;

/// <summary>
/// Formula.
/// </summary>
public interface ICellFormula // : DocumentModel.ITypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Formula Type
  /// </summary>
  public DocumentModel.Spreadsheet.CellFormulaKind? FormulaType { get ; set; }
  
  /// <summary>
  /// Always Calculate Array
  /// </summary>
  public System.Boolean? AlwaysCalculateArray { get ; set; }
  
  /// <summary>
  /// Range of Cells
  /// </summary>
  public System.String? Reference { get ; set; }
  
  /// <summary>
  /// Data Table 2-D
  /// </summary>
  public System.Boolean? DataTable2D { get ; set; }
  
  /// <summary>
  /// Data Table Row
  /// </summary>
  public System.Boolean? DataTableRow { get ; set; }
  
  /// <summary>
  /// Input 1 Deleted
  /// </summary>
  public System.Boolean? Input1Deleted { get ; set; }
  
  /// <summary>
  /// Input 2 Deleted
  /// </summary>
  public System.Boolean? Input2Deleted { get ; set; }
  
  /// <summary>
  /// Data Table Cell 1
  /// </summary>
  public System.String? R1 { get ; set; }
  
  /// <summary>
  /// Input Cell 2
  /// </summary>
  public System.String? R2 { get ; set; }
  
  /// <summary>
  /// Calculate Cell
  /// </summary>
  public System.Boolean? CalculateCell { get ; set; }
  
  /// <summary>
  /// Shared Group Index
  /// </summary>
  public System.UInt32? SharedIndex { get ; set; }
  
  /// <summary>
  /// Assigns Value to Name
  /// </summary>
  public System.Boolean? Bx { get ; set; }
  
  /// <summary>
  /// Content Contains Significant Whitespace
  /// </summary>
  public DocumentModel.SpaceProcessingMode? Space { get ; set; }
  
}
