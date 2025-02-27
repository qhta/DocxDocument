namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StrRefExtensionList Class.
/// </summary>
public static class StrRefExtensionListConverter
{
  private static Collection<DMDrawsCharts.StrRefExtension>? GetStrRefExtensions(DXDrawCharts.StrRefExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.StrRefExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.StrRefExtension>())
    {
      var newItem = DMXDrawsCharts.StrRefExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpStrRefExtensions(DXDrawCharts.StrRefExtensionList openXmlElement, Collection<DMDrawsCharts.StrRefExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.StrRefExtension>();
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
        if (!DMXDrawsCharts.StrRefExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetStrRefExtensions(DXDrawCharts.StrRefExtensionList openXmlElement, Collection<DMDrawsCharts.StrRefExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.StrRefExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.StrRefExtensionConverter.CreateOpenXmlElement<DXDrawCharts.StrRefExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.StrRefExtensionList? CreateModelElement(DXDrawCharts.StrRefExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StrRefExtensionList();
      value.StrRefExtensions = GetStrRefExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.StrRefExtensionList? openXmlElement, DMDrawsCharts.StrRefExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpStrRefExtensions(openXmlElement, value.StrRefExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.StrRefExtensionList value)
    where OpenXmlElementType: DXDrawCharts.StrRefExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.StrRefExtensionList openXmlElement, DMDrawsCharts.StrRefExtensionList value)
  {
    SetStrRefExtensions(openXmlElement, value?.StrRefExtensions);
  }
}
