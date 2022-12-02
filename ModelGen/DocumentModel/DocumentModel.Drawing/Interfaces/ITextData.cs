namespace DocumentModel.Drawing;

/// <summary>
/// Defines the TextData Class.
/// </summary>
public interface ITextData // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public IOpenXmlFormulaElement? Formula { get ; set; }
  
  public String? VXsdstring { get ; set; }
  
}
