namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualGroupDrawingShapePropsExtensionList Class.
/// </summary>
public static class NonVisualGroupDrawingShapePropsExtensionListConverter
{
  private static Collection<DMDraws.NonVisualGroupDrawingShapePropsExtension> GetNonVisualGroupDrawingShapePropsExtensions(DXDraw.NonVisualGroupDrawingShapePropsExtensionList openXmlElement)
  {
    var collection = new Collection<DMDraws.NonVisualGroupDrawingShapePropsExtension>();
    foreach (var item in openXmlElement.Elements<DXDraw.NonVisualGroupDrawingShapePropsExtension>())
    {
      var newItem = DMXDraws.NonVisualGroupDrawingShapePropsExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetNonVisualGroupDrawingShapePropsExtensions(DXDraw.NonVisualGroupDrawingShapePropsExtensionList openXmlElement, Collection<DMDraws.NonVisualGroupDrawingShapePropsExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.NonVisualGroupDrawingShapePropsExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.NonVisualGroupDrawingShapePropsExtensionConverter.CreateOpenXmlElement<DXDraw.NonVisualGroupDrawingShapePropsExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDraws.NonVisualGroupDrawingShapePropsExtensionList? CreateModelElement(DXDraw.NonVisualGroupDrawingShapePropsExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.NonVisualGroupDrawingShapePropsExtensionList();
      value.NonVisualGroupDrawingShapePropsExtensions = GetNonVisualGroupDrawingShapePropsExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.NonVisualGroupDrawingShapePropsExtensionList? value)
    where OpenXmlElementType: DXDraw.NonVisualGroupDrawingShapePropsExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualGroupDrawingShapePropsExtensions(openXmlElement, value?.NonVisualGroupDrawingShapePropsExtensions);
      return openXmlElement;
    }
    return default;
  }
}
