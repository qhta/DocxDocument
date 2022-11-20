namespace DocumentModel.Drawing;

/// <summary>
/// Table Row.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITableCell))]
public interface ITableRow // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Height
  /// </summary>
  public long? Height { get ; set; }
  
}
