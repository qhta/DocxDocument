namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Multi Level String Reference.
/// </summary>
public static class MultiLevelStringReferenceConverter
{
  /// <summary>
  /// Formula.
  /// </summary>
  private static String? GetFormula(DXDC.MultiLevelStringReference openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDC.Formula>()?.Text;
  }
  
  private static bool CmpFormula(DXDC.MultiLevelStringReference openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXDC.Formula>()?.Text == value;
  }
  
  private static void SetFormula(DXDC.MultiLevelStringReference openXmlElement, String? value)
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
  /// MultiLevelStringCache.
  /// </summary>
  private static DMDC.MultiLevelStringCache? GetMultiLevelStringCache(DXDC.MultiLevelStringReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.MultiLevelStringCache>();
    if (element != null)
      return DMXDC.MultiLevelStringCacheConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMultiLevelStringCache(DXDC.MultiLevelStringReference openXmlElement, DMDC.MultiLevelStringCache? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.MultiLevelStringCacheConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.MultiLevelStringCache>(), value, diffs, objName, propName);
  }
  
  private static void SetMultiLevelStringCache(DXDC.MultiLevelStringReference openXmlElement, DMDC.MultiLevelStringCache? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.MultiLevelStringCache>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.MultiLevelStringCacheConverter.CreateOpenXmlElement<DXDC.MultiLevelStringCache>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// MultiLvlStrRefExtensionList.
  /// </summary>
  private static DMDC.MultiLvlStrRefExtensionList? GetMultiLvlStrRefExtensionList(DXDC.MultiLevelStringReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.MultiLvlStrRefExtensionList>();
    if (element != null)
      return DMXDC.MultiLvlStrRefExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMultiLvlStrRefExtensionList(DXDC.MultiLevelStringReference openXmlElement, DMDC.MultiLvlStrRefExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.MultiLvlStrRefExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.MultiLvlStrRefExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetMultiLvlStrRefExtensionList(DXDC.MultiLevelStringReference openXmlElement, DMDC.MultiLvlStrRefExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.MultiLvlStrRefExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.MultiLvlStrRefExtensionListConverter.CreateOpenXmlElement<DXDC.MultiLvlStrRefExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.MultiLevelStringReference? CreateModelElement(DXDC.MultiLevelStringReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.MultiLevelStringReference();
      value.Formula = GetFormula(openXmlElement);
      value.MultiLevelStringCache = GetMultiLevelStringCache(openXmlElement);
      value.MultiLvlStrRefExtensionList = GetMultiLvlStrRefExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.MultiLevelStringReference? openXmlElement, DMDC.MultiLevelStringReference? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFormula(openXmlElement, value.Formula, diffs, objName, propName))
        ok = false;
      if (!CmpMultiLevelStringCache(openXmlElement, value.MultiLevelStringCache, diffs, objName, propName))
        ok = false;
      if (!CmpMultiLvlStrRefExtensionList(openXmlElement, value.MultiLvlStrRefExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.MultiLevelStringReference value)
    where OpenXmlElementType: DXDC.MultiLevelStringReference, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.MultiLevelStringReference openXmlElement, DMDC.MultiLevelStringReference value)
  {
    SetFormula(openXmlElement, value?.Formula);
    SetMultiLevelStringCache(openXmlElement, value?.MultiLevelStringCache);
    SetMultiLvlStrRefExtensionList(openXmlElement, value?.MultiLvlStrRefExtensionList);
  }
}
