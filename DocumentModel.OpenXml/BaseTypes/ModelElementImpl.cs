namespace DocumentModel.OpenXml;

public class ModelElementImpl : ModelObjectImpl
{
  public ModelElementImpl()
  {
  }

  public ModelElementImpl(OpenXmlElement openXmlElement)
  {
    _OpenXmlElement = openXmlElement;
  }
}