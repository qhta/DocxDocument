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
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.CustomXmlPlaceholder = new DocumentFormat.OpenXml.Wordprocessing.CustomXmlPlaceholder { Val = value };
      else
        openXmlElement.CustomXmlPlaceholder = null;
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.CustomXmlAttribute>? GetCustomXmlAttributes(DocumentFormat.OpenXml.Wordprocessing.CustomXmlProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.CustomXmlAttribute>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.CustomXmlAttribute>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.CustomXmlAttributeConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetCustomXmlAttributes(DocumentFormat.OpenXml.Wordprocessing.CustomXmlProperties? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.CustomXmlAttribute>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.CustomXmlAttribute>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.CustomXmlAttributeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlAttribute>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.CustomXmlProperties? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.CustomXmlProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.CustomXmlProperties();
      value.CustomXmlPlaceholder = GetCustomXmlPlaceholder(openXmlElement);
      value.CustomXmlAttributes = GetCustomXmlAttributes(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.CustomXmlProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.CustomXmlProperties, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
