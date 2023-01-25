namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Comments Collection.
/// </summary>
public static class CommentsConverter
{
  private static Collection<DMW.Comment> GetItems(DXW.Comments openXmlElement)
  {
    var collection = new Collection<DMW.Comment>();
    foreach (var item in openXmlElement.Elements<DXW.Comment>())
    {
      var newItem = DMXW.CommentConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpItems(DXW.Comments openXmlElement, Collection<DMW.Comment>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXW.Comment>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
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
    if (openXmlElement == null && value == null) return true;
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
  
  public static DMW.Comments? CreateModelElement(DXW.Comments? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Comments();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Comments? value)
    where OpenXmlElementType: DXW.Comments, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}
