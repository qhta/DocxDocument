namespace DocumentModel.Spreadsheet;

/// <summary>
/// Formula.
/// </summary>
public class CellFormula: ICellFormula
{
  /// <summary>
  /// Formula Type
  /// </summary>
  public CellFormulaValues? FormulaType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Always Calculate Array
  /// </summary>
  public bool? AlwaysCalculateArray
  {
    get;
    set;
  }
  
  /// <summary>
  /// Range of Cells
  /// </summary>
  public string? Reference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Data Table 2-D
  /// </summary>
  public bool? DataTable2D
  {
    get;
    set;
  }
  
  /// <summary>
  /// Data Table Row
  /// </summary>
  public bool? DataTableRow
  {
    get;
    set;
  }
  
  /// <summary>
  /// Input 1 Deleted
  /// </summary>
  public bool? Input1Deleted
  {
    get;
    set;
  }
  
  /// <summary>
  /// Input 2 Deleted
  /// </summary>
  public bool? Input2Deleted
  {
    get;
    set;
  }
  
  /// <summary>
  /// Data Table Cell 1
  /// </summary>
  public string? R1
  {
    get;
    set;
  }
  
  /// <summary>
  /// Input Cell 2
  /// </summary>
  public string? R2
  {
    get;
    set;
  }
  
  /// <summary>
  /// Calculate Cell
  /// </summary>
  public bool? CalculateCell
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shared Group Index
  /// </summary>
  public uint? SharedIndex
  {
    get;
    set;
  }
  
  /// <summary>
  /// Assigns Value to Name
  /// </summary>
  public bool? Bx
  {
    get;
    set;
  }
  
  /// <summary>
  /// Content Contains Significant Whitespace
  /// </summary>
  public SpaceProcessingModeValues? Space
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text
  {
    get;
    set;
  }
  
}
