namespace DocumentModel.Spreadsheet;

/// <summary>
/// Calculated Column Formula.
/// </summary>
public interface ICalculatedColumnFormula // : DocumentFormat.OpenXml.Spreadsheet.TableFormulaType
{
  /// <summary>
  /// Array
  /// </summary>
  public bool? Array { get ; set; }
  
  /// <summary>
  /// space
  /// </summary>
  public SpaceProcessingModeValues? Space { get ; set; }
  
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
