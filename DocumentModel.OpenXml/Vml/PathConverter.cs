namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Path Class.
/// </summary>
public static class PathConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DXVml.Path openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXVml.Path openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Path Definition
  /// </summary>
  private static String? GetValue(DXVml.Path openXmlElement)
  {
    return openXmlElement?.Value?.Value;
  }
  
  private static void SetValue(DXVml.Path openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Value = new StringValue { Value = value };
    else
      openXmlElement.Value = null;
  }
  
  /// <summary>
  /// Limo Stretch Point
  /// </summary>
  private static String? GetLimo(DXVml.Path openXmlElement)
  {
    return openXmlElement?.Limo?.Value;
  }
  
  private static void SetLimo(DXVml.Path openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Limo = new StringValue { Value = value };
    else
      openXmlElement.Limo = null;
  }
  
  /// <summary>
  /// Text Box Bounding Box
  /// </summary>
  private static String? GetTextboxRectangle(DXVml.Path openXmlElement)
  {
    return openXmlElement?.TextboxRectangle?.Value;
  }
  
  private static void SetTextboxRectangle(DXVml.Path openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.TextboxRectangle = new StringValue { Value = value };
    else
      openXmlElement.TextboxRectangle = null;
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  private static Boolean? GetAllowFill(DXVml.Path openXmlElement)
  {
    return openXmlElement?.AllowFill?.Value;
  }
  
  private static void SetAllowFill(DXVml.Path openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowFill = value;
    else
      openXmlElement.AllowFill = null;
  }
  
  /// <summary>
  /// Stroke Toggle
  /// </summary>
  private static Boolean? GetAllowStroke(DXVml.Path openXmlElement)
  {
    return openXmlElement?.AllowStroke?.Value;
  }
  
  private static void SetAllowStroke(DXVml.Path openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowStroke = value;
    else
      openXmlElement.AllowStroke = null;
  }
  
  /// <summary>
  /// Shadow Toggle
  /// </summary>
  private static Boolean? GetAllowShading(DXVml.Path openXmlElement)
  {
    return openXmlElement?.AllowShading?.Value;
  }
  
  private static void SetAllowShading(DXVml.Path openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowShading = value;
    else
      openXmlElement.AllowShading = null;
  }
  
  /// <summary>
  /// Arrowhead Display Toggle
  /// </summary>
  private static Boolean? GetShowArrowhead(DXVml.Path openXmlElement)
  {
    return openXmlElement?.ShowArrowhead?.Value;
  }
  
  private static void SetShowArrowhead(DXVml.Path openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowArrowhead = value;
    else
      openXmlElement.ShowArrowhead = null;
  }
  
  /// <summary>
  /// Gradient Shape Toggle
  /// </summary>
  private static Boolean? GetAllowGradientShape(DXVml.Path openXmlElement)
  {
    return openXmlElement?.AllowGradientShape?.Value;
  }
  
  private static void SetAllowGradientShape(DXVml.Path openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowGradientShape = value;
    else
      openXmlElement.AllowGradientShape = null;
  }
  
  /// <summary>
  /// Text Path Toggle
  /// </summary>
  private static Boolean? GetAllowTextPath(DXVml.Path openXmlElement)
  {
    return openXmlElement?.AllowTextPath?.Value;
  }
  
  private static void SetAllowTextPath(DXVml.Path openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowTextPath = value;
    else
      openXmlElement.AllowTextPath = null;
  }
  
  /// <summary>
  /// Inset Stroke From Path Flag
  /// </summary>
  private static Boolean? GetAllowInsetPen(DXVml.Path openXmlElement)
  {
    return openXmlElement?.AllowInsetPen?.Value;
  }
  
  private static void SetAllowInsetPen(DXVml.Path openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowInsetPen = value;
    else
      openXmlElement.AllowInsetPen = null;
  }
  
  /// <summary>
  /// Connection Point Type
  /// </summary>
  private static DMVml.ConnectKind? GetConnectionPointType(DXVml.Path openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.ConnectValues, DMVml.ConnectKind>(openXmlElement?.ConnectionPointType?.Value);
  }
  
  private static void SetConnectionPointType(DXVml.Path openXmlElement, DMVml.ConnectKind? value)
  {
    openXmlElement.ConnectionPointType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectValues, DMVml.ConnectKind>(value);
  }
  
  /// <summary>
  /// Connection Points
  /// </summary>
  private static String? GetConnectionPoints(DXVml.Path openXmlElement)
  {
    return openXmlElement?.ConnectionPoints?.Value;
  }
  
  private static void SetConnectionPoints(DXVml.Path openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ConnectionPoints = new StringValue { Value = value };
    else
      openXmlElement.ConnectionPoints = null;
  }
  
  /// <summary>
  /// Connection Point Connect Angles
  /// </summary>
  private static String? GetConnectAngles(DXVml.Path openXmlElement)
  {
    return openXmlElement?.ConnectAngles?.Value;
  }
  
  private static void SetConnectAngles(DXVml.Path openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ConnectAngles = new StringValue { Value = value };
    else
      openXmlElement.ConnectAngles = null;
  }
  
  /// <summary>
  /// Extrusion Toggle
  /// </summary>
  private static Boolean? GetAllowExtrusion(DXVml.Path openXmlElement)
  {
    return openXmlElement?.AllowExtrusion?.Value;
  }
  
  private static void SetAllowExtrusion(DXVml.Path openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllowExtrusion = value;
    else
      openXmlElement.AllowExtrusion = null;
  }
  
  public static DMVml.Path? CreateModelElement(DXVml.Path? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.Path();
      value.Id = GetId(openXmlElement);
      value.Value = GetValue(openXmlElement);
      value.Limo = GetLimo(openXmlElement);
      value.TextboxRectangle = GetTextboxRectangle(openXmlElement);
      value.AllowFill = GetAllowFill(openXmlElement);
      value.AllowStroke = GetAllowStroke(openXmlElement);
      value.AllowShading = GetAllowShading(openXmlElement);
      value.ShowArrowhead = GetShowArrowhead(openXmlElement);
      value.AllowGradientShape = GetAllowGradientShape(openXmlElement);
      value.AllowTextPath = GetAllowTextPath(openXmlElement);
      value.AllowInsetPen = GetAllowInsetPen(openXmlElement);
      value.ConnectionPointType = GetConnectionPointType(openXmlElement);
      value.ConnectionPoints = GetConnectionPoints(openXmlElement);
      value.ConnectAngles = GetConnectAngles(openXmlElement);
      value.AllowExtrusion = GetAllowExtrusion(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.Path? value)
    where OpenXmlElementType: DXVml.Path, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetValue(openXmlElement, value?.Value);
      SetLimo(openXmlElement, value?.Limo);
      SetTextboxRectangle(openXmlElement, value?.TextboxRectangle);
      SetAllowFill(openXmlElement, value?.AllowFill);
      SetAllowStroke(openXmlElement, value?.AllowStroke);
      SetAllowShading(openXmlElement, value?.AllowShading);
      SetShowArrowhead(openXmlElement, value?.ShowArrowhead);
      SetAllowGradientShape(openXmlElement, value?.AllowGradientShape);
      SetAllowTextPath(openXmlElement, value?.AllowTextPath);
      SetAllowInsetPen(openXmlElement, value?.AllowInsetPen);
      SetConnectionPointType(openXmlElement, value?.ConnectionPointType);
      SetConnectionPoints(openXmlElement, value?.ConnectionPoints);
      SetConnectAngles(openXmlElement, value?.ConnectAngles);
      SetAllowExtrusion(openXmlElement, value?.AllowExtrusion);
      return openXmlElement;
    }
    return default;
  }
}
