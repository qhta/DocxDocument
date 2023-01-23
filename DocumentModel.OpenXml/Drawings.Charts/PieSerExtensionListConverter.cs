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
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.PieSerExtension>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().ToString()+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDrawsCharts.PieSerExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
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
