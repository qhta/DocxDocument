using DocumentModel;

namespace DocumentModel.OpenXml.Properties;

/// <summary>
///   Custom File Properties.
/// </summary>
public static class CustomPropertiesConverter
{
  public static Collection<DocumentProperty>? GetCustomDocumentProperties(DocumentFormat.OpenXml.CustomProperties.Properties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<DocumentProperty>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty>())
      {
        var newItem = CustomDocumentPropertyConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetCustomDocumentProperties(DocumentFormat.OpenXml.CustomProperties.Properties? openXmlElement, Collection<DocumentProperty>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = CustomDocumentPropertyConverter.CreateOpenXmlElement(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static CustomProperties? CreateModelElement(DocumentFormat.OpenXml.CustomProperties.Properties? openXmlElement)
  {
    var value = new CustomProperties();
    if (openXmlElement != null) value.CustomDocumentProperties = GetCustomDocumentProperties(openXmlElement);
    return value;
  }

  public static void SetValue(DocumentFormat.OpenXml.CustomProperties.Properties? openXmlElement, CustomProperties? value)
  {
    if (openXmlElement != null) SetCustomDocumentProperties(openXmlElement, value?.CustomDocumentProperties);
  }

  public static DocumentFormat.OpenXml.CustomProperties.Properties? CreateOpenXmlElement(CustomProperties? value)
  {
    if (value != null)
    {
      var openXmlElement = new DocumentFormat.OpenXml.CustomProperties.Properties();
      SetValue(openXmlElement, value);
      return openXmlElement;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(CustomProperties? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.CustomProperties.Properties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetValue(openXmlElement, value);
      return openXmlElement;
    }
    return null;
  }
}