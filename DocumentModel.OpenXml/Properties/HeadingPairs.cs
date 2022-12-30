using DocumentFormat.OpenXml.VariantTypes;
using DocumentFormat.OpenXml;

namespace DocumentModel.OpenXml.Properties;

/// <summary>
/// Heading Pairs.
/// </summary>
public partial class HeadingPairs: DocumentModel.OpenXml.Properties.VectorVariantType
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public HeadingPairs(): base() {}
  
  public HeadingPairs(DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
}
