namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the OpenXmlFormulaElement Class.
/// </summary>
public interface IOpenXmlFormulaElement // : DocumentModel.ITypedOpenXmlLeafTextElement
{
  /// <summary>
  /// dir, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.FormulaDirection? Dir { get ; set; }
  
}
