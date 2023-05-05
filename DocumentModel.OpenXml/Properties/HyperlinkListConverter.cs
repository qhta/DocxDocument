namespace DocumentModel.OpenXml.Properties;

/// <summary>
///   Hyperlink List.
/// </summary>
public static class HyperlinkListConverter
{
  public static VectorVariant? GetVTVector(DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? openXmlElement)
  {
    return VTVectorConverter.CreateModelElement(openXmlElement?.VTVector);
  }

  public static void SetVTVector(DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? openXmlElement, VectorVariant? value)
  {
    if (openXmlElement != null)
      openXmlElement.VTVector = VTVectorConverter.CreateOpenXmlElement(value);
  }

  public static StringList? GetStrings(DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? openXmlElement)
  {
    return VTVectorConverter.GetStringList(openXmlElement?.VTVector);
  }

  public static void SetStrings(DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? openXmlElement, StringList? value)
  {
    if (openXmlElement != null)
      openXmlElement.VTVector = VTVectorConverter.CreateOpenXmlElement(value);
  }

  public static StringList? CreateModelElement(DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = GetStrings(openXmlElement);
      return value;
    }
    return null;
  }

  public static DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? CreateOpenXmlElement(VectorVariant? value)
  {
    if (value != null)
    {
      var openXmlElement = new DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList();
      SetVTVector(openXmlElement, value);
      return openXmlElement;
    }
    return null;
  }

  public static DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? CreateOpenXmlElement(StringList? value)
  {
    if (value != null)
    {
      var openXmlElement = new DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList();
      SetStrings(openXmlElement, value);
      return openXmlElement;
    }
    return null;
  }
}