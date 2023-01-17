namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Shadow Class.
/// </summary>
public static class Shadow2Converter
{
  /// <summary>
  /// blurRad, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetBlurRadius(DocumentFormat.OpenXml.Office2010.Word.Shadow openXmlElement)
  {
    return openXmlElement.BlurRadius?.Value;
  }
  
  private static void SetBlurRadius(DocumentFormat.OpenXml.Office2010.Word.Shadow openXmlElement, Int64? value)
  {
    openXmlElement.BlurRadius = value;
  }
  
  /// <summary>
  /// dist, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetDistanceFromText(DocumentFormat.OpenXml.Office2010.Word.Shadow openXmlElement)
  {
    return openXmlElement.DistanceFromText?.Value;
  }
  
  private static void SetDistanceFromText(DocumentFormat.OpenXml.Office2010.Word.Shadow openXmlElement, Int64? value)
  {
    openXmlElement.DistanceFromText = value;
  }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetDirectionAngle(DocumentFormat.OpenXml.Office2010.Word.Shadow openXmlElement)
  {
    return openXmlElement.DirectionAngle?.Value;
  }
  
  private static void SetDirectionAngle(DocumentFormat.OpenXml.Office2010.Word.Shadow openXmlElement, Int32? value)
  {
    openXmlElement.DirectionAngle = value;
  }
  
  /// <summary>
  /// sx, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetHorizontalScalingFactor(DocumentFormat.OpenXml.Office2010.Word.Shadow openXmlElement)
  {
    return openXmlElement.HorizontalScalingFactor?.Value;
  }
  
  private static void SetHorizontalScalingFactor(DocumentFormat.OpenXml.Office2010.Word.Shadow openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalScalingFactor = value;
  }
  
  /// <summary>
  /// sy, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetVerticalScalingFactor(DocumentFormat.OpenXml.Office2010.Word.Shadow openXmlElement)
  {
    return openXmlElement.VerticalScalingFactor?.Value;
  }
  
  private static void SetVerticalScalingFactor(DocumentFormat.OpenXml.Office2010.Word.Shadow openXmlElement, Int32? value)
  {
    openXmlElement.VerticalScalingFactor = value;
  }
  
  /// <summary>
  /// kx, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetHorizontalSkewAngle(DocumentFormat.OpenXml.Office2010.Word.Shadow openXmlElement)
  {
    return openXmlElement.HorizontalSkewAngle?.Value;
  }
  
  private static void SetHorizontalSkewAngle(DocumentFormat.OpenXml.Office2010.Word.Shadow openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalSkewAngle = value;
  }
  
  /// <summary>
  /// ky, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetVerticalSkewAngle(DocumentFormat.OpenXml.Office2010.Word.Shadow openXmlElement)
  {
    return openXmlElement.VerticalSkewAngle?.Value;
  }
  
  private static void SetVerticalSkewAngle(DocumentFormat.OpenXml.Office2010.Word.Shadow openXmlElement, Int32? value)
  {
    openXmlElement.VerticalSkewAngle = value;
  }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  private static DocumentModel.Wordprocessing.RectangleAlignmentKind? GetAlignment(DocumentFormat.OpenXml.Office2010.Word.Shadow openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues, DocumentModel.Wordprocessing.RectangleAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static void SetAlignment(DocumentFormat.OpenXml.Office2010.Word.Shadow openXmlElement, DocumentModel.Wordprocessing.RectangleAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues, DocumentModel.Wordprocessing.RectangleAlignmentKind>(value);
  }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  private static DocumentModel.Wordprocessing.RgbColorModelHex? GetRgbColorModelHex(DocumentFormat.OpenXml.Office2010.Word.Shadow openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RgbColorModelHexConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRgbColorModelHex(DocumentFormat.OpenXml.Office2010.Word.Shadow openXmlElement, DocumentModel.Wordprocessing.RgbColorModelHex? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.RgbColorModelHexConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  private static DocumentModel.Wordprocessing.SchemeColor? GetSchemeColor(DocumentFormat.OpenXml.Office2010.Word.Shadow openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SchemeColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SchemeColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSchemeColor(DocumentFormat.OpenXml.Office2010.Word.Shadow openXmlElement, DocumentModel.Wordprocessing.SchemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SchemeColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.SchemeColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.SchemeColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.Shadow2? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Shadow2();
      value.BlurRadius = GetBlurRadius(openXmlElement);
      value.DistanceFromText = GetDistanceFromText(openXmlElement);
      value.DirectionAngle = GetDirectionAngle(openXmlElement);
      value.HorizontalScalingFactor = GetHorizontalScalingFactor(openXmlElement);
      value.VerticalScalingFactor = GetVerticalScalingFactor(openXmlElement);
      value.HorizontalSkewAngle = GetHorizontalSkewAngle(openXmlElement);
      value.VerticalSkewAngle = GetVerticalSkewAngle(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Shadow2? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.Shadow, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBlurRadius(openXmlElement, value?.BlurRadius);
      SetDistanceFromText(openXmlElement, value?.DistanceFromText);
      SetDirectionAngle(openXmlElement, value?.DirectionAngle);
      SetHorizontalScalingFactor(openXmlElement, value?.HorizontalScalingFactor);
      SetVerticalScalingFactor(openXmlElement, value?.VerticalScalingFactor);
      SetHorizontalSkewAngle(openXmlElement, value?.HorizontalSkewAngle);
      SetVerticalSkewAngle(openXmlElement, value?.VerticalSkewAngle);
      SetAlignment(openXmlElement, value?.Alignment);
      SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
      SetSchemeColor(openXmlElement, value?.SchemeColor);
      return openXmlElement;
    }
    return default;
  }
}
