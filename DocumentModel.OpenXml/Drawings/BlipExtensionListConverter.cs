namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Future extensions..
/// </summary>
public static class BlipExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.BlipExtension>? GetBlipExtensions(DocumentFormat.OpenXml.Drawing.BlipExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.BlipExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.BlipExtension>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.BlipExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetBlipExtensions(DocumentFormat.OpenXml.Drawing.BlipExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.BlipExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.BlipExtension>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.BlipExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BlipExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.BlipExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.BlipExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.BlipExtensionList();
      value.BlipExtensions = GetBlipExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.BlipExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.BlipExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
