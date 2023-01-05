namespace DocumentModel.OpenXml.Properties;

/// <summary>
/// Hyperlink List.
/// </summary>
public static class HyperlinkListConverter
{
  public static DocumentModel.VectorVariant? GetVTVector(DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? openXmlElement)
  {
    return VTVectorConverter.GetValue(openXmlElement?.VTVector);
  }
  
  public static void SetVTVector(DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? openXmlElement, DocumentModel.VectorVariant? value)
  {
    if (openXmlElement != null)
      openXmlElement.VTVector = VTVectorConverter.CreateOpenXmlElement(value);
  }
  
  public static DocumentModel.Properties.HyperlinkList? GetValue(DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Properties.HyperlinkList();
      value.Vector = GetVTVector(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static void SetValue(DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? openXmlElement, DocumentModel.Properties.HyperlinkList? value)
  {
    if (openXmlElement != null)
    {
      SetVTVector(openXmlElement, value?.Vector);
    }
  }
  
  public static DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? CreateOpenXmlElement(DocumentModel.Properties.HyperlinkList? value)
  {
    if (value != null)
    {
      var openXmlElement = new DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList();
      SetValue(openXmlElement, value);
      return openXmlElement;
    }
    return null;
  }
}
