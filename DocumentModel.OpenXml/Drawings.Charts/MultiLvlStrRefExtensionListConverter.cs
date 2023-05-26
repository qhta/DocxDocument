namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the MultiLvlStrRefExtensionList Class.
/// </summary>
public static class MultiLvlStrRefExtensionListConverter
{
  private static Collection<DMDC.MultiLvlStrRefExtension>? GetMultiLvlStrRefExtensions(DXDC.MultiLvlStrRefExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.MultiLvlStrRefExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.MultiLvlStrRefExtension>())
    {
      var newItem = DMXDC.MultiLvlStrRefExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpMultiLvlStrRefExtensions(DXDC.MultiLvlStrRefExtensionList openXmlElement, Collection<DMDC.MultiLvlStrRefExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.MultiLvlStrRefExtension>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDC.MultiLvlStrRefExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetMultiLvlStrRefExtensions(DXDC.MultiLvlStrRefExtensionList openXmlElement, Collection<DMDC.MultiLvlStrRefExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.MultiLvlStrRefExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.MultiLvlStrRefExtensionConverter.CreateOpenXmlElement<DXDC.MultiLvlStrRefExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.MultiLvlStrRefExtensionList? CreateModelElement(DXDC.MultiLvlStrRefExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.MultiLvlStrRefExtensionList();
      value.MultiLvlStrRefExtensions = GetMultiLvlStrRefExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.MultiLvlStrRefExtensionList? openXmlElement, DMDC.MultiLvlStrRefExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMultiLvlStrRefExtensions(openXmlElement, value.MultiLvlStrRefExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.MultiLvlStrRefExtensionList value)
    where OpenXmlElementType: DXDC.MultiLvlStrRefExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.MultiLvlStrRefExtensionList openXmlElement, DMDC.MultiLvlStrRefExtensionList value)
  {
    SetMultiLvlStrRefExtensions(openXmlElement, value?.MultiLvlStrRefExtensions);
  }
}
