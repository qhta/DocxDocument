namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the CatAxExtensionList Class.
/// </summary>
public static class CatAxExtensionListConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.CatAxExtension> GetCatAxExtensions(DocumentFormat.OpenXml.Drawing.Charts.CatAxExtensionList openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.CatAxExtension>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.CatAxExtension>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.Charts.CatAxExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetCatAxExtensions(DocumentFormat.OpenXml.Drawing.Charts.CatAxExtensionList openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.CatAxExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.CatAxExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.CatAxExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.CatAxExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.CatAxExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.CatAxExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.CatAxExtensionList();
      value.CatAxExtensions = GetCatAxExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.CatAxExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.CatAxExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCatAxExtensions(openXmlElement, value?.CatAxExtensions);
      return openXmlElement;
    }
    return default;
  }
}
