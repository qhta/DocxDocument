namespace DocumentModel.Drawings.Office;

/// <summary>
/// Defines the Drawing Class.
/// </summary>
public partial class DrawingImpl: ModelElementImpl, Drawing
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office.Drawing.Drawing? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.Drawing?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
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
  
}
