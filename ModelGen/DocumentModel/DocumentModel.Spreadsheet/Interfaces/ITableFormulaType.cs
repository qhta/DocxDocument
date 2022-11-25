namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TableFormulaType Class.
/// </summary>
public interface ITableFormulaType // : DocumentModel.ITypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Array
  /// </summary>
  public System.Boolean? Array { get ; set; }
  
  /// <summary>
  /// space
  /// </summary>
  public DocumentModel.SpaceProcessingMode? Space { get ; set; }
  
}
