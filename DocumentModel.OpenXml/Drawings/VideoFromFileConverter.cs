namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Video from File converter from/to OpenXml.
///</summary>
public static class VideoFromFileConverter
{
  /// <summary>
  /// Linked Relationship ID
  /// </summary>
  private static String? GetLink(DXDraw.VideoFromFile openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Link);
  }
  
  private static bool CmpLink(DXDraw.VideoFromFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Link, value, diffs, objName, "Link");
  }
  
  private static void SetLink(DXDraw.VideoFromFile openXmlElement, String? value)
  {
    openXmlElement.Link = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.VideoFromFile openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (element != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDraw.VideoFromFile openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXDraw.VideoFromFile openXmlElement, DMDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ExtensionListConverter.CreateOpenXmlElement<DXDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.VideoFromFile? CreateModelElement(DXDraw.VideoFromFile? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.VideoFromFile();
      value.Link = GetLink(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.VideoFromFile? openXmlElement, DMDraws.VideoFromFile? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLink(openXmlElement, value.Link, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.VideoFromFile value)
    where OpenXmlElementType: DXDraw.VideoFromFile, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.VideoFromFile openXmlElement, DMDraws.VideoFromFile value)
  {
    SetLink(openXmlElement, value?.Link);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
