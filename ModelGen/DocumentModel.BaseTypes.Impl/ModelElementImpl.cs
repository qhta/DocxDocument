using System.Xml.Serialization;

namespace DocumentModel;

public class ModelElementImpl: ModelElement
{
  public ModelElementImpl() { }

  public ModelElementImpl(DocumentFormat.OpenXml.OpenXmlElement openXmlElement)
  {
    _OpenXmlElement = openXmlElement;
  }

  [XmlIgnore]
  public DocumentFormat.OpenXml.OpenXmlElement? _OpenXmlElement { get; protected set; }
}