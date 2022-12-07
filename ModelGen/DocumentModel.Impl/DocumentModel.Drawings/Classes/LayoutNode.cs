namespace DocumentModel.Drawings;

/// <summary>
/// Layout Node.
/// </summary>
public class LayoutNodeImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>, LayoutNode
{
  /// <summary>
  /// Child Order
  /// </summary>
  public ChildOrderKind? ChildOrder
  {
    get => (ChildOrderKind?)OpenXmlElement?.ChildOrder?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ChildOrder = (DocumentFormat.OpenXml.Drawing.Diagrams.ChildOrderValues?)value;
    }
  }
  
}
