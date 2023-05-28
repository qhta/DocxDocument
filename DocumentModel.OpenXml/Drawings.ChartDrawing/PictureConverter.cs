namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Defines the Picture Class.
/// </summary>
public static class PictureConverter
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  private static String? GetMacro(DXDCD.Picture openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Macro);
  }
  
  private static bool CmpMacro(DXDCD.Picture openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Macro, value, diffs, objName, "Macro");
  }
  
  private static void SetMacro(DXDCD.Picture openXmlElement, String? value)
  {
    openXmlElement.Macro = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Publish to Server
  /// </summary>
  private static Boolean? GetPublished(DXDCD.Picture openXmlElement)
  {
    return openXmlElement?.Published?.Value;
  }
  
  private static bool CmpPublished(DXDCD.Picture openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Published?.Value == value) return true;
    diffs?.Add(objName, "Published", openXmlElement?.Published?.Value, value);
    return false;
  }
  
  private static void SetPublished(DXDCD.Picture openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Published = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Published = null;
  }
  
  /// <summary>
  /// Non-Visual Picture Properties.
  /// </summary>
  private static DMDCD.NonVisualPictureProperties? GetNonVisualPictureProperties(DXDCD.Picture openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.NonVisualPictureProperties>();
    if (element != null)
      return DMXDCD.NonVisualPicturePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualPictureProperties(DXDCD.Picture openXmlElement, DMDCD.NonVisualPictureProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCD.NonVisualPicturePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.NonVisualPictureProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetNonVisualPictureProperties(DXDCD.Picture openXmlElement, DMDCD.NonVisualPictureProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.NonVisualPictureProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.NonVisualPicturePropertiesConverter.CreateOpenXmlElement<DXDCD.NonVisualPictureProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Picture Fill.
  /// </summary>
  private static DMDCD.BlipFill? GetBlipFill(DXDCD.Picture openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.BlipFill>();
    if (element != null)
      return DMXDCD.BlipFillConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBlipFill(DXDCD.Picture openXmlElement, DMDCD.BlipFill? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCD.BlipFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.BlipFill>(), value, diffs, objName, propName);
  }
  
  private static void SetBlipFill(DXDCD.Picture openXmlElement, DMDCD.BlipFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.BlipFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.BlipFillConverter.CreateOpenXmlElement<DXDCD.BlipFill>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DMDCD.ShapeProperties? GetShapeProperties(DXDCD.Picture openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.ShapeProperties>();
    if (element != null)
      return DMXDCD.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXDCD.Picture openXmlElement, DMDCD.ShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCD.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.ShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeProperties(DXDCD.Picture openXmlElement, DMDCD.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.ShapePropertiesConverter.CreateOpenXmlElement<DXDCD.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Style.
  /// </summary>
  private static DMDCD.Style? GetStyle(DXDCD.Picture openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.Style>();
    if (element != null)
      return DMXDCD.StyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStyle(DXDCD.Picture openXmlElement, DMDCD.Style? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCD.StyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.Style>(), value, diffs, objName, propName);
  }
  
  private static void SetStyle(DXDCD.Picture openXmlElement, DMDCD.Style? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.Style>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.StyleConverter.CreateOpenXmlElement<DXDCD.Style>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.ChartDrawing.Picture? CreateModelElement(DXDCD.Picture? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.ChartDrawing.Picture();
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
  
  public static bool CompareModelElement(DXDCD.Picture? openXmlElement, DMDCD.Picture? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMacro(openXmlElement, value.Macro, diffs, objName, propName))
        ok = false;
      if (!CmpPublished(openXmlElement, value.Published, diffs, objName, propName))
        ok = false;
      if (!CmpNonVisualPictureProperties(openXmlElement, value.NonVisualPictureProperties, diffs, objName, propName))
        ok = false;
      if (!CmpBlipFill(openXmlElement, value.BlipFill, diffs, objName, propName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName, propName))
        ok = false;
      if (!CmpStyle(openXmlElement, value.Style, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCD.Picture value)
    where OpenXmlElementType: DXDCD.Picture, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDCD.Picture openXmlElement, DMDCD.Picture value)
  {
    SetMacro(openXmlElement, value?.Macro);
    SetPublished(openXmlElement, value?.Published);
    SetNonVisualPictureProperties(openXmlElement, value?.NonVisualPictureProperties);
    SetBlipFill(openXmlElement, value?.BlipFill);
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetStyle(openXmlElement, value?.Style);
  }
}
