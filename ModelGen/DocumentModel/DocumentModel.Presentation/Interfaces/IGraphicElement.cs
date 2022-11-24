namespace DocumentModel.Presentation;

/// <summary>
/// Graphic Element.
/// </summary>
public interface IGraphicElement // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Diagram to Animate.
  /// </summary>
  public IDiagram? Diagram { get ; set; }
  
  /// <summary>
  /// Chart to Animate.
  /// </summary>
  public IChart? Chart { get ; set; }
  
}
