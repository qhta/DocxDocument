namespace DocumentModel.Drawing.Charts;

public interface IMultiLevelStringReference // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.Charts.IFormula? Formula { get ; set; }
  
  public IMultiLevelStringCache? MultiLevelStringCache { get ; set; }
  
  public IMultiLvlStrRefExtensionList? MultiLvlStrRefExtensionList { get ; set; }
  
}
