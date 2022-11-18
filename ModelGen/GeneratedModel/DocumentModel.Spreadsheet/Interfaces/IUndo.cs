namespace DocumentModel.Spreadsheet;

/// <summary>
/// Undo.
/// </summary>
public interface IUndo // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Index
  /// </summary>
  public uint? Index { get ; set; }
  
  /// <summary>
  /// Expression
  /// </summary>
  public FormulaExpression? Expression { get ; set; }
  
  /// <summary>
  /// Reference 3D
  /// </summary>
  public bool? Reference3D { get ; set; }
  
  /// <summary>
  /// Array Entered
  /// </summary>
  public bool? Array { get ; set; }
  
  /// <summary>
  /// Value Needed
  /// </summary>
  public bool? Val { get ; set; }
  
  /// <summary>
  /// Defined Name Formula
  /// </summary>
  public bool? DefinedNameFormula { get ; set; }
  
  /// <summary>
  /// Cross Sheet Move
  /// </summary>
  public bool? CrossSheetMove { get ; set; }
  
  /// <summary>
  /// Range
  /// </summary>
  public string? DeletedRange { get ; set; }
  
  /// <summary>
  /// Defined Name
  /// </summary>
  public string? DefinedName { get ; set; }
  
  /// <summary>
  /// Cell Reference
  /// </summary>
  public string? CellReference { get ; set; }
  
  /// <summary>
  /// Sheet Id
  /// </summary>
  public uint? SheetId { get ; set; }
  
}
