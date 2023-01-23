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
  
  private static bool CmpMacro(DXDrawChartDraw.Picture openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Macro?.Value == value;
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
  
  private static bool CmpPublished(DXDrawChartDraw.Picture openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Published?.Value == value;
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
    return DMXDrawsChartDraw.NonVisualPicturePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualPictureProperties>());
  }
  
  private static bool CmpNonVisualPictureProperties(DXDrawChartDraw.Picture openXmlElement, DMDrawsChartDraw.NonVisualPictureProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.NonVisualPicturePropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualPictureProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsChartDraw.BlipFillConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.BlipFill>());
  }
  
  private static bool CmpBlipFill(DXDrawChartDraw.Picture openXmlElement, DMDrawsChartDraw.BlipFill? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.BlipFillConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.BlipFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsChartDraw.ShapePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.ShapeProperties>());
  }
  
  private static bool CmpShapeProperties(DXDrawChartDraw.Picture openXmlElement, DMDrawsChartDraw.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.ShapePropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.ShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsChartDraw.StyleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.Style>());
  }
  
  private static bool CmpStyle(DXDrawChartDraw.Picture openXmlElement, DMDrawsChartDraw.Style? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.StyleConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.Style>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXDrawChartDraw.Picture? openXmlElement, DMDrawsChartDraw.Picture? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMacro(openXmlElement, value.Macro, diffs, objName))
        ok = false;
      if (!CmpPublished(openXmlElement, value.Published, diffs, objName))
        ok = false;
      if (!CmpNonVisualPictureProperties(openXmlElement, value.NonVisualPictureProperties, diffs, objName))
        ok = false;
      if (!CmpBlipFill(openXmlElement, value.BlipFill, diffs, objName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName))
        ok = false;
      if (!CmpStyle(openXmlElement, value.Style, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
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
