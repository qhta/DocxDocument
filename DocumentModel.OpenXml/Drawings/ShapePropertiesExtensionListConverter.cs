namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ShapePropertiesExtensionList Class.
/// </summary>
public static class ShapePropertiesExtensionListConverter
{
  private static Collection<DMDraws.ShapePropertiesExtension> GetShapePropertiesExtensions(DXDraw.ShapePropertiesExtensionList openXmlElement)
  {
    var collection = new Collection<DMDraws.ShapePropertiesExtension>();
    foreach (var item in openXmlElement.Elements<DXDraw.ShapePropertiesExtension>())
    {
      var newItem = DMXDraws.ShapePropertiesExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetShapePropertiesExtensions(DXDraw.ShapePropertiesExtensionList openXmlElement, Collection<DMDraws.ShapePropertiesExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.ShapePropertiesExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.ShapePropertiesExtensionConverter.CreateOpenXmlElement<DXDraw.ShapePropertiesExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDraws.ShapePropertiesExtensionList? CreateModelElement(DXDraw.ShapePropertiesExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ShapePropertiesExtensionList();
      value.ShapePropertiesExtensions = GetShapePropertiesExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ShapePropertiesExtensionList? value)
    where OpenXmlElementType: DXDraw.ShapePropertiesExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShapePropertiesExtensions(openXmlElement, value?.ShapePropertiesExtensions);
      return openXmlElement;
    }
    return default;
  }
}
