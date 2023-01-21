namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualPicturePropertiesExtensionList Class.
/// </summary>
public static class NonVisualPicturePropertiesExtensionListConverter
{
  private static Collection<DMDraws.NonVisualPicturePropertiesExtension> GetNonVisualPicturePropertiesExtensions(DXDraw.NonVisualPicturePropertiesExtensionList openXmlElement)
  {
    var collection = new Collection<DMDraws.NonVisualPicturePropertiesExtension>();
    foreach (var item in openXmlElement.Elements<DXDraw.NonVisualPicturePropertiesExtension>())
    {
      var newItem = DMXDraws.NonVisualPicturePropertiesExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetNonVisualPicturePropertiesExtensions(DXDraw.NonVisualPicturePropertiesExtensionList openXmlElement, Collection<DMDraws.NonVisualPicturePropertiesExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.NonVisualPicturePropertiesExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.NonVisualPicturePropertiesExtensionConverter.CreateOpenXmlElement<DXDraw.NonVisualPicturePropertiesExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDraws.NonVisualPicturePropertiesExtensionList? CreateModelElement(DXDraw.NonVisualPicturePropertiesExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.NonVisualPicturePropertiesExtensionList();
      value.NonVisualPicturePropertiesExtensions = GetNonVisualPicturePropertiesExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.NonVisualPicturePropertiesExtensionList? value)
    where OpenXmlElementType: DXDraw.NonVisualPicturePropertiesExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualPicturePropertiesExtensions(openXmlElement, value?.NonVisualPicturePropertiesExtensions);
      return openXmlElement;
    }
    return default;
  }
}
