namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the MultiLevelStringCache Class.
/// </summary>
public static class MultiLevelStringCacheConverter
{
  /// <summary>
  /// PointCount.
  /// </summary>
  private static UInt32? GetPointCount(DXDrawCharts.MultiLevelStringCache openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.PointCount>()?.Val?.Value;
  }
  
  private static bool CmpPointCount(DXDrawCharts.MultiLevelStringCache openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.PointCount>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDrawCharts.PointCount", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetPointCount(DXDrawCharts.MultiLevelStringCache openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.PointCount>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.PointCount{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDrawsCharts.Level> GetLevels(DXDrawCharts.MultiLevelStringCache openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.Level>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.Level>())
    {
      var newItem = DMXDrawsCharts.LevelConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpLevels(DXDrawCharts.MultiLevelStringCache openXmlElement, Collection<DMDrawsCharts.Level>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.Level>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDrawsCharts.LevelConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetLevels(DXDrawCharts.MultiLevelStringCache openXmlElement, Collection<DMDrawsCharts.Level>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.Level>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.LevelConverter.CreateOpenXmlElement<DXDrawCharts.Level>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.MultiLevelStringCache openXmlElement)
  {
    return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDrawCharts.MultiLevelStringCache openXmlElement, DMDrawsCharts.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawCharts.MultiLevelStringCache openXmlElement, DMDrawsCharts.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.MultiLevelStringCache? CreateModelElement(DXDrawCharts.MultiLevelStringCache? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.MultiLevelStringCache();
      value.PointCount = GetPointCount(openXmlElement);
      value.Levels = GetLevels(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.MultiLevelStringCache? openXmlElement, DMDrawsCharts.MultiLevelStringCache? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPointCount(openXmlElement, value.PointCount, diffs, objName))
        ok = false;
      if (!CmpLevels(openXmlElement, value.Levels, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.MultiLevelStringCache? value)
    where OpenXmlElementType: DXDrawCharts.MultiLevelStringCache, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPointCount(openXmlElement, value?.PointCount);
      SetLevels(openXmlElement, value?.Levels);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
