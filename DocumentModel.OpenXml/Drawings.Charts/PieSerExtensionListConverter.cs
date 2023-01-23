namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PieSerExtensionList Class.
/// </summary>
public static class PieSerExtensionListConverter
{
  private static Collection<DMDrawsCharts.PieSerExtension> GetPieSerExtensions(DXDrawCharts.PieSerExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.PieSerExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.PieSerExtension>())
    {
      var newItem = DMXDrawsCharts.PieSerExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpPieSerExtensions(DXDrawCharts.PieSerExtensionList openXmlElement, Collection<DMDrawsCharts.PieSerExtension>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetPieSerExtensions(DXDrawCharts.PieSerExtensionList openXmlElement, Collection<DMDrawsCharts.PieSerExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.PieSerExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.PieSerExtensionConverter.CreateOpenXmlElement<DXDrawCharts.PieSerExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.PieSerExtensionList? CreateModelElement(DXDrawCharts.PieSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.PieSerExtensionList();
      value.PieSerExtensions = GetPieSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.PieSerExtensionList? openXmlElement, DMDrawsCharts.PieSerExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPieSerExtensions(openXmlElement, value.PieSerExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.PieSerExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.PieSerExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPieSerExtensions(openXmlElement, value?.PieSerExtensions);
      return openXmlElement;
    }
    return default;
  }
}
