namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public static class ExtensionListConverter
{
  private static Collection<DMDraws.Extension> GetExtensions(DXDraw.ExtensionList openXmlElement)
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
  
  private static bool CmpExtensions(DXDraw.ExtensionList openXmlElement, Collection<DMDraws.Extension>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetExtensions(DXDraw.ExtensionList openXmlElement, Collection<DMDraws.Extension>? value)
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
  
  public static DMDraws.ExtensionList? CreateModelElement(DXDraw.ExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ExtensionList();
      value.Extensions = GetExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.ExtensionList? openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ExtensionList? value)
    where OpenXmlElementType: DXDraw.ExtensionList, new()
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
