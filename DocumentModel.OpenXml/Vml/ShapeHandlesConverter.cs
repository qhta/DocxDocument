namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the ShapeHandles Class.
/// </summary>
public static class ShapeHandlesConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.Vml.ShapeHandle> GetItems(DocumentFormat.OpenXml.Vml.ShapeHandles openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Vml.ShapeHandle>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Vml.ShapeHandle>())
    {
      var newItem = DocumentModel.OpenXml.Vml.ShapeHandleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetItems(DocumentFormat.OpenXml.Vml.ShapeHandles openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Vml.ShapeHandle>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Vml.ShapeHandle>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Vml.ShapeHandleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.ShapeHandle>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Vml.ShapeHandles? CreateModelElement(DocumentFormat.OpenXml.Vml.ShapeHandles? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.ShapeHandles();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.ShapeHandles? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.ShapeHandles, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}
