namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.CommentEx"/> class from/to OpenXml converter
/// </summary>
public static class CommentsExConverter
{
  #region Items conversion.
  private static void GetCommentsEx(DMW.CommentsEx collection, DXO13W.CommentsEx openXmlElement)
  {
    foreach (var item in openXmlElement.Elements<DXO13W.CommentEx>())
    {
      var newItem = DMXW.CommentExConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
  }
  
  private static bool CmpCommentsEx(DXO13W.CommentsEx openXmlElement, DMW.CommentsEx? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXO13W.CommentEx>();
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
        if (!DMXW.CommentExConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetCommentsEx(DXO13W.CommentsEx openXmlElement, DMW.CommentsEx? value)
  {
    openXmlElement.RemoveAllChildren<DXO13W.CommentEx>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.CommentExConverter.CreateOpenXmlElement<DXO13W.CommentEx>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  #endregion

  #region CommentsEx model conversion.
  public static DMW.CommentsEx? CreateModelElement(DXO13W.CommentsEx? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.CommentsEx();
      GetCommentsEx(model, openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13W.CommentsEx? openXmlElement, DMW.CommentsEx? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpCommentsEx(openXmlElement, model, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXO13W.CommentsEx CreateOpenXmlElement(DMW.CommentsEx model)
  {
    var openXmlElement = new DXO13W.CommentsEx();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13W.CommentsEx openXmlElement, DMW.CommentsEx model)
  {
    SetCommentsEx(openXmlElement, model);
  }
  #endregion
}
