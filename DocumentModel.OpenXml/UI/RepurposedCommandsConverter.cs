namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the RepurposedCommands Class.
/// </summary>
public static class RepurposedCommandsConverter
{
  private static Collection<DMUI.RepurposedCommand>? GetItems(DXOCUI.RepurposedCommands openXmlElement)
  {
    var collection = new Collection<DMUI.RepurposedCommand>();
    foreach (var item in openXmlElement.Elements<DXOCUI.RepurposedCommand>())
    {
      var newItem = DMXUI.RepurposedCommandConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXOCUI.RepurposedCommands openXmlElement, Collection<DMUI.RepurposedCommand>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXOCUI.RepurposedCommand>();
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
        if (!DMXUI.RepurposedCommandConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXOCUI.RepurposedCommands openXmlElement, Collection<DMUI.RepurposedCommand>? value)
  {
    openXmlElement.RemoveAllChildren<DXOCUI.RepurposedCommand>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXUI.RepurposedCommandConverter.CreateOpenXmlElement<DXOCUI.RepurposedCommand>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.UI.RepurposedCommands? CreateModelElement(DXOCUI.RepurposedCommands? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.RepurposedCommands();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOCUI.RepurposedCommands? openXmlElement, DMUI.RepurposedCommands? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMUI.RepurposedCommands value)
    where OpenXmlElementType: DXOCUI.RepurposedCommands, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOCUI.RepurposedCommands openXmlElement, DMUI.RepurposedCommands value)
  {
    SetItems(openXmlElement, value?.Items);
  }
}
