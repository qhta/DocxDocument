namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StringReference Class.
/// </summary>
public static class StringReferenceConverter
{
  /// <summary>
  /// Formula.
  /// </summary>
  private static String? GetFormula(DXDrawCharts.StringReference openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.Formula>()?.Text;
  }
  
  private static bool CmpFormula(DXDrawCharts.StringReference openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.Formula>()?.Text == value;
  }
  
  private static void SetFormula(DXDrawCharts.StringReference openXmlElement, String? value)
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
  /// StringCache.
  /// </summary>
  private static DMDrawsCharts.StringCache? GetStringCache(DXDrawCharts.StringReference openXmlElement)
  {
    return DMXDrawsCharts.StringCacheConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.StringCache>());
  }
  
  private static bool CmpStringCache(DXDrawCharts.StringReference openXmlElement, DMDrawsCharts.StringCache? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.StringCacheConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.StringCache>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStringCache(DXDrawCharts.StringReference openXmlElement, DMDrawsCharts.StringCache? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.StringCache>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.StringCacheConverter.CreateOpenXmlElement<DXDrawCharts.StringCache>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// StrRefExtensionList.
  /// </summary>
  private static DMDrawsCharts.StrRefExtensionList? GetStrRefExtensionList(DXDrawCharts.StringReference openXmlElement)
  {
    return DMXDrawsCharts.StrRefExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.StrRefExtensionList>());
  }
  
  private static bool CmpStrRefExtensionList(DXDrawCharts.StringReference openXmlElement, DMDrawsCharts.StrRefExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.StrRefExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.StrRefExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStrRefExtensionList(DXDrawCharts.StringReference openXmlElement, DMDrawsCharts.StrRefExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.StrRefExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.StrRefExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.StrRefExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.StringReference? CreateModelElement(DXDrawCharts.StringReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.StringReference();
      value.Formula = GetFormula(openXmlElement);
      value.StringCache = GetStringCache(openXmlElement);
      value.StrRefExtensionList = GetStrRefExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.StringReference? openXmlElement, DMDrawsCharts.StringReference? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFormula(openXmlElement, value.Formula, diffs, objName))
        ok = false;
      if (!CmpStringCache(openXmlElement, value.StringCache, diffs, objName))
        ok = false;
      if (!CmpStrRefExtensionList(openXmlElement, value.StrRefExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.StringReference? value)
    where OpenXmlElementType: DXDrawCharts.StringReference, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFormula(openXmlElement, value?.Formula);
      SetStringCache(openXmlElement, value?.StringCache);
      SetStrRefExtensionList(openXmlElement, value?.StrRefExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
