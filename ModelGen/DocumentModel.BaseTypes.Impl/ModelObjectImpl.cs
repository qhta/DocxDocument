namespace DocumentModel.Impl;

public class ModelObjectImpl: ModelElement
{
  public ModelObjectImpl() { }

  public ModelObjectImpl(object openXmlElement)
  {
    _OpenXmlElement = openXmlElement;
  }

  public object? _OpenXmlElement { get; set; }
}