namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the NumberingCache Class.
/// </summary>
public static class NumberingCacheConverter
{
  private static String? GetFormatCode(DXDrawCharts.NumberingCache openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.FormatCode>()?.Text;
  }
  
  private static bool CmpFormatCode(DXDrawCharts.NumberingCache openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.FormatCode>()?.Text == value;
  }
  
  private static void SetFormatCode(DXDrawCharts.NumberingCache openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.FormatCode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.FormatCode { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static UInt32? GetPointCount(DXDrawCharts.NumberingCache openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.PointCount>()?.Val?.Value;
  }
  
  private static bool CmpPointCount(DXDrawCharts.NumberingCache openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.PointCount>()?.Val?.Value == value;
  }
  
  private static void SetPointCount(DXDrawCharts.NumberingCache openXmlElement, UInt32? value)
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
  
  private static Collection<DMDrawsCharts.NumericPoint> GetNumericPoints(DXDrawCharts.NumberingCache openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.NumericPoint>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.NumericPoint>())
    {
      var newItem = DMXDrawsCharts.NumericPointConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpNumericPoints(DXDrawCharts.NumberingCache openXmlElement, Collection<DMDrawsCharts.NumericPoint>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetNumericPoints(DXDrawCharts.NumberingCache openXmlElement, Collection<DMDrawsCharts.NumericPoint>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.NumericPoint>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.NumericPointConverter.CreateOpenXmlElement<DXDrawCharts.NumericPoint>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.NumberingCache openXmlElement)
  {
    return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDrawCharts.NumberingCache openXmlElement, DMDrawsCharts.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawCharts.NumberingCache openXmlElement, DMDrawsCharts.ExtensionList? value)
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
  
  public static DMDrawsCharts.NumberingCache? CreateModelElement(DXDrawCharts.NumberingCache? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.NumberingCache();
      value.FormatCode = GetFormatCode(openXmlElement);
      value.PointCount = GetPointCount(openXmlElement);
      value.NumericPoints = GetNumericPoints(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.NumberingCache? openXmlElement, DMDrawsCharts.NumberingCache? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFormatCode(openXmlElement, value.FormatCode, diffs, objName))
        ok = false;
      if (!CmpPointCount(openXmlElement, value.PointCount, diffs, objName))
        ok = false;
      if (!CmpNumericPoints(openXmlElement, value.NumericPoints, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.NumberingCache? value)
    where OpenXmlElementType: DXDrawCharts.NumberingCache, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFormatCode(openXmlElement, value?.FormatCode);
      SetPointCount(openXmlElement, value?.PointCount);
      SetNumericPoints(openXmlElement, value?.NumericPoints);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
