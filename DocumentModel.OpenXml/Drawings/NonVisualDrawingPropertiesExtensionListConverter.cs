namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualDrawingPropertiesExtensionList Class.
/// </summary>
public static class NonVisualDrawingPropertiesExtensionListConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.NonVisualDrawingPropertiesExtension> GetNonVisualDrawingPropertiesExtensions(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.NonVisualDrawingPropertiesExtension>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.NonVisualDrawingPropertiesExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetNonVisualDrawingPropertiesExtensions(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.NonVisualDrawingPropertiesExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.NonVisualDrawingPropertiesExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.NonVisualDrawingPropertiesExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.NonVisualDrawingPropertiesExtensionList();
      value.NonVisualDrawingPropertiesExtensions = GetNonVisualDrawingPropertiesExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.NonVisualDrawingPropertiesExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualDrawingPropertiesExtensions(openXmlElement, value?.NonVisualDrawingPropertiesExtensions);
      return openXmlElement;
    }
    return default;
  }
}
