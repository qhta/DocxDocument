namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DateAxExtensionList Class.
/// </summary>
public static class DateAxExtensionListConverter
{
  private static Collection<DMDrawsCharts.DateAxExtension> GetDateAxExtensions(DXDrawCharts.DateAxExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.DateAxExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.DateAxExtension>())
    {
      var newItem = DMXDrawsCharts.DateAxExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetDateAxExtensions(DXDrawCharts.DateAxExtensionList openXmlElement, Collection<DMDrawsCharts.DateAxExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.DateAxExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.DateAxExtensionConverter.CreateOpenXmlElement<DXDrawCharts.DateAxExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.DateAxExtensionList? CreateModelElement(DXDrawCharts.DateAxExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.DateAxExtensionList();
      value.DateAxExtensions = GetDateAxExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DateAxExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.DateAxExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDateAxExtensions(openXmlElement, value?.DateAxExtensions);
      return openXmlElement;
    }
    return default;
  }
}
