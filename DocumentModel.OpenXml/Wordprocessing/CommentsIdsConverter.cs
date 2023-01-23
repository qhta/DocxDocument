namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CommentsIds Class.
/// </summary>
public static class CommentsIdsConverter
{
  private static Collection<DMW.CommentId> GetCommentIds(DXO2019WCid.CommentsIds openXmlElement)
  {
    var collection = new Collection<DMW.CommentId>();
    foreach (var item in openXmlElement.Elements<DXO2019WCid.CommentId>())
    {
      var newItem = DMXW.CommentIdConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpCommentIds(DXO2019WCid.CommentsIds openXmlElement, Collection<DMW.CommentId>? value, DiffList? diffs, string? objName)
  {
    return true;
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.CommentsIds? value)
    where OpenXmlElementType: DXO2019WCid.CommentsIds, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCommentIds(openXmlElement, value?.CommentIds);
      return openXmlElement;
    }
    return default;
  }
}
