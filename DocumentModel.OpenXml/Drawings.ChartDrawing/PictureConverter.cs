namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Defines the Picture Class.
/// </summary>
public static class PictureConverter
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  private static String? GetMacro(DXDrawChartDraw.Picture openXmlElement)
  {
    return openXmlElement?.Macro?.Value;
  }
  
  private static void SetMacro(DXDrawChartDraw.Picture openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Macro = new StringValue { Value = value };
    else
      openXmlElement.Macro = null;
  }
  
  /// <summary>
  /// Publish to Server
  /// </summary>
  private static Boolean? GetPublished(DXDrawChartDraw.Picture openXmlElement)
  {
    return openXmlElement?.Published?.Value;
  }
  
  private static void SetPublished(DXDrawChartDraw.Picture openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Published = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Published = null;
  }
  
  /// <summary>
  /// Non-Visual Picture Properties.
  /// </summary>
  private static DMDrawsChartDraw.NonVisualPictureProperties? GetNonVisualPictureProperties(DXDrawChartDraw.Picture openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualPictureProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraw.NonVisualPicturePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualPictureProperties(DXDrawChartDraw.Picture openXmlElement, DMDrawsChartDraw.NonVisualPictureProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualPictureProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.NonVisualPicturePropertiesConverter.CreateOpenXmlElement<DXDrawChartDraw.NonVisualPictureProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Picture Fill.
  /// </summary>
  private static DMDrawsChartDraw.BlipFill? GetBlipFill(DXDrawChartDraw.Picture openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.BlipFill>();
    if (itemElement != null)
      return DMXDrawsChartDraw.BlipFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBlipFill(DXDrawChartDraw.Picture openXmlElement, DMDrawsChartDraw.BlipFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.BlipFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.BlipFillConverter.CreateOpenXmlElement<DXDrawChartDraw.BlipFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DMDrawsChartDraw.ShapeProperties? GetShapeProperties(DXDrawChartDraw.Picture openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.ShapeProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraw.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeProperties(DXDrawChartDraw.Picture openXmlElement, DMDrawsChartDraw.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.ShapePropertiesConverter.CreateOpenXmlElement<DXDrawChartDraw.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Style.
  /// </summary>
  private static DMDrawsChartDraw.Style? GetStyle(DXDrawChartDraw.Picture openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.Style>();
    if (itemElement != null)
      return DMXDrawsChartDraw.StyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStyle(DXDrawChartDraw.Picture openXmlElement, DMDrawsChartDraw.Style? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.Style>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.StyleConverter.CreateOpenXmlElement<DXDrawChartDraw.Style>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraw.Picture? CreateModelElement(DXDrawChartDraw.Picture? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraw.Picture();
      value.Macro = GetMacro(openXmlElement);
      value.Published = GetPublished(openXmlElement);
      value.NonVisualPictureProperties = GetNonVisualPictureProperties(openXmlElement);
      value.BlipFill = GetBlipFill(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.Picture? value)
    where OpenXmlElementType: DXDrawChartDraw.Picture, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMacro(openXmlElement, value?.Macro);
      SetPublished(openXmlElement, value?.Published);
      SetNonVisualPictureProperties(openXmlElement, value?.NonVisualPictureProperties);
      SetBlipFill(openXmlElement, value?.BlipFill);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetStyle(openXmlElement, value?.Style);
      return openXmlElement;
    }
    return default;
  }
}
