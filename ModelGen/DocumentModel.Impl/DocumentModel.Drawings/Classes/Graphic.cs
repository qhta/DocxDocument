namespace DocumentModel.Drawings;

/// <summary>
/// Graphic Object.
/// </summary>
public class GraphicImpl: ModelElementImpl, Graphic
{
  public DocumentFormat.OpenXml.Drawing.Graphic? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Graphic?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GraphicImpl(): base() {}
  
  public GraphicImpl(DocumentFormat.OpenXml.Drawing.Graphic openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Graphic Object Data.
  /// </summary>
  public DocumentModel.Drawings.GraphicData? GraphicData
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GraphicData>();
        if (item != null)
          return new DocumentModel.Drawings.GraphicDataImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GraphicData>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.GraphicDataImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
