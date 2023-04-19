namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.Matrix"/> class from/to OpenXml converter.
/// </summary>
public static class MatrixConverter
{
  #region Matrix Properties. conversion.
  private static DMM.MatrixProperties? GetMatrixProperties(DXM.Matrix openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.MatrixProperties>();
    if (element != null)
      return DMXM.MatrixPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMatrixProperties(DXM.Matrix openXmlElement, DMM.MatrixProperties? value, DiffList? diffs, string? objName)
  {
    return DMXM.MatrixPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.MatrixProperties>(), value, diffs, objName);
  }
  
  private static void SetMatrixProperties(DXM.Matrix openXmlElement, DMM.MatrixProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.MatrixProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.MatrixPropertiesConverter.CreateOpenXmlElement<DXM.MatrixProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region Matrix Rows conversion.
  private static void GetMatrixRows(ICollection<DMM.MatrixRow> collection, DXM.Matrix openXmlElement)
  {
    foreach (var item in openXmlElement.Elements<DXM.MatrixRow>())
    {
      var newItem = DMXM.MatrixRowConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
  }
  
  private static bool CmpMatrixRows(DXM.Matrix openXmlElement, IEnumerable<DMM.MatrixRow>? collection, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXM.MatrixRow>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = collection?.Count() ?? 0;
    if (collection != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = collection.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXM.MatrixRowConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && collection == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, collection);
    return false;
  }
  
  private static void SetMatrixRows(DXM.Matrix openXmlElement, IEnumerable<DMM.MatrixRow>? collection)
  {
    openXmlElement.RemoveAllChildren<DXM.MatrixRow>();
    if (collection != null)
    {
      foreach (var item in collection)
      {
        var newItem = DMXM.MatrixRowConverter.CreateOpenXmlElement<DXM.MatrixRow>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  #endregion

  #region Matrix model conversion.
  public static DMM.Matrix? CreateModelElement(DXM.Matrix? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.Matrix();
      model.MatrixProperties = GetMatrixProperties(openXmlElement);
      GetMatrixRows(model, openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.Matrix? openXmlElement, DMM.Matrix? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpMatrixProperties(openXmlElement, model.MatrixProperties, diffs, objName))
        ok = false;
      if (!CmpMatrixRows(openXmlElement, model, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXM.Matrix CreateOpenXmlElement(DMM.Matrix model)
  {
    var openXmlElement = new DXM.Matrix();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXM.Matrix openXmlElement, DMM.Matrix model)
  {
    SetMatrixProperties(openXmlElement, model.MatrixProperties);
    SetMatrixRows(openXmlElement, model);
    return true;
  }
  #endregion
}
