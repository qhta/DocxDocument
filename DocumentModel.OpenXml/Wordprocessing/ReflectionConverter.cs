namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Reflection Class.
/// </summary>
public static class ReflectionConverter
{
  /// <summary>
  /// blurRad, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetBlurRadius(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement)
  {
    return openXmlElement?.BlurRadius?.Value;
  }
  
  public static void SetBlurRadius(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.BlurRadius = value;
  }
  
  /// <summary>
  /// stA, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetStartingOpacity(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement)
  {
    return openXmlElement?.StartingOpacity?.Value;
  }
  
  public static void SetStartingOpacity(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.StartingOpacity = value;
  }
  
  /// <summary>
  /// stPos, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetStartPosition(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement)
  {
    return openXmlElement?.StartPosition?.Value;
  }
  
  public static void SetStartPosition(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.StartPosition = value;
  }
  
  /// <summary>
  /// endA, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetEndingOpacity(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement)
  {
    return openXmlElement?.EndingOpacity?.Value;
  }
  
  public static void SetEndingOpacity(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.EndingOpacity = value;
  }
  
  /// <summary>
  /// endPos, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetEndPosition(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement)
  {
    return openXmlElement?.EndPosition?.Value;
  }
  
  public static void SetEndPosition(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.EndPosition = value;
  }
  
  /// <summary>
  /// dist, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetDistanceFromText(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement)
  {
    return openXmlElement?.DistanceFromText?.Value;
  }
  
  public static void SetDistanceFromText(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromText = value;
  }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetDirectionAngle(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement)
  {
    return openXmlElement?.DirectionAngle?.Value;
  }
  
  public static void SetDirectionAngle(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DirectionAngle = value;
  }
  
  /// <summary>
  /// fadeDir, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetFadeDirection(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement)
  {
    return openXmlElement?.FadeDirection?.Value;
  }
  
  public static void SetFadeDirection(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FadeDirection = value;
  }
  
  /// <summary>
  /// sx, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetHorizontalScalingFactor(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement)
  {
    return openXmlElement?.HorizontalScalingFactor?.Value;
  }
  
  public static void SetHorizontalScalingFactor(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalScalingFactor = value;
  }
  
  /// <summary>
  /// sy, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetVerticalScalingFactor(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement)
  {
    return openXmlElement?.VerticalScalingFactor?.Value;
  }
  
  public static void SetVerticalScalingFactor(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalScalingFactor = value;
  }
  
  /// <summary>
  /// kx, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetHorizontalSkewAngle(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement)
  {
    return openXmlElement?.HorizontalSkewAngle?.Value;
  }
  
  public static void SetHorizontalSkewAngle(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalSkewAngle = value;
  }
  
  /// <summary>
  /// ky, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetVerticalSkewAngle(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement)
  {
    return openXmlElement?.VerticalSkewAngle?.Value;
  }
  
  public static void SetVerticalSkewAngle(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalSkewAngle = value;
  }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.Wordprocessing.RectangleAlignmentKind? GetAlignment(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues, DocumentModel.Wordprocessing.RectangleAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  public static void SetAlignment(DocumentFormat.OpenXml.Office2010.Word.Reflection? openXmlElement, DocumentModel.Wordprocessing.RectangleAlignmentKind? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
