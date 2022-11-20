namespace DocumentModel.Office2019.Excel.RichData2;

/// <summary>
/// Defines the RichValueGlobalType Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Excel.RichData2.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Excel.RichData2.IRichValueTypeKeyFlags))]
public interface IRichValueGlobalType // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// RichValueTypeKeyFlags.
  /// </summary>
  public IRichValueTypeKeyFlags? RichValueTypeKeyFlags { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2019.Excel.RichData2.IExtensionList? ExtensionList { get ; set; }
  
}
