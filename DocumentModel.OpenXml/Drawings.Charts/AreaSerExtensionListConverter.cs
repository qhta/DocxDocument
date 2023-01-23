namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the AreaSerExtensionList Class.
/// </summary>
public static class AreaSerExtensionListConverter
{
  private static Collection<DMDrawsCharts.AreaSerExtension> GetAreaSerExtensions(DXDrawCharts.AreaSerExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.AreaSerExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.AreaSerExtension>())
    {
      var newItem = DMXDrawsCharts.AreaSerExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpAreaSerExtensions(DXDrawCharts.AreaSerExtensionList openXmlElement, Collection<DMDrawsCharts.AreaSerExtension>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetAreaSerExtensions(DXDrawCharts.AreaSerExtensionList openXmlElement, Collection<DMDrawsCharts.AreaSerExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.AreaSerExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.AreaSerExtensionConverter.CreateOpenXmlElement<DXDrawCharts.AreaSerExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.AreaSerExtensionList? CreateModelElement(DXDrawCharts.AreaSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.AreaSerExtensionList();
      value.AreaSerExtensions = GetAreaSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.AreaSerExtensionList? openXmlElement, DMDrawsCharts.AreaSerExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAreaSerExtensions(openXmlElement, value.AreaSerExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.AreaSerExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.AreaSerExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAreaSerExtensions(openXmlElement, value?.AreaSerExtensions);
      return openXmlElement;
    }
    return default;
  }
}
