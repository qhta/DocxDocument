namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Future extensions..
/// </summary>
public static class LinePropertiesExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.LinePropertiesExtension>? GetLinePropertiesExtensions(DocumentFormat.OpenXml.Drawing.LinePropertiesExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.LinePropertiesExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.LinePropertiesExtension>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.LinePropertiesExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetLinePropertiesExtensions(DocumentFormat.OpenXml.Drawing.LinePropertiesExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.LinePropertiesExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.LinePropertiesExtension>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.LinePropertiesExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LinePropertiesExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.LinePropertiesExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.LinePropertiesExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LinePropertiesExtensionList();
      value.LinePropertiesExtensions = GetLinePropertiesExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.LinePropertiesExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.LinePropertiesExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLinePropertiesExtensions(openXmlElement, value?.LinePropertiesExtensions);
      return openXmlElement;
    }
    return default;
  }
}
