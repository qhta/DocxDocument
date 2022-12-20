namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ColorMap Class.
/// </summary>
public partial class ColorMapImpl: DocumentModel.Drawings.ColorMappingTypeImpl, ColorMap
{
  public new DocumentFormat.OpenXml.Drawing.ColorMap? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ColorMap?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ColorMapImpl(): base() {}
  
  public ColorMapImpl(DocumentFormat.OpenXml.Drawing.ColorMap openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
