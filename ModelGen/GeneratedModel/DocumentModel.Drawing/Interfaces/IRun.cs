namespace DocumentModel.Drawing;

/// <summary>
/// Text Run.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IRunProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IText))]
public interface IRun // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text Character Properties.
  /// </summary>
  public DocumentModel.Drawing.IRunProperties? RunProperties { get ; set; }
  
  /// <summary>
  /// Text String.
  /// </summary>
  public DocumentModel.Drawing.IText? Text { get ; set; }
  
}
