namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StringReference Class.
/// </summary>
public static class StringReferenceConverter
{
  /// <summary>
  /// Formula.
  /// </summary>
  private static String? GetFormula(DXDC.StringReference openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDC.Formula>()?.Text;
  }
  
  private static bool CmpFormula(DXDC.StringReference openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXDC.Formula>()?.Text == value;
  }
  
  private static void SetFormula(DXDC.StringReference openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Formula>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDC.Formula { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// StringCache.
  /// </summary>
  private static DMDC.StringCache? GetStringCache(DXDC.StringReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.StringCache>();
    if (element != null)
      return DMXDC.StringCacheConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStringCache(DXDC.StringReference openXmlElement, DMDC.StringCache? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.StringCacheConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.StringCache>(), value, diffs, objName, propName);
  }
  
  private static void SetStringCache(DXDC.StringReference openXmlElement, DMDC.StringCache? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.StringCache>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.StringCacheConverter.CreateOpenXmlElement<DXDC.StringCache>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// StrRefExtensionList.
  /// </summary>
  private static DMDC.StrRefExtensionList? GetStrRefExtensionList(DXDC.StringReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.StrRefExtensionList>();
    if (element != null)
      return DMXDC.StrRefExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStrRefExtensionList(DXDC.StringReference openXmlElement, DMDC.StrRefExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.StrRefExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.StrRefExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetStrRefExtensionList(DXDC.StringReference openXmlElement, DMDC.StrRefExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.StrRefExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.StrRefExtensionListConverter.CreateOpenXmlElement<DXDC.StrRefExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.StringReference? CreateModelElement(DXDC.StringReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.StringReference();
      value.Formula = GetFormula(openXmlElement);
      value.StringCache = GetStringCache(openXmlElement);
      value.StrRefExtensionList = GetStrRefExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.StringReference? openXmlElement, DMDC.StringReference? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFormula(openXmlElement, value.Formula, diffs, objName, propName))
        ok = false;
      if (!CmpStringCache(openXmlElement, value.StringCache, diffs, objName, propName))
        ok = false;
      if (!CmpStrRefExtensionList(openXmlElement, value.StrRefExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.StringReference value)
    where OpenXmlElementType: DXDC.StringReference, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.StringReference openXmlElement, DMDC.StringReference value)
  {
    SetFormula(openXmlElement, value?.Formula);
    SetStringCache(openXmlElement, value?.StringCache);
    SetStrRefExtensionList(openXmlElement, value?.StrRefExtensionList);
  }
}
