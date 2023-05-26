namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PieSerExtensionList Class.
/// </summary>
public static class PieSerExtensionListConverter
{
  private static Collection<DMDC.PieSerExtension>? GetPieSerExtensions(DXDC.PieSerExtensionList openXmlElement)
  {
    var collection = new Collection<DMDC.PieSerExtension>();
    foreach (var item in openXmlElement.Elements<DXDC.PieSerExtension>())
    {
      var newItem = DMXDC.PieSerExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpPieSerExtensions(DXDC.PieSerExtensionList openXmlElement, Collection<DMDC.PieSerExtension>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.PieSerExtension>();
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
        if (!DMXDC.PieSerExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetPieSerExtensions(DXDC.PieSerExtensionList openXmlElement, Collection<DMDC.PieSerExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.PieSerExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.PieSerExtensionConverter.CreateOpenXmlElement<DXDC.PieSerExtension>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.PieSerExtensionList? CreateModelElement(DXDC.PieSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PieSerExtensionList();
      value.PieSerExtensions = GetPieSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.PieSerExtensionList? openXmlElement, DMDC.PieSerExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPieSerExtensions(openXmlElement, value.PieSerExtensions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.PieSerExtensionList value)
    where OpenXmlElementType: DXDC.PieSerExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.PieSerExtensionList openXmlElement, DMDC.PieSerExtensionList value)
  {
    SetPieSerExtensions(openXmlElement, value?.PieSerExtensions);
  }
}
