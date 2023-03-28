namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document Variables converter from/to OpenXml.
///</summary>
public static class DocumentVariablesConverter
{
  private static Collection<DMW.DocumentVariable>? GetItems(DXW.DocumentVariables openXmlElement)
  {
    var collection = new Collection<DMW.DocumentVariable>();
    foreach (var item in openXmlElement.Elements<DXW.DocumentVariable>())
    {
      var newItem = DMXW.DocumentVariableConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXW.DocumentVariables openXmlElement, Collection<DMW.DocumentVariable>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.DocumentVariable>();
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
        if (!DMXW.DocumentVariableConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXW.DocumentVariables openXmlElement, Collection<DMW.DocumentVariable>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.DocumentVariable>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.DocumentVariableConverter.CreateOpenXmlElement<DXW.DocumentVariable>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.DocumentVariables? CreateModelElement(DXW.DocumentVariables? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DocumentVariables();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.DocumentVariables? openXmlElement, DMW.DocumentVariables? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.DocumentVariables value)
    where OpenXmlElementType: DXW.DocumentVariables, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.DocumentVariables openXmlElement, DMW.DocumentVariables value)
  {
    SetItems(openXmlElement, value?.Items);
  }
}
