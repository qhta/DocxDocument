namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Scheme Color.
/// </summary>
public static class SchemeColorConverter
{
  /// <summary>
  /// Value
  /// </summary>
  public static DocumentModel.Drawings.SchemeColorKind? GetVal(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.SchemeColorValues, DocumentModel.Drawings.SchemeColorKind>(openXmlElement?.Val?.Value);
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, DocumentModel.Drawings.SchemeColorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Val = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.SchemeColorValues, DocumentModel.Drawings.SchemeColorKind>(value);
  }
  
  public static Int32? GetTint(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTint(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetShade(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShade(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetComplement(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetComplement(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetInverse(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetInverse(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetGray(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGray(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetAlpha(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlpha(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetAlphaOffset(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlphaOffset(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetAlphaModulation(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlphaModulation(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetHue(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHue(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetHueOffset(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHueOffset(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetHueModulation(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHueModulation(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetSaturation(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSaturation(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetSaturationOffset(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSaturationOffset(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetSaturationModulation(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSaturationModulation(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetLuminance(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLuminance(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetLuminanceOffset(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLuminanceOffset(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetLuminanceModulation(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLuminanceModulation(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetRed(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRed(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetRedOffset(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRedOffset(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetRedModulation(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRedModulation(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetGreen(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGreen(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetGreenOffset(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGreenOffset(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetGreenModulation(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGreenModulation(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetBlue(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBlue(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetBlueOffset(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBlueOffset(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetBlueModulation(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBlueModulation(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetGamma(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGamma(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetInverseGamma(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetInverseGamma(DocumentFormat.OpenXml.Drawing.SchemeColor? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
