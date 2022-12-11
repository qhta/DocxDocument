namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HyperlinkExtension Class.
/// </summary>
public class HyperlinkExtensionImpl: ModelElementImpl, HyperlinkExtension
{
  public DocumentFormat.OpenXml.Drawing.HyperlinkExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.HyperlinkExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public HyperlinkExtensionImpl(): base() {}
  
  public HyperlinkExtensionImpl(DocumentFormat.OpenXml.Drawing.HyperlinkExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public HyperlinkColorEnum? HyperlinkColor
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColor>();
        return (HyperlinkColorEnum?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColor>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColor{ Val = (DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
