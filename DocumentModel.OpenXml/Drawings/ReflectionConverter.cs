namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Reflection Effect.
/// </summary>
public static class ReflectionConverter
{
  /// <summary>
  /// Blur Radius
  /// </summary>
  private static Int64? GetBlurRadius(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement)
  {
    return openXmlElement.BlurRadius?.Value;
  }
  
  private static void SetBlurRadius(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement, Int64? value)
  {
    openXmlElement.BlurRadius = value;
  }
  
  /// <summary>
  /// Start Opacity
  /// </summary>
  private static Int32? GetStartOpacity(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement)
  {
    return openXmlElement.StartOpacity?.Value;
  }
  
  private static void SetStartOpacity(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.StartOpacity = value;
  }
  
  /// <summary>
  /// Start Position
  /// </summary>
  private static Int32? GetStartPosition(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement)
  {
    return openXmlElement.StartPosition?.Value;
  }
  
  private static void SetStartPosition(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.StartPosition = value;
  }
  
  /// <summary>
  /// End Alpha
  /// </summary>
  private static Int32? GetEndAlpha(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement)
  {
    return openXmlElement.EndAlpha?.Value;
  }
  
  private static void SetEndAlpha(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.EndAlpha = value;
  }
  
  /// <summary>
  /// End Position
  /// </summary>
  private static Int32? GetEndPosition(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement)
  {
    return openXmlElement.EndPosition?.Value;
  }
  
  private static void SetEndPosition(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.EndPosition = value;
  }
  
  /// <summary>
  /// Distance
  /// </summary>
  private static Int64? GetDistance(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement)
  {
    return openXmlElement.Distance?.Value;
  }
  
  private static void SetDistance(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement, Int64? value)
  {
    openXmlElement.Distance = value;
  }
  
  /// <summary>
  /// Direction
  /// </summary>
  private static Int32? GetDirection(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement)
  {
    return openXmlElement.Direction?.Value;
  }
  
  private static void SetDirection(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.Direction = value;
  }
  
  /// <summary>
  /// Fade Direction
  /// </summary>
  private static Int32? GetFadeDirection(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement)
  {
    return openXmlElement.FadeDirection?.Value;
  }
  
  private static void SetFadeDirection(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.FadeDirection = value;
  }
  
  /// <summary>
  /// Horizontal Ratio
  /// </summary>
  private static Int32? GetHorizontalRatio(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement)
  {
    return openXmlElement.HorizontalRatio?.Value;
  }
  
  private static void SetHorizontalRatio(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalRatio = value;
  }
  
  /// <summary>
  /// Vertical Ratio
  /// </summary>
  private static Int32? GetVerticalRatio(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement)
  {
    return openXmlElement.VerticalRatio?.Value;
  }
  
  private static void SetVerticalRatio(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.VerticalRatio = value;
  }
  
  /// <summary>
  /// Horizontal Skew
  /// </summary>
  private static Int32? GetHorizontalSkew(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement)
  {
    return openXmlElement.HorizontalSkew?.Value;
  }
  
  private static void SetHorizontalSkew(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalSkew = value;
  }
  
  /// <summary>
  /// Vertical Skew
  /// </summary>
  private static Int32? GetVerticalSkew(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement)
  {
    return openXmlElement.VerticalSkew?.Value;
  }
  
  private static void SetVerticalSkew(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.VerticalSkew = value;
  }
  
  /// <summary>
  /// Shadow Alignment
  /// </summary>
  private static DocumentModel.Drawings.RectangleAlignmentKind? GetAlignment(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues, DocumentModel.Drawings.RectangleAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static void SetAlignment(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement, DocumentModel.Drawings.RectangleAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues, DocumentModel.Drawings.RectangleAlignmentKind>(value);
  }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  private static Boolean? GetRotateWithShape(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement)
  {
    return openXmlElement?.RotateWithShape?.Value;
  }
  
  private static void SetRotateWithShape(DocumentFormat.OpenXml.Drawing.Reflection openXmlElement, Boolean? value)
  {
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
