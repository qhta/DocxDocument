namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the OfficeArtExtensionList Class.
/// </summary>
public static class OfficeArtExtensionList2Converter
{
  private static Collection<DMDraws.Extension> GetExtensions(DXO2010Draw.OfficeArtExtensionList openXmlElement)
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
  
  private static bool CmpExtensions(DXO2010Draw.OfficeArtExtensionList openXmlElement, Collection<DMDraws.Extension>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetExtensions(DXO2010Draw.OfficeArtExtensionList openXmlElement, Collection<DMDraws.Extension>? value)
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
  
  public static DMDraws.OfficeArtExtensionList2? CreateModelElement(DXO2010Draw.OfficeArtExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.OfficeArtExtensionList2();
      value.Extensions = GetExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010Draw.OfficeArtExtensionList? openXmlElement, DMDraws.OfficeArtExtensionList2? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtensions(openXmlElement, value.Extensions, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.OfficeArtExtensionList2? value)
    where OpenXmlElementType: DXO2010Draw.OfficeArtExtensionList, new()
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
