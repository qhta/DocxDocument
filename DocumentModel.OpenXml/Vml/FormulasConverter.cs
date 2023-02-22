namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Formulas Class.
/// </summary>
public static class FormulasConverter
{
  private static Collection<DMVml.Formula>? GetItems(DXVml.Formulas openXmlElement)
  {
    var collection = new Collection<DMVml.Formula>();
    foreach (var item in openXmlElement.Elements<DXVml.Formula>())
    {
      var newItem = DMXVml.FormulaConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXVml.Formulas openXmlElement, Collection<DMVml.Formula>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXVml.Formula>();
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
        if (!DMXVml.FormulaConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXVml.Formulas openXmlElement, Collection<DMVml.Formula>? value)
  {
    openXmlElement.RemoveAllChildren<DXVml.Formula>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXVml.FormulaConverter.CreateOpenXmlElement<DXVml.Formula>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Vml.Formulas? CreateModelElement(DXVml.Formulas? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Formulas();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVml.Formulas? openXmlElement, DMVml.Formulas? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMVml.Formulas value)
    where OpenXmlElementType: DXVml.Formulas, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVml.Formulas openXmlElement, DMVml.Formulas value)
  {
    SetItems(openXmlElement, value?.Items);
    }
  }
