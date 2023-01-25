namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Matrix Column.
/// </summary>
public static class MatrixColumnConverter
{
  /// <summary>
  /// Matrix Column Properties.
  /// </summary>
  private static DMMath.MatrixColumnProperties? GetMatrixColumnProperties(DXMath.MatrixColumn openXmlElement)
  {
    return DMXMath.MatrixColumnPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.MatrixColumnProperties>());
  }
  
  private static bool CmpMatrixColumnProperties(DXMath.MatrixColumn openXmlElement, DMMath.MatrixColumnProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.MatrixColumnPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.MatrixColumnProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMatrixColumnProperties(DXMath.MatrixColumn openXmlElement, DMMath.MatrixColumnProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.MatrixColumnProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.MatrixColumnPropertiesConverter.CreateOpenXmlElement<DXMath.MatrixColumnProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMMath.MatrixColumn? CreateModelElement(DXMath.MatrixColumn? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.MatrixColumn();
      value.MatrixColumnProperties = GetMatrixColumnProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.MatrixColumn? openXmlElement, DMMath.MatrixColumn? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMatrixColumnProperties(openXmlElement, value.MatrixColumnProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.MatrixColumn? value)
    where OpenXmlElementType: DXMath.MatrixColumn, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMatrixColumnProperties(openXmlElement, value?.MatrixColumnProperties);
      return openXmlElement;
    }
    return default;
  }
}
