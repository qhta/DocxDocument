namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualDrawingPropertiesExtensionList Class.
/// </summary>
public static class NonVisualDrawingPropertiesExtensionListConverter
{
  private static Collection<DMDraws.NonVisualDrawingPropertiesExtension> GetNonVisualDrawingPropertiesExtensions(DXDraw.NonVisualDrawingPropertiesExtensionList openXmlElement)
  {
    var collection = new Collection<DMDraws.NonVisualDrawingPropertiesExtension>();
    foreach (var item in openXmlElement.Elements<DXDraw.NonVisualDrawingPropertiesExtension>())
    {
      var newItem = DMXDraws.NonVisualDrawingPropertiesExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpNonVisualDrawingPropertiesExtensions(DXDraw.NonVisualDrawingPropertiesExtensionList openXmlElement, Collection<DMDraws.NonVisualDrawingPropertiesExtension>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetNonVisualDrawingPropertiesExtensions(DXDraw.NonVisualDrawingPropertiesExtensionList openXmlElement, Collection<DMDraws.NonVisualDrawingPropertiesExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.NonVisualDrawingPropertiesExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.NonVisualDrawingPropertiesExtensionConverter.CreateOpenXmlElement<DXDraw.NonVisualDrawingPropertiesExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDraws.NonVisualDrawingPropertiesExtensionList? CreateModelElement(DXDraw.NonVisualDrawingPropertiesExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.NonVisualDrawingPropertiesExtensionList();
      value.NonVisualDrawingPropertiesExtensions = GetNonVisualDrawingPropertiesExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.NonVisualDrawingPropertiesExtensionList? openXmlElement, DMDraws.NonVisualDrawingPropertiesExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNonVisualDrawingPropertiesExtensions(openXmlElement, value.NonVisualDrawingPropertiesExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.NonVisualDrawingPropertiesExtensionList? value)
    where OpenXmlElementType: DXDraw.NonVisualDrawingPropertiesExtensionList, new()
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
