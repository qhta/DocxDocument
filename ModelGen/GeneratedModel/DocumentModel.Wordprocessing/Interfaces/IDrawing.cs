namespace DocumentModel.Wordprocessing;

/// <summary>
/// DrawingML Object.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IAnchor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IInline))]
public interface IDrawing // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Drawing Element Anchor.
  /// </summary>
  public DocumentModel.Drawing.Wordprocessing.IAnchor? Anchor { get ; set; }
  
  /// <summary>
  /// Inline Drawing Object.
  /// </summary>
  public IInline? Inline { get ; set; }
  
}
