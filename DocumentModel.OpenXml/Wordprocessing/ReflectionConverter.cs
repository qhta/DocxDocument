namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Reflection Class.
/// </summary>
public static class ReflectionConverter
{
  /// <summary>
  /// blurRad, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetBlurRadius(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement)
  {
    return openXmlElement.BlurRadius?.Value;
  }
  
  private static void SetBlurRadius(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement, Int64? value)
  {
    openXmlElement.BlurRadius = value;
  }
  
  /// <summary>
  /// stA, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetStartingOpacity(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement)
  {
    return openXmlElement.StartingOpacity?.Value;
  }
  
  private static void SetStartingOpacity(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.StartingOpacity = value;
  }
  
  /// <summary>
  /// stPos, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetStartPosition(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement)
  {
    return openXmlElement.StartPosition?.Value;
  }
  
  private static void SetStartPosition(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.StartPosition = value;
  }
  
  /// <summary>
  /// endA, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetEndingOpacity(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement)
  {
    return openXmlElement.EndingOpacity?.Value;
  }
  
  private static void SetEndingOpacity(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.EndingOpacity = value;
  }
  
  /// <summary>
  /// endPos, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetEndPosition(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement)
  {
    return openXmlElement.EndPosition?.Value;
  }
  
  private static void SetEndPosition(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.EndPosition = value;
  }
  
  /// <summary>
  /// dist, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetDistanceFromText(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement)
  {
    return openXmlElement.DistanceFromText?.Value;
  }
  
  private static void SetDistanceFromText(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement, Int64? value)
  {
    openXmlElement.DistanceFromText = value;
  }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetDirectionAngle(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement)
  {
    return openXmlElement.DirectionAngle?.Value;
  }
  
  private static void SetDirectionAngle(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.DirectionAngle = value;
  }
  
  /// <summary>
  /// fadeDir, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetFadeDirection(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement)
  {
    return openXmlElement.FadeDirection?.Value;
  }
  
  private static void SetFadeDirection(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.FadeDirection = value;
  }
  
  /// <summary>
  /// sx, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetHorizontalScalingFactor(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement)
  {
    return openXmlElement.HorizontalScalingFactor?.Value;
  }
  
  private static void SetHorizontalScalingFactor(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalScalingFactor = value;
  }
  
  /// <summary>
  /// sy, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetVerticalScalingFactor(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement)
  {
    return openXmlElement.VerticalScalingFactor?.Value;
  }
  
  private static void SetVerticalScalingFactor(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.VerticalScalingFactor = value;
  }
  
  /// <summary>
  /// kx, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetHorizontalSkewAngle(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement)
  {
    return openXmlElement.HorizontalSkewAngle?.Value;
  }
  
  private static void SetHorizontalSkewAngle(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalSkewAngle = value;
  }
  
  /// <summary>
  /// ky, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetVerticalSkewAngle(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement)
  {
    return openXmlElement.VerticalSkewAngle?.Value;
  }
  
  private static void SetVerticalSkewAngle(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement, Int32? value)
  {
    openXmlElement.VerticalSkewAngle = value;
  }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  private static DocumentModel.Wordprocessing.RectangleAlignmentKind? GetAlignment(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues, DocumentModel.Wordprocessing.RectangleAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static void SetAlignment(DocumentFormat.OpenXml.Office2010.Word.Reflection openXmlElement, DocumentModel.Wordprocessing.RectangleAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues, DocumentModel.Wordprocessing.RectangleAlignmentKind>(value);
  }
  
  public static DocumentModel.Wordprocessing.Reflection? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Reflection();
      value.BlurRadius = GetBlurRadius(openXmlElement);
      value.StartingOpacity = GetStartingOpacity(openXmlElement);
      value.StartPosition = GetStartPosition(openXmlElement);
      value.EndingOpacity = GetEndingOpacity(openXmlElement);
      value.EndPosition = GetEndPosition(openXmlElement);
      value.DistanceFromText = GetDistanceFromText(openXmlElement);
      value.DirectionAngle = GetDirectionAngle(openXmlElement);
      value.FadeDirection = GetFadeDirection(openXmlElement);
      value.HorizontalScalingFactor = GetHorizontalScalingFactor(openXmlElement);
      value.VerticalScalingFactor = GetVerticalScalingFactor(openXmlElement);
      value.HorizontalSkewAngle = GetHorizontalSkewAngle(openXmlElement);
      value.VerticalSkewAngle = GetVerticalSkewAngle(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Reflection? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.Reflection, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBlurRadius(openXmlElement, value?.BlurRadius);
      SetStartingOpacity(openXmlElement, value?.StartingOpacity);
      SetStartPosition(openXmlElement, value?.StartPosition);
      SetEndingOpacity(openXmlElement, value?.EndingOpacity);
      SetEndPosition(openXmlElement, value?.EndPosition);
      SetDistanceFromText(openXmlElement, value?.DistanceFromText);
      SetDirectionAngle(openXmlElement, value?.DirectionAngle);
      SetFadeDirection(openXmlElement, value?.FadeDirection);
      SetHorizontalScalingFactor(openXmlElement, value?.HorizontalScalingFactor);
      SetVerticalScalingFactor(openXmlElement, value?.VerticalScalingFactor);
      SetHorizontalSkewAngle(openXmlElement, value?.HorizontalSkewAngle);
      SetVerticalSkewAngle(openXmlElement, value?.VerticalSkewAngle);
      SetAlignment(openXmlElement, value?.Alignment);
      return openXmlElement;
    }
    return default;
  }
}
