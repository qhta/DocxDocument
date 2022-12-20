namespace DocumentModel.Drawings;

/// <summary>
/// Line Style List.
/// </summary>
public partial class LineStyleListImpl: ModelElementImpl, LineStyleList
{
  public DocumentFormat.OpenXml.Drawing.LineStyleList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.LineStyleList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LineStyleListImpl(): base() {}
  
  public LineStyleListImpl(DocumentFormat.OpenXml.Drawing.LineStyleList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.Drawings.Outline? Outline
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Outline>();
        if (item != null)
          return new DocumentModel.Drawings.OutlineImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Outline>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.OutlineImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
