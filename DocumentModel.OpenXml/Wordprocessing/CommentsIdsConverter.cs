namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CommentsIds Class.
/// </summary>
public static class CommentsIdsConverter
{
  private static Collection<DMW.CommentId>? GetCommentIds(DXO2019WCid.CommentsIds openXmlElement)
  {
    var collection = new Collection<DMW.CommentId>();
    foreach (var item in openXmlElement.Elements<DXO2019WCid.CommentId>())
    {
      var newItem = DMXW.CommentIdConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpCommentIds(DXO2019WCid.CommentsIds openXmlElement, Collection<DMW.CommentId>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2019WCid.CommentId>();
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
        if (!DMXW.CommentIdConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetCommentIds(DXO2019WCid.CommentsIds openXmlElement, Collection<DMW.CommentId>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2019WCid.CommentId>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.CommentIdConverter.CreateOpenXmlElement<DXO2019WCid.CommentId>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.CommentsIds? CreateModelElement(DXO2019WCid.CommentsIds? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.CommentsIds();
      value.CommentIds = GetCommentIds(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2019WCid.CommentsIds? openXmlElement, DMW.CommentsIds? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCommentIds(openXmlElement, value.CommentIds, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.CommentsIds value)
    where OpenXmlElementType: DXO2019WCid.CommentsIds, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2019WCid.CommentsIds openXmlElement, DMW.CommentsIds value)
  {
    SetCommentIds(openXmlElement, value?.CommentIds);
  }
}
