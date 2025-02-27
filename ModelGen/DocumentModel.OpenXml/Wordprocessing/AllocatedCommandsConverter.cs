namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommands Class.
/// </summary>
public static class AllocatedCommandsConverter
{
  private static Collection<DMW.AllocatedCommand>? GetItems(DXOW.AllocatedCommands openXmlElement)
  {
    var collection = new Collection<DMW.AllocatedCommand>();
    foreach (var item in openXmlElement.Elements<DXOW.AllocatedCommand>())
    {
      var newItem = DMXW.AllocatedCommandConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXOW.AllocatedCommands openXmlElement, Collection<DMW.AllocatedCommand>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXOW.AllocatedCommand>();
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
        if (!DMXW.AllocatedCommandConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXOW.AllocatedCommands openXmlElement, Collection<DMW.AllocatedCommand>? value)
  {
    openXmlElement.RemoveAllChildren<DXOW.AllocatedCommand>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.AllocatedCommandConverter.CreateOpenXmlElement<DXOW.AllocatedCommand>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.AllocatedCommands? CreateModelElement(DXOW.AllocatedCommands? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.AllocatedCommands();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOW.AllocatedCommands? openXmlElement, DMW.AllocatedCommands? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.AllocatedCommands value)
    where OpenXmlElementType: DXOW.AllocatedCommands, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOW.AllocatedCommands openXmlElement, DMW.AllocatedCommands value)
  {
    SetItems(openXmlElement, value?.Items);
  }
}
