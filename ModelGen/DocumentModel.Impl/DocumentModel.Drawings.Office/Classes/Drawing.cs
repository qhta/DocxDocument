namespace DocumentModel.Drawings.Office;

/// <summary>
/// Defines the Drawing Class.
/// </summary>
public partial class DrawingImpl: ModelElementImpl, Drawing
{
  public DocumentFormat.OpenXml.Office.Drawing.Drawing? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.Drawing?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DrawingImpl(): base() {}
  
  public DrawingImpl(DocumentFormat.OpenXml.Office.Drawing.Drawing openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ShapeTree.
  /// </summary>
  public DocumentModel.Drawings.Office.ShapeTree? ShapeTree
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.ShapeTree>();
        if (item != null)
          return new DocumentModel.Drawings.Office.ShapeTreeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.ShapeTree>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Office.ShapeTreeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Gets the DiagramPersistLayoutPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.DiagramPersistLayoutPart? DiagramPersistLayoutPart
  {
    get
    {
      if (OpenXmlElement?.DiagramPersistLayoutPart != null)
        return new DocumentModel.Packaging.DiagramPersistLayoutPartImpl(OpenXmlElement.DiagramPersistLayoutPart);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
        if (value is DocumentModel.Packaging.DiagramPersistLayoutPartImpl valueImpl)
          if (valueImpl.OpenXmlElement != null)
              OpenXmlElement.SetPart(valueImpl.OpenXmlElement);
    }
  }
  
}
