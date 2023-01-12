namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Reflection Effect.
/// </summary>
public static class ReflectionConverter
{
  /// <summary>
  /// Blur Radius
  /// </summary>
  public static Int64? GetBlurRadius(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    return openXmlElement?.BlurRadius?.Value;
  }
  
  public static void SetBlurRadius(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.BlurRadius = value;
  }
  
  /// <summary>
  /// Start Opacity
  /// </summary>
  public static Int32? GetStartOpacity(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    return openXmlElement?.StartOpacity?.Value;
  }
  
  public static void SetStartOpacity(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.StartOpacity = value;
  }
  
  /// <summary>
  /// Start Position
  /// </summary>
  public static Int32? GetStartPosition(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    return openXmlElement?.StartPosition?.Value;
  }
  
  public static void SetStartPosition(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.StartPosition = value;
  }
  
  /// <summary>
  /// End Alpha
  /// </summary>
  public static Int32? GetEndAlpha(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    return openXmlElement?.EndAlpha?.Value;
  }
  
  public static void SetEndAlpha(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.EndAlpha = value;
  }
  
  /// <summary>
  /// End Position
  /// </summary>
  public static Int32? GetEndPosition(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    return openXmlElement?.EndPosition?.Value;
  }
  
  public static void SetEndPosition(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.EndPosition = value;
  }
  
  /// <summary>
  /// Distance
  /// </summary>
  public static Int64? GetDistance(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    return openXmlElement?.Distance?.Value;
  }
  
  public static void SetDistance(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Distance = value;
  }
  
  /// <summary>
  /// Direction
  /// </summary>
  public static Int32? GetDirection(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    return openXmlElement?.Direction?.Value;
  }
  
  public static void SetDirection(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Direction = value;
  }
  
  /// <summary>
  /// Fade Direction
  /// </summary>
  public static Int32? GetFadeDirection(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    return openXmlElement?.FadeDirection?.Value;
  }
  
  public static void SetFadeDirection(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FadeDirection = value;
  }
  
  /// <summary>
  /// Horizontal Ratio
  /// </summary>
  public static Int32? GetHorizontalRatio(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    return openXmlElement?.HorizontalRatio?.Value;
  }
  
  public static void SetHorizontalRatio(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalRatio = value;
  }
  
  /// <summary>
  /// Vertical Ratio
  /// </summary>
  public static Int32? GetVerticalRatio(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    return openXmlElement?.VerticalRatio?.Value;
  }
  
  public static void SetVerticalRatio(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalRatio = value;
  }
  
  /// <summary>
  /// Horizontal Skew
  /// </summary>
  public static Int32? GetHorizontalSkew(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    return openXmlElement?.HorizontalSkew?.Value;
  }
  
  public static void SetHorizontalSkew(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalSkew = value;
  }
  
  /// <summary>
  /// Vertical Skew
  /// </summary>
  public static Int32? GetVerticalSkew(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    return openXmlElement?.VerticalSkew?.Value;
  }
  
  public static void SetVerticalSkew(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalSkew = value;
  }
  
  /// <summary>
  /// Shadow Alignment
  /// </summary>
  public static DocumentModel.Drawings.RectangleAlignmentKind? GetAlignment(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues, DocumentModel.Drawings.RectangleAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  public static void SetAlignment(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, DocumentModel.Drawings.RectangleAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues, DocumentModel.Drawings.RectangleAlignmentKind>(value);
  }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public static Boolean? GetRotateWithShape(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    return openXmlElement?.RotateWithShape?.Value;
  }
  
  public static void SetRotateWithShape(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RotateWithShape = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.RotateWithShape = null;
  }
  
  public static DocumentModel.Drawings.Reflection? CreateModelElement(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Reflection();
      value.BlurRadius = GetBlurRadius(openXmlElement);
      value.StartOpacity = GetStartOpacity(openXmlElement);
      value.StartPosition = GetStartPosition(openXmlElement);
      value.EndAlpha = GetEndAlpha(openXmlElement);
      value.EndPosition = GetEndPosition(openXmlElement);
      value.Distance = GetDistance(openXmlElement);
      value.Direction = GetDirection(openXmlElement);
      value.FadeDirection = GetFadeDirection(openXmlElement);
      value.HorizontalRatio = GetHorizontalRatio(openXmlElement);
      value.VerticalRatio = GetVerticalRatio(openXmlElement);
      value.HorizontalSkew = GetHorizontalSkew(openXmlElement);
      value.VerticalSkew = GetVerticalSkew(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      value.RotateWithShape = GetRotateWithShape(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Reflection? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Reflection, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBlurRadius(openXmlElement, value?.BlurRadius);
      SetStartOpacity(openXmlElement, value?.StartOpacity);
      SetStartPosition(openXmlElement, value?.StartPosition);
      SetEndAlpha(openXmlElement, value?.EndAlpha);
      SetEndPosition(openXmlElement, value?.EndPosition);
      SetDistance(openXmlElement, value?.Distance);
      SetDirection(openXmlElement, value?.Direction);
      SetFadeDirection(openXmlElement, value?.FadeDirection);
      SetHorizontalRatio(openXmlElement, value?.HorizontalRatio);
      SetVerticalRatio(openXmlElement, value?.VerticalRatio);
      SetHorizontalSkew(openXmlElement, value?.HorizontalSkew);
      SetVerticalSkew(openXmlElement, value?.VerticalSkew);
      SetAlignment(openXmlElement, value?.Alignment);
      SetRotateWithShape(openXmlElement, value?.RotateWithShape);
      return openXmlElement;
    }
    return default;
  }
}
