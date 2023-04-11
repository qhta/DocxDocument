namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CommentsExtensible Class.
/// </summary>
public static class CommentsExtensibleConverter
{
  #region CommentsExtensible collection conversion.
  public static DMW.CommentsExtensible GetCommentsExtensibles(DXO2021WComtExt.CommentsExtensible openXmlElement)
  {
    var collection = new DMW.CommentsExtensible();
    foreach (var item in openXmlElement.Elements<DXO2021WComtExt.CommentExtensible>())
    {
      var newItem = DMXW.CommentExtensibleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }

  public static bool CmpCommentsExtensibles(DXO2021WComtExt.CommentsExtensible? openXmlElement, DMW.CommentsExtensible? collection, DiffList? diffs, string? objName)
  {
    int origElementsCount = 0;
    if (openXmlElement != null)
    {
      var origElements = openXmlElement.Elements<DXO2021WComtExt.CommentExtensible>();
      origElementsCount = origElements.Count();
      var modelElementsCount = collection?.Count() ?? 0;
      if (collection != null)
      {
        if (origElementsCount != modelElementsCount)
        {
          diffs?.Add(objName, openXmlElement.GetType().Name + ".Count", origElementsCount, modelElementsCount);
          return false;
        }
        var ok = true;
        var modelEnumerator = collection.GetEnumerator();
        foreach (var origItem in origElements)
        {
          modelEnumerator.MoveNext();
          var modelItem = modelEnumerator.Current;
          if (!DMXW.CommentExtensibleConverter.CompareModelElement(origItem, modelItem, diffs, objName))
            ok = false;
        }
        return ok;
      }
    }
    if (origElementsCount == 0 && collection == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, collection);
    return false;
  }

  public static void SetCommentsExtensibles(DXO2021WComtExt.CommentsExtensible openXmlElement, DMW.CommentsExtensible collection)
  {
    openXmlElement.RemoveAllChildren<DXO2021WComtExt.CommentExtensible>();
    if (collection != null)
    {
      foreach (var item in collection)
      {
        var newItem = DMXW.CommentExtensibleConverter.CreateOpenXmlElement<DXO2021WComtExt.CommentExtensible>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  #endregion

  #region ExtensionList collection conversion.
  public static DMW.ExtensionList? GetExtensionList(DXO2021WComtExt.CommentsExtensible openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2021WComtExt.ExtensionList>();
    if (element != null)
      return DMXW.ExtensionListConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpExtensionList(DXO2021WComtExt.CommentsExtensible openXmlElement, DMW.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXW.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021WComtExt.ExtensionList>(), value, diffs, objName);
  }

  public static void SetExtensionList(DXO2021WComtExt.CommentsExtensible openXmlElement, DMW.ExtensionList? value)
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
  #endregion

}
