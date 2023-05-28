namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Audio from File.
/// </summary>
public static class AudioFromFileConverter
{
  /// <summary>
  /// Linked Relationship ID
  /// </summary>
  private static String? GetLink(DXD.AudioFromFile openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Link);
  }
  
  private static bool CmpLink(DXD.AudioFromFile openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Link, value, diffs, objName, "Link");
  }
  
  private static void SetLink(DXD.AudioFromFile openXmlElement, String? value)
  {
    openXmlElement.Link = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMD.ExtensionList? GetExtensionList(DXD.AudioFromFile openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXD.AudioFromFile openXmlElement, DMD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXD.AudioFromFile openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.AudioFromFile? CreateModelElement(DXD.AudioFromFile? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.AudioFromFile();
      value.Link = GetLink(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.AudioFromFile? openXmlElement, DMD.AudioFromFile? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLink(openXmlElement, value.Link, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.AudioFromFile value)
    where OpenXmlElementType: DXD.AudioFromFile, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.AudioFromFile openXmlElement, DMD.AudioFromFile value)
  {
    SetLink(openXmlElement, value?.Link);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
