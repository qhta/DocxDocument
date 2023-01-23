namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ScatterSerExtensionList Class.
/// </summary>
public static class ScatterSerExtensionListConverter
{
  private static Collection<DMDrawsCharts.ScatterSerExtension> GetScatterSerExtensions(DXDrawCharts.ScatterSerExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.ScatterSerExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.ScatterSerExtension>())
    {
      var newItem = DMXDrawsCharts.ScatterSerExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpScatterSerExtensions(DXDrawCharts.ScatterSerExtensionList openXmlElement, Collection<DMDrawsCharts.ScatterSerExtension>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetScatterSerExtensions(DXDrawCharts.ScatterSerExtensionList openXmlElement, Collection<DMDrawsCharts.ScatterSerExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.ScatterSerExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.ScatterSerExtensionConverter.CreateOpenXmlElement<DXDrawCharts.ScatterSerExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.ScatterSerExtensionList? CreateModelElement(DXDrawCharts.ScatterSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.ScatterSerExtensionList();
      value.ScatterSerExtensions = GetScatterSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.ScatterSerExtensionList? openXmlElement, DMDrawsCharts.ScatterSerExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpScatterSerExtensions(openXmlElement, value.ScatterSerExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ScatterSerExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.ScatterSerExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetScatterSerExtensions(openXmlElement, value?.ScatterSerExtensions);
      return openXmlElement;
    }
    return default;
  }
}
