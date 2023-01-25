namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Matrix Columns.
/// </summary>
public static class MatrixColumnsConverter
{
  private static Collection<DMMath.MatrixColumn> GetItems(DXMath.MatrixColumns openXmlElement)
  {
    var collection = new Collection<DMMath.MatrixColumn>();
    foreach (var item in openXmlElement.Elements<DXMath.MatrixColumn>())
    {
      var newItem = DMXMath.MatrixColumnConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpItems(DXMath.MatrixColumns openXmlElement, Collection<DMMath.MatrixColumn>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXMath.MatrixColumn>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
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
        if (!DMXMath.MatrixColumnConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXMath.MatrixColumns openXmlElement, Collection<DMMath.MatrixColumn>? value)
  {
    openXmlElement.RemoveAllChildren<DXMath.MatrixColumn>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXMath.MatrixColumnConverter.CreateOpenXmlElement<DXMath.MatrixColumn>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMMath.MatrixColumns? CreateModelElement(DXMath.MatrixColumns? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.MatrixColumns();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.MatrixColumns? openXmlElement, DMMath.MatrixColumns? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.MatrixColumns? value)
    where OpenXmlElementType: DXMath.MatrixColumns, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}
