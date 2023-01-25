namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CommentsEx Class.
/// </summary>
public static class CommentsExConverter
{
  private static Collection<DMW.CommentEx> GetCommentExs(DXO2013W.CommentsEx openXmlElement)
  {
    var collection = new Collection<DMW.CommentEx>();
    foreach (var item in openXmlElement.Elements<DXO2013W.CommentEx>())
    {
      var newItem = DMXW.CommentExConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpCommentExs(DXO2013W.CommentsEx openXmlElement, Collection<DMW.CommentEx>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXO2013W.CommentEx>();
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
        if (!DMXW.CommentExConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetCommentExs(DXO2013W.CommentsEx openXmlElement, Collection<DMW.CommentEx>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2013W.CommentEx>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.CommentExConverter.CreateOpenXmlElement<DXO2013W.CommentEx>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.CommentsEx? CreateModelElement(DXO2013W.CommentsEx? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.CommentsEx();
      value.CommentExs = GetCommentExs(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013W.CommentsEx? openXmlElement, DMW.CommentsEx? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCommentExs(openXmlElement, value.CommentExs, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.CommentsEx? value)
    where OpenXmlElementType: DXO2013W.CommentsEx, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCommentExs(openXmlElement, value?.CommentExs);
      return openXmlElement;
    }
    return default;
  }
}
