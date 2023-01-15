using DocumentFormat.OpenXml.Vml.Office;
using DocumentModel.Vml;
using Path = DocumentFormat.OpenXml.Vml.Path;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Defines the Path Class.
/// </summary>
public static class PathConverter
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public static String? GetId(Path? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(Path? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   Path Definition
  /// </summary>
  public static String? GetValue(Path? openXmlElement)
  {
    return openXmlElement?.Value?.Value;
  }

  public static void SetValue(Path? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Value = new StringValue { Value = value };
      else
        openXmlElement.Value = null;
  }

  /// <summary>
  ///   Limo Stretch Point
  /// </summary>
  public static String? GetLimo(Path? openXmlElement)
  {
    return openXmlElement?.Limo?.Value;
  }

  public static void SetLimo(Path? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Limo = new StringValue { Value = value };
      else
        openXmlElement.Limo = null;
  }

  /// <summary>
  ///   Text Box Bounding Box
  /// </summary>
  public static String? GetTextboxRectangle(Path? openXmlElement)
  {
    return openXmlElement?.TextboxRectangle?.Value;
  }

  public static void SetTextboxRectangle(Path? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.TextboxRectangle = new StringValue { Value = value };
      else
        openXmlElement.TextboxRectangle = null;
  }

  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  public static Boolean? GetAllowFill(Path? openXmlElement)
  {
    return openXmlElement?.AllowFill?.Value;
  }

  public static void SetAllowFill(Path? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AllowFill = value;
      else
        openXmlElement.AllowFill = null;
  }

  /// <summary>
  ///   Stroke Toggle
  /// </summary>
  public static Boolean? GetAllowStroke(Path? openXmlElement)
  {
    return openXmlElement?.AllowStroke?.Value;
  }

  public static void SetAllowStroke(Path? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AllowStroke = value;
      else
        openXmlElement.AllowStroke = null;
  }

  /// <summary>
  ///   Shadow Toggle
  /// </summary>
  public static Boolean? GetAllowShading(Path? openXmlElement)
  {
    return openXmlElement?.AllowShading?.Value;
  }

  public static void SetAllowShading(Path? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AllowShading = value;
      else
        openXmlElement.AllowShading = null;
  }

  /// <summary>
  ///   Arrowhead Display Toggle
  /// </summary>
  public static Boolean? GetShowArrowhead(Path? openXmlElement)
  {
    return openXmlElement?.ShowArrowhead?.Value;
  }

  public static void SetShowArrowhead(Path? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShowArrowhead = value;
      else
        openXmlElement.ShowArrowhead = null;
  }

  /// <summary>
  ///   Gradient Shape Toggle
  /// </summary>
  public static Boolean? GetAllowGradientShape(Path? openXmlElement)
  {
    return openXmlElement?.AllowGradientShape?.Value;
  }

  public static void SetAllowGradientShape(Path? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AllowGradientShape = value;
      else
        openXmlElement.AllowGradientShape = null;
  }

  /// <summary>
  ///   Text Path Toggle
  /// </summary>
  public static Boolean? GetAllowTextPath(Path? openXmlElement)
  {
    return openXmlElement?.AllowTextPath?.Value;
  }

  public static void SetAllowTextPath(Path? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AllowTextPath = value;
      else
        openXmlElement.AllowTextPath = null;
  }

  /// <summary>
  ///   Inset Stroke From Path Flag
  /// </summary>
  public static Boolean? GetAllowInsetPen(Path? openXmlElement)
  {
    return openXmlElement?.AllowInsetPen?.Value;
  }

  public static void SetAllowInsetPen(Path? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AllowInsetPen = value;
      else
        openXmlElement.AllowInsetPen = null;
  }

  /// <summary>
  ///   Connection Point Type
  /// </summary>
  public static ConnectKind? GetConnectionPointType(Path? openXmlElement)
  {
    return EnumValueConverter.GetValue<ConnectValues, ConnectKind>(openXmlElement?.ConnectionPointType?.Value);
  }

  public static void SetConnectionPointType(Path? openXmlElement, ConnectKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ConnectionPointType = EnumValueConverter.CreateEnumValue<ConnectValues, ConnectKind>(value);
  }

  /// <summary>
  ///   Connection Points
  /// </summary>
  public static String? GetConnectionPoints(Path? openXmlElement)
  {
    return openXmlElement?.ConnectionPoints?.Value;
  }

  public static void SetConnectionPoints(Path? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ConnectionPoints = new StringValue { Value = value };
      else
        openXmlElement.ConnectionPoints = null;
  }

  /// <summary>
  ///   Connection Point Connect Angles
  /// </summary>
  public static String? GetConnectAngles(Path? openXmlElement)
  {
    return openXmlElement?.ConnectAngles?.Value;
  }

  public static void SetConnectAngles(Path? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ConnectAngles = new StringValue { Value = value };
      else
        openXmlElement.ConnectAngles = null;
  }

  /// <summary>
  ///   Extrusion Toggle
  /// </summary>
  public static Boolean? GetAllowExtrusion(Path? openXmlElement)
  {
    return openXmlElement?.AllowExtrusion?.Value;
  }

  public static void SetAllowExtrusion(Path? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AllowExtrusion = value;
      else
        openXmlElement.AllowExtrusion = null;
  }

  public static DocumentModel.Vml.Path? CreateModelElement(Path? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Path();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Path? value)
    where OpenXmlElementType : Path, new()
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