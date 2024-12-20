namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the RepurposedCommands Class.
/// </summary>
public static class RepurposedCommandsConverter
{
  private static Collection<DMUI.RepurposedCommand>? GetItems(DXOCustUI.RepurposedCommands openXmlElement)
  {
    var collection = new Collection<DMUI.RepurposedCommand>();
    foreach (var item in openXmlElement.Elements<DXOCustUI.RepurposedCommand>())
    {
      var newItem = DMXUI.RepurposedCommandConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXOCustUI.RepurposedCommands openXmlElement, Collection<DMUI.RepurposedCommand>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXOCustUI.RepurposedCommand>();
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
        if (!DMXUI.RepurposedCommandConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXOCustUI.RepurposedCommands openXmlElement, Collection<DMUI.RepurposedCommand>? value)
  {
    openXmlElement.RemoveAllChildren<DXOCustUI.RepurposedCommand>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXUI.RepurposedCommandConverter.CreateOpenXmlElement<DXOCustUI.RepurposedCommand>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.UI.RepurposedCommands? CreateModelElement(DXOCustUI.RepurposedCommands? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.RepurposedCommands();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOCustUI.RepurposedCommands? openXmlElement, DMUI.RepurposedCommands? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMUI.RepurposedCommands value)
    where OpenXmlElementType: DXOCustUI.RepurposedCommands, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOCustUI.RepurposedCommands openXmlElement, DMUI.RepurposedCommands value)
  {
    SetItems(openXmlElement, value?.Items);
  }
}
