namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the RadarSerExtensionList Class.
/// </summary>
public static class RadarSerExtensionListConverter
{
  private static Collection<DMDrawsCharts.RadarSerExtension> GetRadarSerExtensions(DXDrawCharts.RadarSerExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.RadarSerExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.RadarSerExtension>())
    {
      var newItem = DMXDrawsCharts.RadarSerExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetRadarSerExtensions(DXDrawCharts.RadarSerExtensionList openXmlElement, Collection<DMDrawsCharts.RadarSerExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.RadarSerExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.RadarSerExtensionConverter.CreateOpenXmlElement<DXDrawCharts.RadarSerExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.RadarSerExtensionList? CreateModelElement(DXDrawCharts.RadarSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.RadarSerExtensionList();
      value.RadarSerExtensions = GetRadarSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.RadarSerExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.RadarSerExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRadarSerExtensions(openXmlElement, value?.RadarSerExtensions);
      return openXmlElement;
    }
    return default;
  }
}
