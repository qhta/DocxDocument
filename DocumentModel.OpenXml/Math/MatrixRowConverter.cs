namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.MatrixRow"/> class from/to OpenXml converter.
/// </summary>
public static class MatrixRowConverter
{
  #region Bases conversion.
  private static void GetBases(ICollection<DMM.Argument> collection, DXM.MatrixRow openXmlElement)
  {
    foreach (var item in openXmlElement.Elements<DXM.Base>())
    {
      var newItem = DMXM.ArgumentConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
  }
  
  private static bool CmpBases(DXM.MatrixRow openXmlElement, IEnumerable<DMM.Argument>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXM.Base>();
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
        if (!DMXM.ArgumentConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetBases(DXM.MatrixRow openXmlElement, IEnumerable<DMM.Argument>? value)
  {
    openXmlElement.RemoveAllChildren<DXM.Base>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXM.ArgumentConverter.CreateOpenXmlElement(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  #endregion

  #region MatrixRow model conversion.
  public static DMM.MatrixRow? CreateModelElement(DXM.MatrixRow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.MatrixRow();
      GetBases(model, openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.MatrixRow? openXmlElement, DMM.MatrixRow? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpBases(openXmlElement, model, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.MatrixRow model)
    where OpenXmlElementType: DXM.MatrixRow, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXM.MatrixRow openXmlElement, DMM.MatrixRow model)
  {
    SetBases(openXmlElement, model);
  }
  #endregion
}
