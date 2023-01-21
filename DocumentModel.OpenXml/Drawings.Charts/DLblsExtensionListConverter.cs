namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DLblsExtensionList Class.
/// </summary>
public static class DLblsExtensionListConverter
{
  private static Collection<DMDrawsCharts.DLblsExtension> GetDLblsExtensions(DXDrawCharts.DLblsExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.DLblsExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.DLblsExtension>())
    {
      var newItem = DMXDrawsCharts.DLblsExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetDLblsExtensions(DXDrawCharts.DLblsExtensionList openXmlElement, Collection<DMDrawsCharts.DLblsExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.DLblsExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.DLblsExtensionConverter.CreateOpenXmlElement<DXDrawCharts.DLblsExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.DLblsExtensionList? CreateModelElement(DXDrawCharts.DLblsExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.DLblsExtensionList();
      value.DLblsExtensions = GetDLblsExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DLblsExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.DLblsExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDLblsExtensions(openXmlElement, value?.DLblsExtensions);
      return openXmlElement;
    }
    return default;
  }
}
