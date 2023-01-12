namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualGroupDrawingShapePropsExtensionList Class.
/// </summary>
public static class NonVisualGroupDrawingShapePropsExtensionListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtension>? GetNonVisualGroupDrawingShapePropsExtensions(DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtension>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.NonVisualGroupDrawingShapePropsExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetNonVisualGroupDrawingShapePropsExtensions(DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtension>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.NonVisualGroupDrawingShapePropsExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtensionList();
      value.NonVisualGroupDrawingShapePropsExtensions = GetNonVisualGroupDrawingShapePropsExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtensionList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
