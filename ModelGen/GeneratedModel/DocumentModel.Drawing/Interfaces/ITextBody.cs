namespace DocumentModel.Drawing;

/// <summary>
/// Shape Text Body.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBodyProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IListStyle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IParagraph))]
public interface ITextBody // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Body Properties.
  /// </summary>
  public IBodyProperties? BodyProperties { get ; set; }
  
  /// <summary>
  /// Text List Styles.
  /// </summary>
  public IListStyle? ListStyle { get ; set; }
  
}
