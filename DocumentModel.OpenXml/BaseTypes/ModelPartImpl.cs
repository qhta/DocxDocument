namespace DocumentModel.OpenXml;

public class ModelPartImpl : ModelElement
{
  [XmlIgnore]
  public object? _OpenXmlElement { get; protected set; }
}