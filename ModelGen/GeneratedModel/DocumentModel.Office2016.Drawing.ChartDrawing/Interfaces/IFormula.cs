namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the Formula Class.
/// </summary>
public interface IFormula // : DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlFormulaElement
{
  /// <summary>
  /// dir, this property is only available in Office 2016 and later.
  /// </summary>
  public FormulaDirection? Dir { get ; set; }
  
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
