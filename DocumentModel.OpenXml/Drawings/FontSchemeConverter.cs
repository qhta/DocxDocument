namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Font Scheme.
/// </summary>
public static class FontSchemeConverter
{
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DXD.FontScheme openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXD.FontScheme openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXD.FontScheme openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Major Font.
  /// </summary>
  private static DMD.MajorFont? GetMajorFont(DXD.FontScheme openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.MajorFont>();
    if (element != null)
      return DMXD.MajorFontConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMajorFont(DXD.FontScheme openXmlElement, DMD.MajorFont? value, DiffList? diffs, string? objName)
  {
    return DMXD.MajorFontConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.MajorFont>(), value, diffs, objName);
  }
  
  private static void SetMajorFont(DXD.FontScheme openXmlElement, DMD.MajorFont? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.MajorFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.MajorFontConverter.CreateOpenXmlElement<DXD.MajorFont>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Minor fonts.
  /// </summary>
  private static DMD.MinorFont? GetMinorFont(DXD.FontScheme openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.MinorFont>();
    if (element != null)
      return DMXD.MinorFontConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMinorFont(DXD.FontScheme openXmlElement, DMD.MinorFont? value, DiffList? diffs, string? objName)
  {
    return DMXD.MinorFontConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.MinorFont>(), value, diffs, objName);
  }
  
  private static void SetMinorFont(DXD.FontScheme openXmlElement, DMD.MinorFont? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.MinorFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.MinorFontConverter.CreateOpenXmlElement<DXD.MinorFont>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMD.ExtensionList? GetExtensionList(DXD.FontScheme openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXD.FontScheme openXmlElement, DMD.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXD.FontScheme openXmlElement, DMD.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.FontScheme? CreateModelElement(DXD.FontScheme? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.FontScheme();
      value.Name = GetName(openXmlElement);
      value.MajorFont = GetMajorFont(openXmlElement);
      value.MinorFont = GetMinorFont(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.FontScheme? openXmlElement, DMD.FontScheme? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpMajorFont(openXmlElement, value.MajorFont, diffs, objName))
        ok = false;
      if (!CmpMinorFont(openXmlElement, value.MinorFont, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.FontScheme value)
    where OpenXmlElementType: DXD.FontScheme, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.FontScheme openXmlElement, DMD.FontScheme value)
  {
    SetName(openXmlElement, value?.Name);
    SetMajorFont(openXmlElement, value?.MajorFont);
    SetMinorFont(openXmlElement, value?.MinorFont);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
