namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Commands Class.
/// </summary>
public static class CommandsConverter
{
  private static Collection<DM.Command>? GetItems(DXO10CUI.Commands openXmlElement)
  {
    var collection = new Collection<DM.Command>();
    foreach (var item in openXmlElement.Elements<DXO10CUI.Command>())
    {
      var newItem = DMX.CommandConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXO10CUI.Commands openXmlElement, Collection<DM.Command>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXO10CUI.Command>();
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
        if (!DMX.CommandConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXO10CUI.Commands openXmlElement, Collection<DM.Command>? value)
  {
    openXmlElement.RemoveAllChildren<DXO10CUI.Command>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMX.CommandConverter.CreateOpenXmlElement<DXO10CUI.Command>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Commands? CreateModelElement(DXO10CUI.Commands? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Commands();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10CUI.Commands? openXmlElement, DM.Commands? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.Commands value)
    where OpenXmlElementType: DXO10CUI.Commands, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10CUI.Commands openXmlElement, DM.Commands value)
  {
    SetItems(openXmlElement, value?.Items);
  }
}
