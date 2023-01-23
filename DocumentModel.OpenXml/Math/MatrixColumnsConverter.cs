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
    return true;
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
    return openXmlElement == null && value == null;
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
