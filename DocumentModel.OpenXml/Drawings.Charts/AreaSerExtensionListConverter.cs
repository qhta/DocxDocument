namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the AreaSerExtensionList Class.
/// </summary>
public static class AreaSerExtensionListConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.AreaSerExtension> GetAreaSerExtensions(DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtensionList openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.AreaSerExtension>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtension>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.Charts.AreaSerExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetAreaSerExtensions(DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtensionList openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.AreaSerExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.AreaSerExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.AreaSerExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.AreaSerExtensionList();
      value.AreaSerExtensions = GetAreaSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.AreaSerExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAreaSerExtensions(openXmlElement, value?.AreaSerExtensions);
      return openXmlElement;
    }
    return default;
  }
}
