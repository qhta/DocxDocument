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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.MatrixColumnProperties>();
    if (itemElement != null)
      return DMXMath.MatrixColumnPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
