namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BarSerExtensionList Class.
/// </summary>
public static class BarSerExtensionListConverter
{
  private static Collection<DMDrawsCharts.BarSerExtension> GetBarSerExtensions(DXDrawCharts.BarSerExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.BarSerExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.BarSerExtension>())
    {
      var newItem = DMXDrawsCharts.BarSerExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetBarSerExtensions(DXDrawCharts.BarSerExtensionList openXmlElement, Collection<DMDrawsCharts.BarSerExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.BarSerExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.BarSerExtensionConverter.CreateOpenXmlElement<DXDrawCharts.BarSerExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.BarSerExtensionList? CreateModelElement(DXDrawCharts.BarSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.BarSerExtensionList();
      value.BarSerExtensions = GetBarSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.BarSerExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.BarSerExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBarSerExtensions(openXmlElement, value?.BarSerExtensions);
      return openXmlElement;
    }
    return default;
  }
}
