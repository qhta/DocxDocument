namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// System Color.
/// </summary>
public static class SystemColorConverter
{
  /// <summary>
  /// Value
  /// </summary>
  public static DocumentModel.Drawings.SystemColorKind? GetVal(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.SystemColorValues, DocumentModel.Drawings.SystemColorKind>(openXmlElement?.Val?.Value);
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, DocumentModel.Drawings.SystemColorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Val = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.SystemColorValues, DocumentModel.Drawings.SystemColorKind>(value);
  }
  
  /// <summary>
  /// Last Color
  /// </summary>
  public static DocumentModel.HexBinary? GetLastColor(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLastColor(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetTint(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTint(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetShade(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShade(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetComplement(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetComplement(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetInverse(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetInverse(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetGray(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGray(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetAlpha(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlpha(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetAlphaOffset(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlphaOffset(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetAlphaModulation(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlphaModulation(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetHue(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHue(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetHueOffset(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHueOffset(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetHueModulation(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHueModulation(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetSaturation(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSaturation(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetSaturationOffset(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSaturationOffset(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetSaturationModulation(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSaturationModulation(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetLuminance(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLuminance(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetLuminanceOffset(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLuminanceOffset(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetLuminanceModulation(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLuminanceModulation(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetRed(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRed(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetRedOffset(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRedOffset(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetRedModulation(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRedModulation(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetGreen(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGreen(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetGreenOffset(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGreenOffset(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetGreenModulation(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGreenModulation(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetBlue(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBlue(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetBlueOffset(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBlueOffset(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetBlueModulation(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBlueModulation(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetGamma(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGamma(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetInverseGamma(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetInverseGamma(DocumentFormat.OpenXml.Drawing.SystemColor? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
