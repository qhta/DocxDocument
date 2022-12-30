namespace DocumentModel.OpenXml;

public class ModelElementImpl: ModelObjectImpl
{
  public ModelElementImpl() { }

  public ModelElementImpl(DocumentFormat.OpenXml.OpenXmlElement openXmlElement)
  {
    _OpenXmlElement = openXmlElement;
  }

}