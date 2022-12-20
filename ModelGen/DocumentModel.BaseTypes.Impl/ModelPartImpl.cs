using System.Xml.Serialization;

namespace DocumentModel.Impl;

public class ModelPartImpl: ModelElement
{
  [XmlIgnore]
  public object? _OpenXmlElement { get; protected set; }
}