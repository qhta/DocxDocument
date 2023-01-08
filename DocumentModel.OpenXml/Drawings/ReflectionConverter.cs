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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBlurRadius(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Start Opacity
  /// </summary>
  public static Int32? GetStartOpacity(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetStartOpacity(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Start Position
  /// </summary>
  public static Int32? GetStartPosition(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetStartPosition(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// End Alpha
  /// </summary>
  public static Int32? GetEndAlpha(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEndAlpha(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// End Position
  /// </summary>
  public static Int32? GetEndPosition(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEndPosition(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Distance
  /// </summary>
  public static Int64? GetDistance(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDistance(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Direction
  /// </summary>
  public static Int32? GetDirection(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDirection(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Fade Direction
  /// </summary>
  public static Int32? GetFadeDirection(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFadeDirection(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Horizontal Ratio
  /// </summary>
  public static Int32? GetHorizontalRatio(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHorizontalRatio(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Vertical Ratio
  /// </summary>
  public static Int32? GetVerticalRatio(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVerticalRatio(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Horizontal Skew
  /// </summary>
  public static Int32? GetHorizontalSkew(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHorizontalSkew(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Vertical Skew
  /// </summary>
  public static Int32? GetVerticalSkew(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVerticalSkew(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRotateWithShape(DocumentFormat.OpenXml.Drawing.Reflection? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
