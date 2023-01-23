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
    return DMXMath.MatrixPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.MatrixProperties>());
  }
  
  private static bool CmpMatrixProperties(DXMath.Matrix openXmlElement, DMMath.MatrixProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.MatrixPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.MatrixProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  private static Collection<DMMath.MatrixRow> GetMatrixRows(DXMath.Matrix openXmlElement)
  {
    var collection = new Collection<DMMath.MatrixRow>();
    foreach (var item in openXmlElement.Elements<DXMath.MatrixRow>())
    {
      var newItem = DMXMath.MatrixRowConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpMatrixRows(DXMath.Matrix openXmlElement, Collection<DMMath.MatrixRow>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXMath.MatrixRow>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().ToString()+".Count", origElementsCount, modelElementsCount);
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
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
  
  public static DMMath.Matrix? CreateModelElement(DXMath.Matrix? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.Matrix();
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
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.Matrix? value)
    where OpenXmlElementType: DXMath.Matrix, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMatrixProperties(openXmlElement, value?.MatrixProperties);
      SetMatrixRows(openXmlElement, value?.MatrixRows);
      return openXmlElement;
    }
    return default;
  }
}
