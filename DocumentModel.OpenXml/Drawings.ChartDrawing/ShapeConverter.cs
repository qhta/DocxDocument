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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualShapeProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraw.NonVisualShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.ShapeProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraw.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.Style>();
    if (itemElement != null)
      return DMXDrawsChartDraw.StyleConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.TextBody>();
    if (itemElement != null)
      return DMXDrawsChartDraw.TextBodyConverter.CreateModelElement(itemElement);
    return null;
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
