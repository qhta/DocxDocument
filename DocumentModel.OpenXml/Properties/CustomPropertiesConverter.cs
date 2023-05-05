using DocumentModel;

namespace DocumentModel.OpenXml.Properties;

/// <summary>
///   Custom File Properties.
/// </summary>
public static class CustomPropertiesConverter
{
  public static Collection<DocumentProperty>? GetCustomDocumentProperties(DXCP.Properties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<DocumentProperty>();
      foreach (var item in openXmlElement.Elements<DXCP.CustomDocumentProperty>())
      {
        var newItem = CustomDocumentPropertyConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetCustomDocumentProperties(DXCP.Properties? openXmlElement, Collection<DocumentProperty>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DXCP.CustomDocumentProperty>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = CustomDocumentPropertyConverter.CreateOpenXmlElement(item);
          if (newItem != null)
            openXmlElement.Append(newItem);
        }
    }
  }

  public static CustomProperties? CreateModelElement(DXCP.Properties? openXmlElement)
  {
    var value = new CustomProperties();
    if (openXmlElement != null) value.CustomDocumentProperties = GetCustomDocumentProperties(openXmlElement);
    return value;
  }

  public static void SetValue(DXCP.Properties? openXmlElement, CustomProperties? value)
  {
    if (openXmlElement != null) SetCustomDocumentProperties(openXmlElement, value?.CustomDocumentProperties);
  }

  public static DXCP.Properties? CreateOpenXmlElement(CustomProperties? value)
  {
    if (value != null)
    {
      var openXmlElement = new DXCP.Properties();
      SetValue(openXmlElement, value);
      return openXmlElement;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(CustomProperties? value)
    where OpenXmlElementType : DXCP.Properties, new()
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