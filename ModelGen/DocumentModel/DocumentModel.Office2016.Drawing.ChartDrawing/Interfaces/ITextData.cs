namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the TextData Class.
/// </summary>
public interface ITextData // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public DocumentModel.Office2016.Drawing.ChartDrawing.IOpenXmlFormulaElement? Formula { get ; set; }
  
  public System.String? VXsdstring { get ; set; }
  
}
