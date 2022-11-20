namespace DocumentModel.Drawing;

/// <summary>
/// Draw Line To.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IPoint))]
public interface ILineTo // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Line end point.
  /// </summary>
  public DocumentModel.Drawing.IPoint? Point { get ; set; }
  
}
