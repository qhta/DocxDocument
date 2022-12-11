namespace DocumentModel.Impl;

public class ModelElementImpl: ModelElement
{
  public ModelElementImpl() { }

  public ModelElementImpl(DocumentFormat.OpenXml.OpenXmlElement openXmlElement)
  {
    _OpenXmlElement = openXmlElement;
  }

  public DocumentFormat.OpenXml.OpenXmlElement? _OpenXmlElement { get; set; }
}