namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PieSerExtensionList Class.
/// </summary>
public static class PieSerExtensionListConverter
{
  private static Collection<DMDrawsCharts.PieSerExtension>? GetPieSerExtensions(DXDrawCharts.PieSerExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.PieSerExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.PieSerExtension>())
    {
      var newItem = DMXDrawsCharts.PieSerExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpPieSerExtensions(DXDrawCharts.PieSerExtensionList openXmlElement, Collection<DMDrawsCharts.PieSerExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.PieSerExtension>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
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
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
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
  
  public static DocumentModel.Drawings.Charts.PieSerExtensionList? CreateModelElement(DXDrawCharts.PieSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PieSerExtensionList();
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.PieSerExtensionList value)
    where OpenXmlElementType: DXDrawCharts.PieSerExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.PieSerExtensionList openXmlElement, DMDrawsCharts.PieSerExtensionList value)
  {
    SetPieSerExtensions(openXmlElement, value?.PieSerExtensions);
    }
  }
