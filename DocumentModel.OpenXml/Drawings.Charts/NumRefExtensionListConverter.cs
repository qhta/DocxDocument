namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the NumRefExtensionList Class.
/// </summary>
public static class NumRefExtensionListConverter
{
  private static Collection<DMDrawsCharts.NumRefExtension>? GetNumRefExtensions(DXDrawCharts.NumRefExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.NumRefExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.NumRefExtension>())
    {
      var newItem = DMXDrawsCharts.NumRefExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpNumRefExtensions(DXDrawCharts.NumRefExtensionList openXmlElement, Collection<DMDrawsCharts.NumRefExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.NumRefExtension>();
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
        if (!DMXDrawsCharts.NumRefExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetNumRefExtensions(DXDrawCharts.NumRefExtensionList openXmlElement, Collection<DMDrawsCharts.NumRefExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.NumRefExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.NumRefExtensionConverter.CreateOpenXmlElement<DXDrawCharts.NumRefExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.NumRefExtensionList? CreateModelElement(DXDrawCharts.NumRefExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.NumRefExtensionList();
      value.NumRefExtensions = GetNumRefExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.NumRefExtensionList? openXmlElement, DMDrawsCharts.NumRefExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNumRefExtensions(openXmlElement, value.NumRefExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.NumRefExtensionList value)
    where OpenXmlElementType: DXDrawCharts.NumRefExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.NumRefExtensionList openXmlElement, DMDrawsCharts.NumRefExtensionList value)
  {
    SetNumRefExtensions(openXmlElement, value?.NumRefExtensions);
  }
}
