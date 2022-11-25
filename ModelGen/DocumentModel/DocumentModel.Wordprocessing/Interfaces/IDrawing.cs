namespace DocumentModel.Wordprocessing;

/// <summary>
/// DrawingML Object.
/// </summary>
public interface IDrawing // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Drawing Element Anchor.
  /// </summary>
  public DocumentModel.Drawing.Wordprocessing.IAnchor? Anchor { get ; set; }
  
  /// <summary>
  /// Inline Drawing Object.
  /// </summary>
  public DocumentModel.Drawing.Wordprocessing.IInline? Inline { get ; set; }
  
}
