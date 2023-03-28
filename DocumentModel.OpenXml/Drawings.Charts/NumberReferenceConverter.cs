namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Number Reference converter from/to OpenXml.
///</summary>
public static class NumberReferenceConverter
{
  /// <summary>
  /// Formula.
  /// </summary>
  private static String? GetFormula(DXDrawCharts.NumberReference openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.Formula>()?.Text;
  }
  
  private static bool CmpFormula(DXDrawCharts.NumberReference openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.Formula>()?.Text == value;
  }
  
  private static void SetFormula(DXDrawCharts.NumberReference openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Formula>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.Formula { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NumberingCache.
  /// </summary>
  private static DMDrawsCharts.NumberingCache? GetNumberingCache(DXDrawCharts.NumberReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.NumberingCache>();
    if (element != null)
      return DMXDrawsCharts.NumberingCacheConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberingCache(DXDrawCharts.NumberReference openXmlElement, DMDrawsCharts.NumberingCache? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.NumberingCacheConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.NumberingCache>(), value, diffs, objName);
  }
  
  private static void SetNumberingCache(DXDrawCharts.NumberReference openXmlElement, DMDrawsCharts.NumberingCache? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.NumberingCache>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.NumberingCacheConverter.CreateOpenXmlElement<DXDrawCharts.NumberingCache>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NumRefExtensionList.
  /// </summary>
  private static DMDrawsCharts.NumRefExtensionList? GetNumRefExtensionList(DXDrawCharts.NumberReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.NumRefExtensionList>();
    if (element != null)
      return DMXDrawsCharts.NumRefExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumRefExtensionList(DXDrawCharts.NumberReference openXmlElement, DMDrawsCharts.NumRefExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.NumRefExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.NumRefExtensionList>(), value, diffs, objName);
  }
  
  private static void SetNumRefExtensionList(DXDrawCharts.NumberReference openXmlElement, DMDrawsCharts.NumRefExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.NumRefExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.NumRefExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.NumRefExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.NumberReference? CreateModelElement(DXDrawCharts.NumberReference? openXmlElement)
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
  
  public static bool CompareModelElement(DXDrawCharts.NumberReference? openXmlElement, DMDrawsCharts.NumberReference? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.NumberReference value)
    where OpenXmlElementType: DXDrawCharts.NumberReference, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.NumberReference openXmlElement, DMDrawsCharts.NumberReference value)
  {
    SetFormula(openXmlElement, value?.Formula);
    SetNumberingCache(openXmlElement, value?.NumberingCache);
    SetNumRefExtensionList(openXmlElement, value?.NumRefExtensionList);
  }
}
