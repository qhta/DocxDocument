namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Constraint List.
/// </summary>
public static class ConstraintsConverter
{
  private static Collection<DMDD.Constraint>? GetItems(DXDD.Constraints openXmlElement)
  {
    var collection = new Collection<DMDD.Constraint>();
    foreach (var item in openXmlElement.Elements<DXDD.Constraint>())
    {
      var newItem = DMXDD.ConstraintConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXDD.Constraints openXmlElement, Collection<DMDD.Constraint>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDD.Constraint>();
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
        if (!DMXDD.ConstraintConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXDD.Constraints openXmlElement, Collection<DMDD.Constraint>? value)
  {
    openXmlElement.RemoveAllChildren<DXDD.Constraint>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDD.ConstraintConverter.CreateOpenXmlElement<DXDD.Constraint>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMDD.Constraints? CreateModelElement(DXDD.Constraints? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDD.Constraints();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.Constraints? openXmlElement, DMDD.Constraints? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.Constraints value)
    where OpenXmlElementType: DXDD.Constraints, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.Constraints openXmlElement, DMDD.Constraints value)
  {
    SetItems(openXmlElement, value?.Items);
  }
}
