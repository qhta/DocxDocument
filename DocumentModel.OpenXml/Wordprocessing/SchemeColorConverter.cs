namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SchemeColor Class.
/// </summary>
public static class SchemeColorConverter
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.Wordprocessing.SchemeColorKind? GetVal(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.SchemeColorValues, DocumentModel.Wordprocessing.SchemeColorKind>(openXmlElement?.Val?.Value);
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement, DocumentModel.Wordprocessing.SchemeColorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Val = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.SchemeColorValues, DocumentModel.Wordprocessing.SchemeColorKind>(value);
  }
  
  public static Int32? GetTint(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.Tint");
  }
  
  public static void SetTint(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.Tint");
  }
  
  public static Int32? GetShade(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.Shade");
  }
  
  public static void SetShade(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.Shade");
  }
  
  public static Int32? GetAlpha(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.Alpha");
  }
  
  public static void SetAlpha(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.Alpha");
  }
  
  public static Int32? GetHueModulation(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.HueModulation");
  }
  
  public static void SetHueModulation(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.HueModulation");
  }
  
  public static Int32? GetSaturation(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.Saturation");
  }
  
  public static void SetSaturation(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.Saturation");
  }
  
  public static Int32? GetSaturationOffset(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.SaturationOffset");
  }
  
  public static void SetSaturationOffset(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.SaturationOffset");
  }
  
  public static Int32? GetSaturationModulation(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.SaturationModulation");
  }
  
  public static void SetSaturationModulation(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.SaturationModulation");
  }
  
  public static Int32? GetLuminance(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.Luminance");
  }
  
  public static void SetLuminance(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.Luminance");
  }
  
  public static Int32? GetLuminanceOffset(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.LuminanceOffset");
  }
  
  public static void SetLuminanceOffset(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.LuminanceOffset");
  }
  
  public static Int32? GetLuminanceModulation(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.LuminanceModulation");
  }
  
  public static void SetLuminanceModulation(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.LuminanceModulation");
  }
  
  public static DocumentModel.Wordprocessing.SchemeColor? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SchemeColor();
      value.Val = GetVal(openXmlElement);
      value.Tint = GetTint(openXmlElement);
      value.Shade = GetShade(openXmlElement);
      value.Alpha = GetAlpha(openXmlElement);
      value.HueModulation = GetHueModulation(openXmlElement);
      value.Saturation = GetSaturation(openXmlElement);
      value.SaturationOffset = GetSaturationOffset(openXmlElement);
      value.SaturationModulation = GetSaturationModulation(openXmlElement);
      value.Luminance = GetLuminance(openXmlElement);
      value.LuminanceOffset = GetLuminanceOffset(openXmlElement);
      value.LuminanceModulation = GetLuminanceModulation(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SchemeColor? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.SchemeColor, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
