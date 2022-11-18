namespace DocumentModel.Drawing;

/// <summary>
/// Stretch.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IFillRectangle))]
public interface IStretch // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Fill Rectangle.
  /// </summary>
  public IFillRectangle? FillRectangle { get ; set; }
  
}
