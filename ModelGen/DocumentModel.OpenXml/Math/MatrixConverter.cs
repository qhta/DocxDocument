namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Matrix Function.
/// </summary>
public static class MatrixConverter
{
  /// <summary>
  /// Matrix Properties.
  /// </summary>
  private static DMMath.MatrixProperties? GetMatrixProperties(DXMath.Matrix openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.MatrixProperties>();
    if (element != null)
      return DMXMath.MatrixPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMatrixProperties(DXMath.Matrix openXmlElement, DMMath.MatrixProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.MatrixPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.MatrixProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMatrixProperties(DXMath.Matrix openXmlElement, DMMath.MatrixProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.MatrixProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.MatrixPropertiesConverter.CreateOpenXmlElement<DXMath.MatrixProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMMath.MatrixRow>? GetMatrixRows(DXMath.Matrix openXmlElement)
  {
    var collection = new Collection<DMMath.MatrixRow>();
    foreach (var item in openXmlElement.Elements<DXMath.MatrixRow>())
    {
      var newItem = DMXMath.MatrixRowConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpMatrixRows(DXMath.Matrix openXmlElement, Collection<DMMath.MatrixRow>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXMath.MatrixRow>();
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
        if (!DMXMath.MatrixRowConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetMatrixRows(DXMath.Matrix openXmlElement, Collection<DMMath.MatrixRow>? value)
  {
    openXmlElement.RemoveAllChildren<DXMath.MatrixRow>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXMath.MatrixRowConverter.CreateOpenXmlElement<DXMath.MatrixRow>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Math.Matrix? CreateModelElement(DXMath.Matrix? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Matrix();
      value.MatrixProperties = GetMatrixProperties(openXmlElement);
      value.MatrixRows = GetMatrixRows(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.Matrix? openXmlElement, DMMath.Matrix? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMatrixProperties(openXmlElement, value.MatrixProperties, diffs, objName))
        ok = false;
      if (!CmpMatrixRows(openXmlElement, value.MatrixRows, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.Matrix value)
    where OpenXmlElementType: DXMath.Matrix, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.Matrix openXmlElement, DMMath.Matrix value)
  {
    SetMatrixProperties(openXmlElement, value?.MatrixProperties);
    SetMatrixRows(openXmlElement, value?.MatrixRows);
  }
}
