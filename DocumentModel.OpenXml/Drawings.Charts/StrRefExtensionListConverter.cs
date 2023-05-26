namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StrRefExtensionList Class.
/// </summary>
public static class StrRefExtensionListConverter
{
  private static Collection<DMDC.StrRefExtension>? GetStrRefExtensions(DXDC.StrRefExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.StrRefExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.StrRefExtension>())
    {
      var newItem = DMXDC.StrRefExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpStrRefExtensions(DXDC.StrRefExtensionList openXmlElement, Collection<DMDC.StrRefExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.StrRefExtension>();
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
        if (!DMXDC.StrRefExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetStrRefExtensions(DXDC.StrRefExtensionList openXmlElement, Collection<DMDC.StrRefExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.StrRefExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.StrRefExtensionConverter.CreateOpenXmlElement<DXDC.StrRefExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.StrRefExtensionList? CreateModelElement(DXDC.StrRefExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StrRefExtensionList();
      value.StrRefExtensions = GetStrRefExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.StrRefExtensionList? openXmlElement, DMDC.StrRefExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpStrRefExtensions(openXmlElement, value.StrRefExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.StrRefExtensionList value)
    where OpenXmlElementType: DXDC.StrRefExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.StrRefExtensionList openXmlElement, DMDC.StrRefExtensionList value)
  {
    SetStrRefExtensions(openXmlElement, value?.StrRefExtensions);
  }
}
