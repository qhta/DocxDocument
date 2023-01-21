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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.MatrixProperties>();
    if (itemElement != null)
      return DMXMath.MatrixPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
