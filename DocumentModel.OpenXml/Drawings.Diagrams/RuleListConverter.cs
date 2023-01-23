namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Rule List.
/// </summary>
public static class RuleListConverter
{
  private static Collection<DMDrawsDgms.Rule> GetRules(DXDrawDgms.RuleList openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.Rule>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.Rule>())
    {
      var newItem = DMXDrawsDgms.RuleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpRules(DXDrawDgms.RuleList openXmlElement, Collection<DMDrawsDgms.Rule>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawDgms.Rule>();
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
        if (!DMXDrawsDgms.RuleConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  private static void SetRules(DXDrawDgms.RuleList openXmlElement, Collection<DMDrawsDgms.Rule>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawDgms.Rule>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsDgms.RuleConverter.CreateOpenXmlElement<DXDrawDgms.Rule>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsDgms.RuleList? CreateModelElement(DXDrawDgms.RuleList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.RuleList();
      value.Rules = GetRules(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.RuleList? openXmlElement, DMDrawsDgms.RuleList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRules(openXmlElement, value.Rules, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.RuleList? value)
    where OpenXmlElementType: DXDrawDgms.RuleList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRules(openXmlElement, value?.Rules);
      return openXmlElement;
    }
    return default;
  }
}
