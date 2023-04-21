namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Number Reference.
/// </summary>
public static class NumberReferenceConverter
{
  /// <summary>
  /// Formula.
  /// </summary>
  private static String? GetFormula(DXDC.NumberReference openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDC.Formula>()?.Text;
  }
  
  private static bool CmpFormula(DXDC.NumberReference openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDC.Formula>()?.Text == value;
  }
  
  private static void SetFormula(DXDC.NumberReference openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Formula>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDC.Formula { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NumberingCache.
  /// </summary>
  private static DMDC.NumberingCache? GetNumberingCache(DXDC.NumberReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.NumberingCache>();
    if (element != null)
      return DMXDC.NumberingCacheConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberingCache(DXDC.NumberReference openXmlElement, DMDC.NumberingCache? value, DiffList? diffs, string? objName)
  {
    return DMXDC.NumberingCacheConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.NumberingCache>(), value, diffs, objName);
  }
  
  private static void SetNumberingCache(DXDC.NumberReference openXmlElement, DMDC.NumberingCache? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.NumberingCache>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.NumberingCacheConverter.CreateOpenXmlElement<DXDC.NumberingCache>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NumRefExtensionList.
  /// </summary>
  private static DMDC.NumRefExtensionList? GetNumRefExtensionList(DXDC.NumberReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.NumRefExtensionList>();
    if (element != null)
      return DMXDC.NumRefExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumRefExtensionList(DXDC.NumberReference openXmlElement, DMDC.NumRefExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDC.NumRefExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.NumRefExtensionList>(), value, diffs, objName);
  }
  
  private static void SetNumRefExtensionList(DXDC.NumberReference openXmlElement, DMDC.NumRefExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.NumRefExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.NumRefExtensionListConverter.CreateOpenXmlElement<DXDC.NumRefExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.NumberReference? CreateModelElement(DXDC.NumberReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.NumberReference();
      value.Formula = GetFormula(openXmlElement);
      value.NumberingCache = GetNumberingCache(openXmlElement);
      value.NumRefExtensionList = GetNumRefExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.NumberReference? openXmlElement, DMDC.NumberReference? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFormula(openXmlElement, value.Formula, diffs, objName))
        ok = false;
      if (!CmpNumberingCache(openXmlElement, value.NumberingCache, diffs, objName))
        ok = false;
      if (!CmpNumRefExtensionList(openXmlElement, value.NumRefExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.NumberReference value)
    where OpenXmlElementType: DXDC.NumberReference, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.NumberReference openXmlElement, DMDC.NumberReference value)
  {
    SetFormula(openXmlElement, value?.Formula);
    SetNumberingCache(openXmlElement, value?.NumberingCache);
    SetNumRefExtensionList(openXmlElement, value?.NumRefExtensionList);
  }
}
