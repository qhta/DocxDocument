namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.Comments"/> class from/to OpenXml converter.
/// </summary>
public static class CommentsConverter
{
  #region Items conversion.
  private static void GetComments(DMW.Comments collection, DXW.Comments openXmlElement)
  {
    foreach (var item in openXmlElement.Elements<DXW.Comment>())
    {
      var newItem = DMXW.CommentConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
  }
  
  private static bool CmpComments(DXW.Comments openXmlElement, DMW.Comments? collection, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXW.Comment>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = collection?.Count() ?? 0;
    if (collection != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = collection.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXW.CommentConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && collection == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, collection);
    return false;
  }

  private static void SetComments(DXW.Comments openXmlElement, DMW.Comments? collection)
  {
    openXmlElement.RemoveAllChildren<DXW.Comment>();
    if (collection != null)
    {
      foreach (var item in collection)
      {
        var newItem = DMXW.CommentConverter.CreateOpenXmlElement<DXW.Comment>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  #endregion

  #region Commments model conversion.
  public static DMW.Comments? CreateModelElement(DXW.Comments? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.Comments();
      GetComments(model, openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Comments? openXmlElement, DMW.Comments? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpComments(openXmlElement, model, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXW.Comments CreateOpenXmlElement(DMW.Comments model)
  {
    var openXmlElement = new DXW.Comments();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Comments openXmlElement, DMW.Comments model)
  {
    SetComments(openXmlElement, model);
  }
  #endregion
}
