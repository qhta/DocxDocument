namespace DocumentModel.OpenXml.Properties;

/// <summary>
///   Hyperlink List.
/// </summary>
public class HyperlinkList : VectorVariantType
{
  public HyperlinkList()
  {
  }

  public HyperlinkList(DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList openXmlElement) : base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }

  [XmlIgnore]
  public new DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
}