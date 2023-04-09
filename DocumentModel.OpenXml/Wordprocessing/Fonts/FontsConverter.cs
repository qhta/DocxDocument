namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.Fonts"/> class from/to OpenXml converter.
/// </summary>
public static class FontsConverter
{
  #region Fonts Items conversion.
  private static void GetItems(DXW.Fonts openXmlElement, ICollection<DMW.Font> collection)
  {
    foreach (var item in openXmlElement.Elements<DXW.Font>())
    {
      var newItem = DMXW.FontConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
  }
  
  private static bool CmpItems(DXW.Fonts openXmlElement, ICollection<DMW.Font>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.Font>();
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
        if (!DMXW.FontConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXW.Fonts openXmlElement, ICollection<DMW.Font>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.Font>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.FontConverter.CreateOpenXmlElement<DXW.Font>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  #endregion

  #region Fonts model conversion
  public static DMW.Fonts? CreateModelElement(DXW.Fonts? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.Fonts();
      GetItems(openXmlElement, model);
      if (model.Count == 0) return null;
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Fonts? openXmlElement, DMW.Fonts? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, model, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Fonts model)
    where OpenXmlElementType: DXW.Fonts, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Fonts openXmlElement, DMW.Fonts model)
  {
    SetItems(openXmlElement, model);
  }
  #endregion
}
