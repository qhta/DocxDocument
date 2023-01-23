namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DLblExtensionList Class.
/// </summary>
public static class DLblExtensionListConverter
{
  private static Collection<DMDrawsCharts.DLblExtension> GetDLblExtensions(DXDrawCharts.DLblExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.DLblExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.DLblExtension>())
    {
      var newItem = DMXDrawsCharts.DLblExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpDLblExtensions(DXDrawCharts.DLblExtensionList openXmlElement, Collection<DMDrawsCharts.DLblExtension>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetDLblExtensions(DXDrawCharts.DLblExtensionList openXmlElement, Collection<DMDrawsCharts.DLblExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.DLblExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.DLblExtensionConverter.CreateOpenXmlElement<DXDrawCharts.DLblExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.DLblExtensionList? CreateModelElement(DXDrawCharts.DLblExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.DLblExtensionList();
      value.DLblExtensions = GetDLblExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.DLblExtensionList? openXmlElement, DMDrawsCharts.DLblExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDLblExtensions(openXmlElement, value.DLblExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DLblExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.DLblExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDLblExtensions(openXmlElement, value?.DLblExtensions);
      return openXmlElement;
    }
    return default;
  }
}
