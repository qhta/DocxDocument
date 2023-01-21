namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the OfficeArtExtensionList Class.
/// </summary>
public static class OfficeArtExtensionListConverter
{
  private static Collection<DMDraws.Extension> GetExtensions(DXO2021DrawLivefeed.OfficeArtExtensionList openXmlElement)
  {
    var collection = new Collection<DMDraws.Extension>();
    foreach (var item in openXmlElement.Elements<DXDraw.Extension>())
    {
      var newItem = DMXDraws.ExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetExtensions(DXO2021DrawLivefeed.OfficeArtExtensionList openXmlElement, Collection<DMDraws.Extension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.Extension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.ExtensionConverter.CreateOpenXmlElement<DXDraw.Extension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDraws.OfficeArtExtensionList? CreateModelElement(DXO2021DrawLivefeed.OfficeArtExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.OfficeArtExtensionList();
      value.Extensions = GetExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.OfficeArtExtensionList? value)
    where OpenXmlElementType: DXO2021DrawLivefeed.OfficeArtExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtensions(openXmlElement, value?.Extensions);
      return openXmlElement;
    }
    return default;
  }
}
