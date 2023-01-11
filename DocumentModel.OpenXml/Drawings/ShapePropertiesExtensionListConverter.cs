namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ShapePropertiesExtensionList Class.
/// </summary>
public static class ShapePropertiesExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ShapePropertiesExtension>? GetShapePropertiesExtensions(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ShapePropertiesExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.ShapePropertiesExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetShapePropertiesExtensions(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ShapePropertiesExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.ShapePropertiesExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.ShapePropertiesExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ShapePropertiesExtensionList();
      value.ShapePropertiesExtensions = GetShapePropertiesExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ShapePropertiesExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
