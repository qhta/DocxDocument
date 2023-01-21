namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the SurfaceSerExtensionList Class.
/// </summary>
public static class SurfaceSerExtensionListConverter
{
  private static Collection<DMDrawsCharts.SurfaceSerExtension> GetSurfaceSerExtensions(DXDrawCharts.SurfaceSerExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.SurfaceSerExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.SurfaceSerExtension>())
    {
      var newItem = DMXDrawsCharts.SurfaceSerExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetSurfaceSerExtensions(DXDrawCharts.SurfaceSerExtensionList openXmlElement, Collection<DMDrawsCharts.SurfaceSerExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.SurfaceSerExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.SurfaceSerExtensionConverter.CreateOpenXmlElement<DXDrawCharts.SurfaceSerExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.SurfaceSerExtensionList? CreateModelElement(DXDrawCharts.SurfaceSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.SurfaceSerExtensionList();
      value.SurfaceSerExtensions = GetSurfaceSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.SurfaceSerExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.SurfaceSerExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSurfaceSerExtensions(openXmlElement, value?.SurfaceSerExtensions);
      return openXmlElement;
    }
    return default;
  }
}
