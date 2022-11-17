namespace DocumentModel.Office2019.Excel.RichData2;

public interface IRichValueGlobalType // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IRichValueTypeKeyFlags? RichValueTypeKeyFlags { get ; set; }
  
  public DocumentModel.Office2019.Excel.RichData2.IExtensionList? ExtensionList { get ; set; }
  
}
