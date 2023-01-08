namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Custom XML Element Properties.
/// </summary>
public static class CustomXmlPropertiesConverter
{
  /// <summary>
  /// Custom XML Element Placeholder Text.
  /// </summary>
  public static String? GetCustomXmlPlaceholder(DocumentFormat.OpenXml.Wordprocessing.CustomXmlProperties? openXmlElement)
  {
    return openXmlElement?.CustomXmlPlaceholder?.Val?.Value;
  }
  
  public static void SetCustomXmlPlaceholder(DocumentFormat.OpenXml.Wordprocessing.CustomXmlProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.CustomXmlAttribute>? GetCustomXmlAttributes(DocumentFormat.OpenXml.Wordprocessing.CustomXmlProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCustomXmlAttributes(DocumentFormat.OpenXml.Wordprocessing.CustomXmlProperties? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.CustomXmlAttribute>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
