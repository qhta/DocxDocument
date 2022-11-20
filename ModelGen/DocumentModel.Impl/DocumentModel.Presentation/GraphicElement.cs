namespace DocumentModel.Presentation;

/// <summary>
/// Graphic Element.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IChart))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IDiagram))]
public class GraphicElement: IGraphicElement
{
  /// <summary>
  /// Diagram to Animate.
  /// </summary>
  public DocumentModel.Drawing.IDiagram? Diagram
  {
    get;
    set;
  }
  
  /// <summary>
  /// Chart to Animate.
  /// </summary>
  public DocumentModel.Drawing.IChart? Chart
  {
    get;
    set;
  }
  
}
