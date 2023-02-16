namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CommentsExtensible Class.
/// </summary>
public static class CommentsExtensibleConverter
{
  private static Collection<DMW.CommentExtensible>? GetCommentExtensibles(DXO2021WComtExt.CommentsExtensible openXmlElement)
  {
    var collection = new Collection<DMW.CommentExtensible>();
    foreach (var item in openXmlElement.Elements<DXO2021WComtExt.CommentExtensible>())
    {
      var newItem = DMXW.CommentExtensibleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpCommentExtensibles(DXO2021WComtExt.CommentsExtensible openXmlElement, Collection<DMW.CommentExtensible>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXO2021WComtExt.CommentExtensible>();
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
        if (!DMXW.CommentExtensibleConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetCommentExtensibles(DXO2021WComtExt.CommentsExtensible openXmlElement, Collection<DMW.CommentExtensible>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2021WComtExt.CommentExtensible>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.CommentExtensibleConverter.CreateOpenXmlElement<DXO2021WComtExt.CommentExtensible>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMW.ExtensionList? GetExtensionList(DXO2021WComtExt.CommentsExtensible openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2021WComtExt.ExtensionList>();
    if (element != null)
      return DMXW.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO2021WComtExt.CommentsExtensible openXmlElement, DMW.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXW.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021WComtExt.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXO2021WComtExt.CommentsExtensible openXmlElement, DMW.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021WComtExt.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ExtensionListConverter.CreateOpenXmlElement<DXO2021WComtExt.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.CommentsExtensible? CreateModelElement(DXO2021WComtExt.CommentsExtensible? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.CommentsExtensible();
      value.CommentExtensibles = GetCommentExtensibles(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2021WComtExt.CommentsExtensible? openXmlElement, DMW.CommentsExtensible? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCommentExtensibles(openXmlElement, value.CommentExtensibles, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.CommentsExtensible? value)
    where OpenXmlElementType: DXO2021WComtExt.CommentsExtensible, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCommentExtensibles(openXmlElement, value?.CommentExtensibles);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
