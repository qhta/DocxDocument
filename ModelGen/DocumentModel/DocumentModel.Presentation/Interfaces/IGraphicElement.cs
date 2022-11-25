namespace DocumentModel.Presentation;

/// <summary>
/// Graphic Element.
/// </summary>
public interface IGraphicElement // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Diagram to Animate.
  /// </summary>
  public DocumentModel.Drawing.IDiagram? Diagram { get ; set; }
  
  /// <summary>
  /// Chart to Animate.
  /// </summary>
  public DocumentModel.Drawing.IChart? Chart { get ; set; }
  
}
