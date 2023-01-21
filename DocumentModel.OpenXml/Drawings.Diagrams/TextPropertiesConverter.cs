namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Text Properties.
/// </summary>
public static class TextPropertiesConverter
{
  /// <summary>
  /// Apply 3D shape properties.
  /// </summary>
  private static DMDraws.Shape3DType? GetShape3DType(DXDrawDgms.TextProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Shape3DType>();
    if (itemElement != null)
      return DMXDraws.Shape3DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShape3DType(DXDrawDgms.TextProperties openXmlElement, DMDraws.Shape3DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Shape3DType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Shape3DTypeConverter.CreateOpenXmlElement<DXDraw.Shape3DType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// No text in 3D scene.
  /// </summary>
  private static DMDraws.FlatText? GetFlatText(DXDrawDgms.TextProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.FlatText>();
    if (itemElement != null)
      return DMXDraws.FlatTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFlatText(DXDrawDgms.TextProperties openXmlElement, DMDraws.FlatText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.FlatText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.FlatTextConverter.CreateOpenXmlElement<DXDraw.FlatText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsDgms.TextProperties? CreateModelElement(DXDrawDgms.TextProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.TextProperties();
      value.Shape3DType = GetShape3DType(openXmlElement);
      value.FlatText = GetFlatText(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.TextProperties? value)
    where OpenXmlElementType: DXDrawDgms.TextProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShape3DType(openXmlElement, value?.Shape3DType);
      SetFlatText(openXmlElement, value?.FlatText);
      return openXmlElement;
    }
    return default;
  }
}
