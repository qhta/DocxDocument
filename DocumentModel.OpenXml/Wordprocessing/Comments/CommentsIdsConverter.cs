namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.CommentsIds"/> class from/to OpenXml conversion.
/// </summary>
public static class CommentsIdsConverter
{
  #region CommentsIds collection conversion.
  private static DMW.CommentsIds? GetCommentsIds(DXO19WCid.CommentsIds openXmlElement)
  {
    var collection = new DMW.CommentsIds();
    foreach (var item in openXmlElement.Elements<DXO19WCid.CommentId>())
    {
      var newItem = DMXW.CommentIdConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpCommentsIds(DXO19WCid.CommentsIds openXmlElement, Collection<DMW.CommentId>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO19WCid.CommentId>();
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
  
  private static void SetCommentIds(DXO19WCid.CommentsIds openXmlElement, Collection<DMW.CommentId>? value)
  {
    openXmlElement.RemoveAllChildren<DXO19WCid.CommentId>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.CommentIdConverter.CreateOpenXmlElement<DXO19WCid.CommentId>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  #endregion

  #region CommentsIds model conversion
  public static DMW.CommentsIds? CreateModelElement(DXO19WCid.CommentsIds? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = GetCommentsIds(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO19WCid.CommentsIds? openXmlElement, DMW.CommentsIds? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpCommentsIds(openXmlElement, model, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXO19WCid.CommentsIds CreateOpenXmlElement(DMW.CommentsIds model)
  {
    var openXmlElement = new DXO19WCid.CommentsIds();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO19WCid.CommentsIds openXmlElement, DMW.CommentsIds model)
  {
    SetCommentIds(openXmlElement, model);
  }
  #endregion
}
