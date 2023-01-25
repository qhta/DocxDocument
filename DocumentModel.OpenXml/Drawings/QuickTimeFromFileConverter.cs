namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// QuickTime from File.
/// </summary>
public static class QuickTimeFromFileConverter
{
  /// <summary>
  /// Linked Relationship ID
  /// </summary>
  private static String? GetLink(DXDraw.QuickTimeFromFile openXmlElement)
  {
    return openXmlElement?.Link?.Value;
  }
  
  private static bool CmpLink(DXDraw.QuickTimeFromFile openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Link?.Value == value;
  }
  
  private static void SetLink(DXDraw.QuickTimeFromFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Link = new StringValue { Value = value };
    else
      openXmlElement.Link = null;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.QuickTimeFromFile openXmlElement)
  {
    return DMXDraws.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDraw.QuickTimeFromFile openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDraw.QuickTimeFromFile openXmlElement, DMDraws.ExtensionList? value)
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
  
  public static DMDraws.QuickTimeFromFile? CreateModelElement(DXDraw.QuickTimeFromFile? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.QuickTimeFromFile();
      value.Link = GetLink(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.QuickTimeFromFile? openXmlElement, DMDraws.QuickTimeFromFile? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.QuickTimeFromFile? value)
    where OpenXmlElementType: DXDraw.QuickTimeFromFile, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLink(openXmlElement, value?.Link);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
