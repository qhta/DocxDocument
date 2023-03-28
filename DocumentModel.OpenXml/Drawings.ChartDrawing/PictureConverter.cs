namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Defines the Picture Class converter from/to OpenXml.
///</summary>
public static class PictureConverter
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  private static String? GetMacro(DXDrawChartDraw.Picture openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Macro);
  }
  
  private static bool CmpMacro(DXDrawChartDraw.Picture openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Macro, value, diffs, objName, "Macro");
  }
  
  private static void SetMacro(DXDrawChartDraw.Picture openXmlElement, String? value)
  {
    openXmlElement.Macro = StringValueConverter.CreateStringValue(value);
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
    if (openXmlElement?.Published?.Value == value) return true;
    diffs?.Add(objName, "Published", openXmlElement?.Published?.Value, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualPictureProperties>();
    if (element != null)
      return DMXDrawsChartDraw.NonVisualPicturePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualPictureProperties(DXDrawChartDraw.Picture openXmlElement, DMDrawsChartDraw.NonVisualPictureProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.NonVisualPicturePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualPictureProperties>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.BlipFill>();
    if (element != null)
      return DMXDrawsChartDraw.BlipFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBlipFill(DXDrawChartDraw.Picture openXmlElement, DMDrawsChartDraw.BlipFill? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.BlipFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.BlipFill>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.ShapeProperties>();
    if (element != null)
      return DMXDrawsChartDraw.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXDrawChartDraw.Picture openXmlElement, DMDrawsChartDraw.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.ShapeProperties>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.Style>();
    if (element != null)
      return DMXDrawsChartDraw.StyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStyle(DXDrawChartDraw.Picture openXmlElement, DMDrawsChartDraw.Style? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.StyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.Style>(), value, diffs, objName);
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
  
  public static DocumentModel.Drawings.ChartDrawing.Picture? CreateModelElement(DXDrawChartDraw.Picture? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.Picture();
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.Picture value)
    where OpenXmlElementType: DXDrawChartDraw.Picture, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawChartDraw.Picture openXmlElement, DMDrawsChartDraw.Picture value)
  {
    SetMacro(openXmlElement, value?.Macro);
    SetPublished(openXmlElement, value?.Published);
    SetNonVisualPictureProperties(openXmlElement, value?.NonVisualPictureProperties);
    SetBlipFill(openXmlElement, value?.BlipFill);
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetStyle(openXmlElement, value?.Style);
  }
}
