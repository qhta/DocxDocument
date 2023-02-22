namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Constraint List.
/// </summary>
public static class ConstraintsConverter
{
  private static Collection<DMDrawsDgms.Constraint>? GetItems(DXDrawDgms.Constraints openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.Constraint>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.Constraint>())
    {
      var newItem = DMXDrawsDgms.ConstraintConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXDrawDgms.Constraints openXmlElement, Collection<DMDrawsDgms.Constraint>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawDgms.Constraint>();
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
        if (!DMXDrawsDgms.ConstraintConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXDrawDgms.Constraints openXmlElement, Collection<DMDrawsDgms.Constraint>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawDgms.Constraint>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsDgms.ConstraintConverter.CreateOpenXmlElement<DXDrawDgms.Constraint>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.Constraints? CreateModelElement(DXDrawDgms.Constraints? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Constraints();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.Constraints? openXmlElement, DMDrawsDgms.Constraints? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Constraints value)
    where OpenXmlElementType: DXDrawDgms.Constraints, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.Constraints openXmlElement, DMDrawsDgms.Constraints value)
  {
    SetItems(openXmlElement, value?.Items);
    }
  }
