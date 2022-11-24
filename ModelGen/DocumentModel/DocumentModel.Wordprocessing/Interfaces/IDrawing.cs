namespace DocumentModel.Wordprocessing;

/// <summary>
/// DrawingML Object.
/// </summary>
public interface IDrawing // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Drawing Element Anchor.
  /// </summary>
  public IAnchor? Anchor { get ; set; }
  
  /// <summary>
  /// Inline Drawing Object.
  /// </summary>
  public Inline? Inline { get ; set; }
  
}
