namespace DocumentModel.Drawing;

/// <summary>
/// Table Grid Column.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
public interface IGridColumn // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Width
  /// </summary>
  public long? Width { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
