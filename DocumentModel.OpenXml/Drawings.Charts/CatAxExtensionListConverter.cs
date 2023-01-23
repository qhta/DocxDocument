namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the CatAxExtensionList Class.
/// </summary>
public static class CatAxExtensionListConverter
{
  private static Collection<DMDrawsCharts.CatAxExtension> GetCatAxExtensions(DXDrawCharts.CatAxExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.CatAxExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.CatAxExtension>())
    {
      var newItem = DMXDrawsCharts.CatAxExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpCatAxExtensions(DXDrawCharts.CatAxExtensionList openXmlElement, Collection<DMDrawsCharts.CatAxExtension>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetCatAxExtensions(DXDrawCharts.CatAxExtensionList openXmlElement, Collection<DMDrawsCharts.CatAxExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.CatAxExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.CatAxExtensionConverter.CreateOpenXmlElement<DXDrawCharts.CatAxExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.CatAxExtensionList? CreateModelElement(DXDrawCharts.CatAxExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.CatAxExtensionList();
      value.CatAxExtensions = GetCatAxExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.CatAxExtensionList? openXmlElement, DMDrawsCharts.CatAxExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCatAxExtensions(openXmlElement, value.CatAxExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.CatAxExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.CatAxExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCatAxExtensions(openXmlElement, value?.CatAxExtensions);
      return openXmlElement;
    }
    return default;
  }
}
