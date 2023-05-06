namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.MatrixColumns"/> class from/to OpenXml converter.
/// </summary>
public static class MatrixColumnsConverter
{
  #region ArgumentProperties conversion.
  private static void GetItems(ICollection<DMM.MatrixColumn> collection, DXM.MatrixColumns openXmlElement)
  {
    foreach (var item in openXmlElement.Elements<DXM.MatrixColumn>())
    {
      var newItem = DMXM.MatrixColumnConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
  }
  
  private static bool CmpItems(DXM.MatrixColumns openXmlElement, IEnumerable<DMM.MatrixColumn>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXM.MatrixColumn>();
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
        if (!DMXM.MatrixColumnConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXM.MatrixColumns openXmlElement, IEnumerable<DMM.MatrixColumn>? value)
  {
    openXmlElement.RemoveAllChildren<DXM.MatrixColumn>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXM.MatrixColumnConverter.CreateOpenXmlElement<DXM.MatrixColumn>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  #endregion

  #region MatrixColumns model conversion.
  public static DMM.MatrixColumns? CreateModelElement(DXM.MatrixColumns? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.MatrixColumns();
      GetItems(model, openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.MatrixColumns? openXmlElement, DMM.MatrixColumns? model, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.MatrixColumns model)
    where OpenXmlElementType: DXM.MatrixColumns, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXM.MatrixColumns openXmlElement, DMM.MatrixColumns model)
  {
    SetItems(openXmlElement, model);
  }
  #endregion
}
