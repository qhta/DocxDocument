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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBlurRadius(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// dist, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetDistanceFromText(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDistanceFromText(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetDirectionAngle(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDirectionAngle(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// sx, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetHorizontalScalingFactor(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHorizontalScalingFactor(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// sy, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetVerticalScalingFactor(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVerticalScalingFactor(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// kx, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetHorizontalSkewAngle(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHorizontalSkewAngle(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ky, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetVerticalSkewAngle(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVerticalSkewAngle(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRgbColorModelHex(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement, DocumentModel.Wordprocessing.RgbColorModelHex? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public static DocumentModel.Wordprocessing.SchemeColor? GetSchemeColor(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSchemeColor(DocumentFormat.OpenXml.Office2010.Word.Shadow? openXmlElement, DocumentModel.Wordprocessing.SchemeColor? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
