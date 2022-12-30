namespace DocumentModel.OpenXml.Properties;

/// <summary>
/// Hyperlink List.
/// </summary>
public partial class HyperlinkList : DocumentModel.OpenXml.Properties.VectorVariantType
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }

  public HyperlinkList() : base() { }

  public HyperlinkList(DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList openXmlElement) : base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }

}
