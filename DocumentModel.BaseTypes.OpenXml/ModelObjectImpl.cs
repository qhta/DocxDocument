using System.Xml.Serialization;

namespace DocumentModel.Impl;

public class ModelObjectImpl: ModelElement
{
  public ModelObjectImpl() { }

  public ModelObjectImpl(object openXmlElement)
  {
    _OpenXmlElement = openXmlElement;
  }

  [XmlIgnore]
  public object? _OpenXmlElement { get; protected set; }
}