namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.CommentEx"/> class from/to OpenXml converter
/// </summary>
public static class CommentsExConverter
{
  #region Items conversion.
  private static void GetCommentsEx(DMW.CommentsEx collection, DXO2013W.CommentsEx openXmlElement)
  {
    foreach (var item in openXmlElement.Elements<DXO2013W.CommentEx>())
    {
      var newItem = DMXW.CommentExConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
  }
  
  private static bool CmpCommentsEx(DXO2013W.CommentsEx openXmlElement, DMW.CommentsEx? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2013W.CommentEx>();
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
        if (!DMXW.CommentExConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetCommentsEx(DXO2013W.CommentsEx openXmlElement, DMW.CommentsEx? value)
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
  #endregion

  #region CommentsEx model conversion.
  public static DMW.CommentsEx? CreateModelElement(DXO2013W.CommentsEx? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.CommentsEx();
      GetCommentsEx(model, openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013W.CommentsEx? openXmlElement, DMW.CommentsEx? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpCommentsEx(openXmlElement, model, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.CommentsEx model)
    where OpenXmlElementType: DXO2013W.CommentsEx, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013W.CommentsEx openXmlElement, DMW.CommentsEx model)
  {
    SetCommentsEx(openXmlElement, model);
  }
  #endregion
}
