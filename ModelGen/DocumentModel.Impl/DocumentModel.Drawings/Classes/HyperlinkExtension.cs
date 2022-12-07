namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HyperlinkExtension Class.
/// </summary>
public class HyperlinkExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.HyperlinkExtension>, HyperlinkExtension
{
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColor>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColor{ Val = (DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
}
