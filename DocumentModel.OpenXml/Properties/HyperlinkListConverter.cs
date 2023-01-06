namespace DocumentModel.OpenXml.Properties;

/// <summary>
/// Hyperlink List.
/// </summary>
public static class HyperlinkListConverter
{
  public static DocumentModel.VectorVariant? GetVTVector(DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? openXmlElement)
  {
    return VTVectorConverter.CreateModelElement(openXmlElement?.VTVector);
  }

  public static void SetVTVector(DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? openXmlElement, DocumentModel.VectorVariant? value)
  {
    if (openXmlElement != null)
      openXmlElement.VTVector = VTVectorConverter.CreateOpenXmlElement(value);
  }

  public static DocumentModel.StringList? GetStringList(DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? openXmlElement)
  {
    return VTVectorConverter.GetStringList(openXmlElement?.VTVector);
  }

  public static void SetStringList(DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? openXmlElement, DocumentModel.StringList? value)
  {
    if (openXmlElement != null)
      openXmlElement.VTVector = VTVectorConverter.CreateOpenXmlElement(value);
  }

  public static DocumentModel.StringList? CreateModelElement(DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = GetStringList(openXmlElement);
      return value;
    }
    return null;
  }


  public static DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? CreateOpenXmlElement(DocumentModel.VectorVariant? value)
  {
    if (value != null)
    {
      var openXmlElement = new DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList();
      SetVTVector(openXmlElement, value);
      return openXmlElement;
    }
    return null;
  }

  public static DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? CreateOpenXmlElement(DocumentModel.StringList? value)
  {
    if (value != null)
    {
      var openXmlElement = new DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList();
      SetStringList(openXmlElement, value);
      return openXmlElement;
    }
    return null;
  }
}
