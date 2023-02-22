namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Multi Level String Reference.
/// </summary>
public static class MultiLevelStringReferenceConverter
{
  /// <summary>
  /// Formula.
  /// </summary>
  private static String? GetFormula(DXDrawCharts.MultiLevelStringReference openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.Formula>()?.Text;
  }
  
  private static bool CmpFormula(DXDrawCharts.MultiLevelStringReference openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.Formula>()?.Text == value;
  }
  
  private static void SetFormula(DXDrawCharts.MultiLevelStringReference openXmlElement, String? value)
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
  /// MultiLevelStringCache.
  /// </summary>
  private static DMDrawsCharts.MultiLevelStringCache? GetMultiLevelStringCache(DXDrawCharts.MultiLevelStringReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.MultiLevelStringCache>();
    if (element != null)
      return DMXDrawsCharts.MultiLevelStringCacheConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMultiLevelStringCache(DXDrawCharts.MultiLevelStringReference openXmlElement, DMDrawsCharts.MultiLevelStringCache? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.MultiLevelStringCacheConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.MultiLevelStringCache>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMultiLevelStringCache(DXDrawCharts.MultiLevelStringReference openXmlElement, DMDrawsCharts.MultiLevelStringCache? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.MultiLevelStringCache>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.MultiLevelStringCacheConverter.CreateOpenXmlElement<DXDrawCharts.MultiLevelStringCache>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// MultiLvlStrRefExtensionList.
  /// </summary>
  private static DMDrawsCharts.MultiLvlStrRefExtensionList? GetMultiLvlStrRefExtensionList(DXDrawCharts.MultiLevelStringReference openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.MultiLvlStrRefExtensionList>();
    if (element != null)
      return DMXDrawsCharts.MultiLvlStrRefExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMultiLvlStrRefExtensionList(DXDrawCharts.MultiLevelStringReference openXmlElement, DMDrawsCharts.MultiLvlStrRefExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.MultiLvlStrRefExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.MultiLvlStrRefExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMultiLvlStrRefExtensionList(DXDrawCharts.MultiLevelStringReference openXmlElement, DMDrawsCharts.MultiLvlStrRefExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.MultiLvlStrRefExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.MultiLvlStrRefExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.MultiLvlStrRefExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.MultiLevelStringReference? CreateModelElement(DXDrawCharts.MultiLevelStringReference? openXmlElement)
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
  
  public static bool CompareModelElement(DXDrawCharts.MultiLevelStringReference? openXmlElement, DMDrawsCharts.MultiLevelStringReference? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFormula(openXmlElement, value.Formula, diffs, objName))
        ok = false;
      if (!CmpMultiLevelStringCache(openXmlElement, value.MultiLevelStringCache, diffs, objName))
        ok = false;
      if (!CmpMultiLvlStrRefExtensionList(openXmlElement, value.MultiLvlStrRefExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.MultiLevelStringReference value)
    where OpenXmlElementType: DXDrawCharts.MultiLevelStringReference, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.MultiLevelStringReference openXmlElement, DMDrawsCharts.MultiLevelStringReference value)
  {
    SetFormula(openXmlElement, value?.Formula);
    SetMultiLevelStringCache(openXmlElement, value?.MultiLevelStringCache);
    SetMultiLvlStrRefExtensionList(openXmlElement, value?.MultiLvlStrRefExtensionList);
    }
  }
