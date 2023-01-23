namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Shape Definition.
/// </summary>
public static class ShapeConverter
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  private static String? GetMacro(DXDrawChartDraw.Shape openXmlElement)
  {
    return openXmlElement?.Macro?.Value;
  }
  
  private static bool CmpMacro(DXDrawChartDraw.Shape openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Macro?.Value == value;
  }
  
  private static void SetMacro(DXDrawChartDraw.Shape openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Macro = new StringValue { Value = value };
    else
      openXmlElement.Macro = null;
  }
  
  /// <summary>
  /// Text Link
  /// </summary>
  private static String? GetTextLink(DXDrawChartDraw.Shape openXmlElement)
  {
    return openXmlElement?.TextLink?.Value;
  }
  
  private static bool CmpTextLink(DXDrawChartDraw.Shape openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.TextLink?.Value == value;
  }
  
  private static void SetTextLink(DXDrawChartDraw.Shape openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.TextLink = new StringValue { Value = value };
    else
      openXmlElement.TextLink = null;
  }
  
  /// <summary>
  /// Lock Text
  /// </summary>
  private static Boolean? GetLockText(DXDrawChartDraw.Shape openXmlElement)
  {
    return openXmlElement?.LockText?.Value;
  }
  
  private static bool CmpLockText(DXDrawChartDraw.Shape openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.LockText?.Value == value;
  }
  
  private static void SetLockText(DXDrawChartDraw.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LockText = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.LockText = null;
  }
  
  /// <summary>
  /// Publish to Server
  /// </summary>
  private static Boolean? GetPublished(DXDrawChartDraw.Shape openXmlElement)
  {
    return openXmlElement?.Published?.Value;
  }
  
  private static bool CmpPublished(DXDrawChartDraw.Shape openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Published?.Value == value;
  }
  
  private static void SetPublished(DXDrawChartDraw.Shape openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Published = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Published = null;
  }
  
  /// <summary>
  /// Non-Visual Shape Properties.
  /// </summary>
  private static DMDrawsChartDraw.NonVisualShapeProperties? GetNonVisualShapeProperties(DXDrawChartDraw.Shape openXmlElement)
  {
    return DMXDrawsChartDraw.NonVisualShapePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualShapeProperties>());
  }
  
  private static bool CmpNonVisualShapeProperties(DXDrawChartDraw.Shape openXmlElement, DMDrawsChartDraw.NonVisualShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.NonVisualShapePropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNonVisualShapeProperties(DXDrawChartDraw.Shape openXmlElement, DMDrawsChartDraw.NonVisualShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.NonVisualShapePropertiesConverter.CreateOpenXmlElement<DXDrawChartDraw.NonVisualShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  private static DMDrawsChartDraw.ShapeProperties? GetShapeProperties(DXDrawChartDraw.Shape openXmlElement)
  {
    return DMXDrawsChartDraw.ShapePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.ShapeProperties>());
  }
  
  private static bool CmpShapeProperties(DXDrawChartDraw.Shape openXmlElement, DMDrawsChartDraw.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.ShapePropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.ShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapeProperties(DXDrawChartDraw.Shape openXmlElement, DMDrawsChartDraw.ShapeProperties? value)
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
  /// Shape Style.
  /// </summary>
  private static DMDrawsChartDraw.Style? GetStyle(DXDrawChartDraw.Shape openXmlElement)
  {
    return DMXDrawsChartDraw.StyleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.Style>());
  }
  
  private static bool CmpStyle(DXDrawChartDraw.Shape openXmlElement, DMDrawsChartDraw.Style? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.StyleConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.Style>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStyle(DXDrawChartDraw.Shape openXmlElement, DMDrawsChartDraw.Style? value)
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
  
  /// <summary>
  /// Shape Text Body.
  /// </summary>
  private static DMDrawsChartDraw.TextBody? GetTextBody(DXDrawChartDraw.Shape openXmlElement)
  {
    return DMXDrawsChartDraw.TextBodyConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.TextBody>());
  }
  
  private static bool CmpTextBody(DXDrawChartDraw.Shape openXmlElement, DMDrawsChartDraw.TextBody? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.TextBodyConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawChartDraw.TextBody>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextBody(DXDrawChartDraw.Shape openXmlElement, DMDrawsChartDraw.TextBody? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.TextBody>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.TextBodyConverter.CreateOpenXmlElement<DXDrawChartDraw.TextBody>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraw.Shape? CreateModelElement(DXDrawChartDraw.Shape? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraw.Shape();
      value.Macro = GetMacro(openXmlElement);
      value.TextLink = GetTextLink(openXmlElement);
      value.LockText = GetLockText(openXmlElement);
      value.Published = GetPublished(openXmlElement);
      value.NonVisualShapeProperties = GetNonVisualShapeProperties(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.TextBody = GetTextBody(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawChartDraw.Shape? openXmlElement, DMDrawsChartDraw.Shape? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMacro(openXmlElement, value.Macro, diffs, objName))
        ok = false;
      if (!CmpTextLink(openXmlElement, value.TextLink, diffs, objName))
        ok = false;
      if (!CmpLockText(openXmlElement, value.LockText, diffs, objName))
        ok = false;
      if (!CmpPublished(openXmlElement, value.Published, diffs, objName))
        ok = false;
      if (!CmpNonVisualShapeProperties(openXmlElement, value.NonVisualShapeProperties, diffs, objName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName))
        ok = false;
      if (!CmpStyle(openXmlElement, value.Style, diffs, objName))
        ok = false;
      if (!CmpTextBody(openXmlElement, value.TextBody, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.Shape? value)
    where OpenXmlElementType: DXDrawChartDraw.Shape, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMacro(openXmlElement, value?.Macro);
      SetTextLink(openXmlElement, value?.TextLink);
      SetLockText(openXmlElement, value?.LockText);
      SetPublished(openXmlElement, value?.Published);
      SetNonVisualShapeProperties(openXmlElement, value?.NonVisualShapeProperties);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetStyle(openXmlElement, value?.Style);
      SetTextBody(openXmlElement, value?.TextBody);
      return openXmlElement;
    }
    return default;
  }
}
