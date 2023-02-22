namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Matrix Row.
/// </summary>
public static class MatrixRowConverter
{
  private static Collection<DMMath.Base>? GetBases(DXMath.MatrixRow openXmlElement)
  {
    var collection = new Collection<DMMath.Base>();
    foreach (var item in openXmlElement.Elements<DXMath.Base>())
    {
      var newItem = DMXMath.BaseConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpBases(DXMath.MatrixRow openXmlElement, Collection<DMMath.Base>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXMath.Base>();
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
        if (!DMXMath.BaseConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetBases(DXMath.MatrixRow openXmlElement, Collection<DMMath.Base>? value)
  {
    openXmlElement.RemoveAllChildren<DXMath.Base>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXMath.BaseConverter.CreateOpenXmlElement<DXMath.Base>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Math.MatrixRow? CreateModelElement(DXMath.MatrixRow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.MatrixRow();
      value.Bases = GetBases(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.MatrixRow? openXmlElement, DMMath.MatrixRow? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBases(openXmlElement, value.Bases, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.MatrixRow value)
    where OpenXmlElementType: DXMath.MatrixRow, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.MatrixRow openXmlElement, DMMath.MatrixRow value)
  {
    SetBases(openXmlElement, value?.Bases);
  }
}
