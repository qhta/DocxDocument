namespace DocumentModel.Presentation;

/// <summary>
/// Graphic Element.
/// </summary>
public interface GraphicElement // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Diagram to Animate.
  /// </summary>
  public DocumentModel.Drawings.Diagram? Diagram { get ; set; }
  
  /// <summary>
  /// Chart to Animate.
  /// </summary>
  public DocumentModel.Drawings.Chart? Chart { get ; set; }
  
}
