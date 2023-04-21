namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PivotOptions Class.
/// </summary>
public static class PivotOptionsConverter
{
  /// <summary>
  /// DropZoneFilter.
  /// </summary>
  private static Boolean? GetDropZoneFilter(DXO10DC.PivotOptions openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO10DC.DropZoneFilter>() != null;
  }
  
  private static bool CmpDropZoneFilter(DXO10DC.PivotOptions openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO10DC.DropZoneFilter>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO10DC.DropZoneFilter", val, value);
    return false;
  }
  
  private static void SetDropZoneFilter(DXO10DC.PivotOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO10DC.DropZoneFilter>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO10DC.DropZoneFilter();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DropZoneCategories.
  /// </summary>
  private static Boolean? GetDropZoneCategories(DXO10DC.PivotOptions openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO10DC.DropZoneCategories>() != null;
  }
  
  private static bool CmpDropZoneCategories(DXO10DC.PivotOptions openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO10DC.DropZoneCategories>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO10DC.DropZoneCategories", val, value);
    return false;
  }
  
  private static void SetDropZoneCategories(DXO10DC.PivotOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO10DC.DropZoneCategories>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO10DC.DropZoneCategories();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DropZoneData.
  /// </summary>
  private static Boolean? GetDropZoneData(DXO10DC.PivotOptions openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO10DC.DropZoneData>() != null;
  }
  
  private static bool CmpDropZoneData(DXO10DC.PivotOptions openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO10DC.DropZoneData>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO10DC.DropZoneData", val, value);
    return false;
  }
  
  private static void SetDropZoneData(DXO10DC.PivotOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO10DC.DropZoneData>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO10DC.DropZoneData();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DropZoneSeries.
  /// </summary>
  private static Boolean? GetDropZoneSeries(DXO10DC.PivotOptions openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO10DC.DropZoneSeries>() != null;
  }
  
  private static bool CmpDropZoneSeries(DXO10DC.PivotOptions openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO10DC.DropZoneSeries>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO10DC.DropZoneSeries", val, value);
    return false;
  }
  
  private static void SetDropZoneSeries(DXO10DC.PivotOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO10DC.DropZoneSeries>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO10DC.DropZoneSeries();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DropZonesVisible.
  /// </summary>
  private static Boolean? GetDropZonesVisible(DXO10DC.PivotOptions openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO10DC.DropZonesVisible>() != null;
  }
  
  private static bool CmpDropZonesVisible(DXO10DC.PivotOptions openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO10DC.DropZonesVisible>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO10DC.DropZonesVisible", val, value);
    return false;
  }
  
  private static void SetDropZonesVisible(DXO10DC.PivotOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO10DC.DropZonesVisible>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO10DC.DropZonesVisible();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.PivotOptions? CreateModelElement(DXO10DC.PivotOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PivotOptions();
      value.DropZoneFilter = GetDropZoneFilter(openXmlElement);
      value.DropZoneCategories = GetDropZoneCategories(openXmlElement);
      value.DropZoneData = GetDropZoneData(openXmlElement);
      value.DropZoneSeries = GetDropZoneSeries(openXmlElement);
      value.DropZonesVisible = GetDropZonesVisible(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10DC.PivotOptions? openXmlElement, DMDC.PivotOptions? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.PivotOptions value)
    where OpenXmlElementType: DXO10DC.PivotOptions, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10DC.PivotOptions openXmlElement, DMDC.PivotOptions value)
  {
    SetDropZoneFilter(openXmlElement, value?.DropZoneFilter);
    SetDropZoneCategories(openXmlElement, value?.DropZoneCategories);
    SetDropZoneData(openXmlElement, value?.DropZoneData);
    SetDropZoneSeries(openXmlElement, value?.DropZoneSeries);
    SetDropZonesVisible(openXmlElement, value?.DropZonesVisible);
  }
}
