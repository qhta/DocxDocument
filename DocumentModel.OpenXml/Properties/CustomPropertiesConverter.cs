namespace DocumentModel.OpenXml.Properties;

/// <summary>
/// Custom File Properties.
/// </summary>
public static class CustomPropertiesConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Properties.CustomDocumentProperty>? GetCustomDocumentProperties(DocumentFormat.OpenXml.CustomProperties.Properties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Properties.CustomDocumentProperty>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty>())
      {
        var newItem = DocumentModel.OpenXml.Properties.CustomDocumentPropertyConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetCustomDocumentProperties(DocumentFormat.OpenXml.CustomProperties.Properties? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Properties.CustomDocumentProperty>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Properties.CustomDocumentPropertyConverter.CreateOpenXmlElement(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Properties.CustomProperties? GetValue(DocumentFormat.OpenXml.CustomProperties.Properties? openXmlElement)
  {
    var value = new DocumentModel.Properties.CustomProperties();
    if (openXmlElement != null)
    {
      value.CustomDocumentProperties = GetCustomDocumentProperties(openXmlElement);
    }
    return value;
  }
  
  public static void SetValue(DocumentFormat.OpenXml.CustomProperties.Properties? openXmlElement, DocumentModel.Properties.CustomProperties? value)
  {
    if (openXmlElement != null)
    {
      SetCustomDocumentProperties(openXmlElement, value?.CustomDocumentProperties);
    }
  }
  
  public static DocumentFormat.OpenXml.CustomProperties.Properties? CreateOpenXmlElement(DocumentModel.Properties.CustomProperties? value)
  {
    if (value != null)
    {
      var openXmlElement = new DocumentFormat.OpenXml.CustomProperties.Properties();
      SetValue(openXmlElement, value);
      return openXmlElement;
    }
    return null;
  }
}
