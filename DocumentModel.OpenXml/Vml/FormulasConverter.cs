namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Formulas Class.
/// </summary>
public static class FormulasConverter
{
  private static Collection<DMV.Formula>? GetItems(DXV.Formulas openXmlElement)
  {
    var collection = new Collection<DMV.Formula>();
    foreach (var item in openXmlElement.Elements<DXV.Formula>())
    {
      var newItem = DMXV.FormulaConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXV.Formulas openXmlElement, Collection<DMV.Formula>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXV.Formula>();
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
        if (!DMXV.FormulaConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXV.Formulas openXmlElement, Collection<DMV.Formula>? value)
  {
    openXmlElement.RemoveAllChildren<DXV.Formula>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXV.FormulaConverter.CreateOpenXmlElement<DXV.Formula>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Vml.Formulas? CreateModelElement(DXV.Formulas? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Formulas();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXV.Formulas? openXmlElement, DMV.Formulas? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.Formulas value)
    where OpenXmlElementType: DXV.Formulas, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXV.Formulas openXmlElement, DMV.Formulas value)
  {
    SetItems(openXmlElement, value?.Items);
  }
}
