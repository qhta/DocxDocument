namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public static class ExtensionListConverter
{
  private static Collection<DMDrawsCharts.Extension> GetExtensions(DXDrawCharts.ExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.Extension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.Extension>())
    {
      var newItem = DMXDrawsCharts.ExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetExtensions(DXDrawCharts.ExtensionList openXmlElement, Collection<DMDrawsCharts.Extension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.Extension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.ExtensionConverter.CreateOpenXmlElement<DXDrawCharts.Extension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.ExtensionList? CreateModelElement(DXDrawCharts.ExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.ExtensionList();
      value.Extensions = GetExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.ExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtensions(openXmlElement, value?.Extensions);
      return openXmlElement;
    }
    return default;
  }
}
