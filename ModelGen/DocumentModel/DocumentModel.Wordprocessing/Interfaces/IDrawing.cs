namespace DocumentModel.Wordprocessing;

/// <summary>
/// DrawingML Object.
/// </summary>
public interface IDrawing // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Drawing Element Anchor.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawing.IAnchor? Anchor { get ; set; }
  
  /// <summary>
  /// Inline Drawing Object.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawing.IInline? Inline { get ; set; }
  
}
