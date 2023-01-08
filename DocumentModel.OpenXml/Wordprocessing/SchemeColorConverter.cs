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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTint(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetShade(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShade(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetAlpha(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlpha(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetHueModulation(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHueModulation(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetSaturation(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSaturation(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetSaturationOffset(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSaturationOffset(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetSaturationModulation(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSaturationModulation(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetLuminance(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLuminance(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetLuminanceOffset(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLuminanceOffset(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetLuminanceModulation(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLuminanceModulation(DocumentFormat.OpenXml.Office2010.Word.SchemeColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
