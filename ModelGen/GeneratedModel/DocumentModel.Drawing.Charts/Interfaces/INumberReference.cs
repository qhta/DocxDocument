namespace DocumentModel.Drawing.Charts;

public interface INumberReference // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.Charts.IFormula? Formula { get ; set; }
  
  public INumberingCache? NumberingCache { get ; set; }
  
  public INumRefExtensionList? NumRefExtensionList { get ; set; }
  
}
