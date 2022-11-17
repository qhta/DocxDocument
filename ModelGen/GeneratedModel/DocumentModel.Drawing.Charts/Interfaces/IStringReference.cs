namespace DocumentModel.Drawing.Charts;

public interface IStringReference // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.Charts.IFormula? Formula { get ; set; }
  
  public IStringCache? StringCache { get ; set; }
  
  public IStrRefExtensionList? StrRefExtensionList { get ; set; }
  
}
