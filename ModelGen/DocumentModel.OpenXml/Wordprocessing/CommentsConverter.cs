namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Comments Collection.
/// </summary>
public static class CommentsConverter
{
  private static Collection<DMW.Comment>? GetItems(DXW.Comments openXmlElement)
  {
    var collection = new Collection<DMW.Comment>();
    foreach (var item in openXmlElement.Elements<DXW.Comment>())
    {
      var newItem = DMXW.CommentConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXW.Comments openXmlElement, Collection<DMW.Comment>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.Comment>();
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
        if (!DMXW.CommentConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXW.Comments openXmlElement, Collection<DMW.Comment>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.Comment>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.CommentConverter.CreateOpenXmlElement<DXW.Comment>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Comments? CreateModelElement(DXW.Comments? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Comments();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Comments? openXmlElement, DMW.Comments? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Comments value)
    where OpenXmlElementType: DXW.Comments, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Comments openXmlElement, DMW.Comments value)
  {
    SetItems(openXmlElement, value?.Items);
  }
}
