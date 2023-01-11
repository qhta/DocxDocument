namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Shadow Class.
/// </summary>
public static class Shadow2Converter
{
  /// <summary>
  /// blurRad, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetBlurRadius(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement)
  {
    return openXmlElement?.BlurRadius?.Value;
  }
  
  public static void SetBlurRadius(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.BlurRadius = value;
  }
  
  /// <summary>
  /// dist, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetDistanceFromText(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement)
  {
    return openXmlElement?.DistanceFromText?.Value;
  }
  
  public static void SetDistanceFromText(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromText = value;
  }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetDirectionAngle(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement)
  {
    return openXmlElement?.DirectionAngle?.Value;
  }
  
  public static void SetDirectionAngle(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DirectionAngle = value;
  }
  
  /// <summary>
  /// sx, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetHorizontalScalingFactor(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement)
  {
    return openXmlElement?.HorizontalScalingFactor?.Value;
  }
  
  public static void SetHorizontalScalingFactor(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalScalingFactor = value;
  }
  
  /// <summary>
  /// sy, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetVerticalScalingFactor(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement)
  {
    return openXmlElement?.VerticalScalingFactor?.Value;
  }
  
  public static void SetVerticalScalingFactor(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalScalingFactor = value;
  }
  
  /// <summary>
  /// kx, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetHorizontalSkewAngle(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement)
  {
    return openXmlElement?.HorizontalSkewAngle?.Value;
  }
  
  public static void SetHorizontalSkewAngle(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalSkewAngle = value;
  }
  
  /// <summary>
  /// ky, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetVerticalSkewAngle(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement)
  {
    return openXmlElement?.VerticalSkewAngle?.Value;
  }
  
  public static void SetVerticalSkewAngle(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalSkewAngle = value;
  }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.Wordprocessing.RectangleAlignmentKind? GetAlignment(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues, DocumentModel.Wordprocessing.RectangleAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  public static void SetAlignment(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement, DocumentModel.Wordprocessing.RectangleAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues, DocumentModel.Wordprocessing.RectangleAlignmentKind>(value);
  }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  public static DocumentModel.Wordprocessing.RgbColorModelHex? GetRgbColorModelHex(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RgbColorModelHexConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRgbColorModelHex(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement, DocumentModel.Wordprocessing.RgbColorModelHex? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public static DocumentModel.Wordprocessing.SchemeColor? GetSchemeColor(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SchemeColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SchemeColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSchemeColor(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement, DocumentModel.Wordprocessing.SchemeColor? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
