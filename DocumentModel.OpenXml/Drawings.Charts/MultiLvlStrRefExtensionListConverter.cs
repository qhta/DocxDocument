namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the MultiLvlStrRefExtensionList Class.
/// </summary>
public static class MultiLvlStrRefExtensionListConverter
{
  private static Collection<DMDrawsCharts.MultiLvlStrRefExtension>? GetMultiLvlStrRefExtensions(DXDrawCharts.MultiLvlStrRefExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.MultiLvlStrRefExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.MultiLvlStrRefExtension>())
    {
      var newItem = DMXDrawsCharts.MultiLvlStrRefExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpMultiLvlStrRefExtensions(DXDrawCharts.MultiLvlStrRefExtensionList openXmlElement, Collection<DMDrawsCharts.MultiLvlStrRefExtension>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.MultiLvlStrRefExtension>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
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
        if (!DMXDrawsCharts.MultiLvlStrRefExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetMultiLvlStrRefExtensions(DXDrawCharts.MultiLvlStrRefExtensionList openXmlElement, Collection<DMDrawsCharts.MultiLvlStrRefExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.MultiLvlStrRefExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.MultiLvlStrRefExtensionConverter.CreateOpenXmlElement<DXDrawCharts.MultiLvlStrRefExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.MultiLvlStrRefExtensionList? CreateModelElement(DXDrawCharts.MultiLvlStrRefExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.MultiLvlStrRefExtensionList();
      value.MultiLvlStrRefExtensions = GetMultiLvlStrRefExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.MultiLvlStrRefExtensionList? openXmlElement, DMDrawsCharts.MultiLvlStrRefExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMultiLvlStrRefExtensions(openXmlElement, value.MultiLvlStrRefExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.MultiLvlStrRefExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.MultiLvlStrRefExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMultiLvlStrRefExtensions(openXmlElement, value?.MultiLvlStrRefExtensions);
      return openXmlElement;
    }
    return default;
  }
}
