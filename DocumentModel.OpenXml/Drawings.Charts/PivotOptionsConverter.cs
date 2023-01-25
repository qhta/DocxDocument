namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PivotOptions Class.
/// </summary>
public static class PivotOptionsConverter
{
  /// <summary>
  /// DropZoneFilter.
  /// </summary>
  private static Boolean? GetDropZoneFilter(DXO2010DrawCharts.PivotOptions openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2010DrawCharts.DropZoneFilter>() != null;
  }
  
  private static bool CmpDropZoneFilter(DXO2010DrawCharts.PivotOptions openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXO2010DrawCharts.DropZoneFilter>() != null == value;
  }
  
  private static void SetDropZoneFilter(DXO2010DrawCharts.PivotOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2010DrawCharts.DropZoneFilter>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2010DrawCharts.DropZoneFilter();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DropZoneCategories.
  /// </summary>
  private static Boolean? GetDropZoneCategories(DXO2010DrawCharts.PivotOptions openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2010DrawCharts.DropZoneCategories>() != null;
  }
  
  private static bool CmpDropZoneCategories(DXO2010DrawCharts.PivotOptions openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXO2010DrawCharts.DropZoneCategories>() != null == value;
  }
  
  private static void SetDropZoneCategories(DXO2010DrawCharts.PivotOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2010DrawCharts.DropZoneCategories>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2010DrawCharts.DropZoneCategories();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DropZoneData.
  /// </summary>
  private static Boolean? GetDropZoneData(DXO2010DrawCharts.PivotOptions openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2010DrawCharts.DropZoneData>() != null;
  }
  
  private static bool CmpDropZoneData(DXO2010DrawCharts.PivotOptions openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXO2010DrawCharts.DropZoneData>() != null == value;
  }
  
  private static void SetDropZoneData(DXO2010DrawCharts.PivotOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2010DrawCharts.DropZoneData>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2010DrawCharts.DropZoneData();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DropZoneSeries.
  /// </summary>
  private static Boolean? GetDropZoneSeries(DXO2010DrawCharts.PivotOptions openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2010DrawCharts.DropZoneSeries>() != null;
  }
  
  private static bool CmpDropZoneSeries(DXO2010DrawCharts.PivotOptions openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXO2010DrawCharts.DropZoneSeries>() != null == value;
  }
  
  private static void SetDropZoneSeries(DXO2010DrawCharts.PivotOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2010DrawCharts.DropZoneSeries>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2010DrawCharts.DropZoneSeries();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DropZonesVisible.
  /// </summary>
  private static Boolean? GetDropZonesVisible(DXO2010DrawCharts.PivotOptions openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2010DrawCharts.DropZonesVisible>() != null;
  }
  
  private static bool CmpDropZonesVisible(DXO2010DrawCharts.PivotOptions openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXO2010DrawCharts.DropZonesVisible>() != null == value;
  }
  
  private static void SetDropZonesVisible(DXO2010DrawCharts.PivotOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2010DrawCharts.DropZonesVisible>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2010DrawCharts.DropZonesVisible();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.PivotOptions? CreateModelElement(DXO2010DrawCharts.PivotOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.PivotOptions();
      value.DropZoneFilter = GetDropZoneFilter(openXmlElement);
      value.DropZoneCategories = GetDropZoneCategories(openXmlElement);
      value.DropZoneData = GetDropZoneData(openXmlElement);
      value.DropZoneSeries = GetDropZoneSeries(openXmlElement);
      value.DropZonesVisible = GetDropZonesVisible(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010DrawCharts.PivotOptions? openXmlElement, DMDrawsCharts.PivotOptions? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDropZoneFilter(openXmlElement, value.DropZoneFilter, diffs, objName))
        ok = false;
      if (!CmpDropZoneCategories(openXmlElement, value.DropZoneCategories, diffs, objName))
        ok = false;
      if (!CmpDropZoneData(openXmlElement, value.DropZoneData, diffs, objName))
        ok = false;
      if (!CmpDropZoneSeries(openXmlElement, value.DropZoneSeries, diffs, objName))
        ok = false;
      if (!CmpDropZonesVisible(openXmlElement, value.DropZonesVisible, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.PivotOptions? value)
    where OpenXmlElementType: DXO2010DrawCharts.PivotOptions, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDropZoneFilter(openXmlElement, value?.DropZoneFilter);
      SetDropZoneCategories(openXmlElement, value?.DropZoneCategories);
      SetDropZoneData(openXmlElement, value?.DropZoneData);
      SetDropZoneSeries(openXmlElement, value?.DropZoneSeries);
      SetDropZonesVisible(openXmlElement, value?.DropZonesVisible);
      return openXmlElement;
    }
    return default;
  }
}
