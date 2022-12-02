namespace DocumentModel.Drawing;

/// <summary>
/// Defines the TextData Class.
/// </summary>
public interface ITextData // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.IOpenXmlFormulaElement? Formula { get ; set; }
  
  public System.String? VXsdstring { get ; set; }
  
}
