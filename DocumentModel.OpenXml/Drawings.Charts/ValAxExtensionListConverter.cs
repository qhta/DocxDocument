namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ValAxExtensionList Class.
/// </summary>
public static class ValAxExtensionListConverter
{
  private static Collection<DMDrawsCharts.ValAxExtension> GetValAxExtensions(DXDrawCharts.ValAxExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.ValAxExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.ValAxExtension>())
    {
      var newItem = DMXDrawsCharts.ValAxExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetValAxExtensions(DXDrawCharts.ValAxExtensionList openXmlElement, Collection<DMDrawsCharts.ValAxExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.ValAxExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.ValAxExtensionConverter.CreateOpenXmlElement<DXDrawCharts.ValAxExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.ValAxExtensionList? CreateModelElement(DXDrawCharts.ValAxExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.ValAxExtensionList();
      value.ValAxExtensions = GetValAxExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ValAxExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.ValAxExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetValAxExtensions(openXmlElement, value?.ValAxExtensions);
      return openXmlElement;
    }
    return default;
  }
}
