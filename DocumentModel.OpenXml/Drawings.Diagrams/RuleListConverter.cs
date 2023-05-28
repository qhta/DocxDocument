namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Rule List.
/// </summary>
public static class RuleListConverter
{
  private static Collection<DMDD.Rule>? GetRules(DXDD.RuleList openXmlElement)
  {
    var collection = new Collection<DMDD.Rule>();
    foreach (var item in openXmlElement.Elements<DXDD.Rule>())
    {
      var newItem = DMXDD.RuleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpRules(DXDD.RuleList openXmlElement, Collection<DMDD.Rule>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDD.Rule>();
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
        if (!DMXDD.RuleConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetRules(DXDD.RuleList openXmlElement, Collection<DMDD.Rule>? value)
  {
    openXmlElement.RemoveAllChildren<DXDD.Rule>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDD.RuleConverter.CreateOpenXmlElement<DXDD.Rule>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMDD.RuleList? CreateModelElement(DXDD.RuleList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDD.RuleList();
      value.Rules = GetRules(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.RuleList? openXmlElement, DMDD.RuleList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRules(openXmlElement, value.Rules, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.RuleList value)
    where OpenXmlElementType: DXDD.RuleList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.RuleList openXmlElement, DMDD.RuleList value)
  {
    SetRules(openXmlElement, value?.Rules);
  }
}
