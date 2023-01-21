namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StringCache Class.
/// </summary>
public static class StringCacheConverter
{
  private static UInt32? GetPointCount(DXDrawCharts.StringCache openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.PointCount>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPointCount(DXDrawCharts.StringCache openXmlElement, UInt32? value)
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
  
  private static Collection<DMDrawsCharts.StringPoint> GetStringPoints(DXDrawCharts.StringCache openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.StringPoint>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.StringPoint>())
    {
      var newItem = DMXDrawsCharts.StringPointConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetStringPoints(DXDrawCharts.StringCache openXmlElement, Collection<DMDrawsCharts.StringPoint>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.StringPoint>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.StringPointConverter.CreateOpenXmlElement<DXDrawCharts.StringPoint>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsCharts.StrDataExtensionList? GetStrDataExtensionList(DXDrawCharts.StringCache openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.StrDataExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.StrDataExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStrDataExtensionList(DXDrawCharts.StringCache openXmlElement, DMDrawsCharts.StrDataExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.StrDataExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.StrDataExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.StrDataExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.StringCache? CreateModelElement(DXDrawCharts.StringCache? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.StringCache();
      value.PointCount = GetPointCount(openXmlElement);
      value.StringPoints = GetStringPoints(openXmlElement);
      value.StrDataExtensionList = GetStrDataExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.StringCache? value)
    where OpenXmlElementType: DXDrawCharts.StringCache, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPointCount(openXmlElement, value?.PointCount);
      SetStringPoints(openXmlElement, value?.StringPoints);
      SetStrDataExtensionList(openXmlElement, value?.StrDataExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
