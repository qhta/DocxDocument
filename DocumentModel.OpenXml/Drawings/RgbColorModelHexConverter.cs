namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// RGB Color Model - Hex Variant.
/// </summary>
public static class RgbColorModelHexConverter
{
  /// <summary>
  /// Value
  /// </summary>
  public static DocumentModel.HexBinary? GetVal(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  /// <summary>
  /// legacySpreadsheetColorIndex, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetLegacySpreadsheetColorIndex(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    return openXmlElement?.LegacySpreadsheetColorIndex?.Value;
  }
  
  public static void SetLegacySpreadsheetColorIndex(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.LegacySpreadsheetColorIndex = value;
  }
  
  public static Int32? GetTint(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Tint");
  }
  
  public static void SetTint(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Tint");
  }
  
  public static Int32? GetShade(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Shade");
  }
  
  public static void SetShade(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Shade");
  }
  
  public static Boolean? GetComplement(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Complement>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetComplement(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Complement>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.Complement();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetInverse(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Inverse>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetInverse(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Inverse>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.Inverse();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetGray(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Gray>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetGray(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Gray>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.Gray();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Int32? GetAlpha(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Alpha");
  }
  
  public static void SetAlpha(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Alpha");
  }
  
  public static Int32? GetAlphaOffset(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.AlphaOffset");
  }
  
  public static void SetAlphaOffset(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.AlphaOffset");
  }
  
  public static Int32? GetAlphaModulation(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.AlphaModulation");
  }
  
  public static void SetAlphaModulation(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.AlphaModulation");
  }
  
  public static Int32? GetHue(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Hue");
  }
  
  public static void SetHue(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Hue");
  }
  
  public static Int32? GetHueOffset(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.HueOffset");
  }
  
  public static void SetHueOffset(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.HueOffset");
  }
  
  public static Int32? GetHueModulation(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.HueModulation");
  }
  
  public static void SetHueModulation(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.HueModulation");
  }
  
  public static Int32? GetSaturation(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Saturation");
  }
  
  public static void SetSaturation(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Saturation");
  }
  
  public static Int32? GetSaturationOffset(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.SaturationOffset");
  }
  
  public static void SetSaturationOffset(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.SaturationOffset");
  }
  
  public static Int32? GetSaturationModulation(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.SaturationModulation");
  }
  
  public static void SetSaturationModulation(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.SaturationModulation");
  }
  
  public static Int32? GetLuminance(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Luminance");
  }
  
  public static void SetLuminance(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Luminance");
  }
  
  public static Int32? GetLuminanceOffset(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.LuminanceOffset");
  }
  
  public static void SetLuminanceOffset(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.LuminanceOffset");
  }
  
  public static Int32? GetLuminanceModulation(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.LuminanceModulation");
  }
  
  public static void SetLuminanceModulation(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.LuminanceModulation");
  }
  
  public static Int32? GetRed(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Red");
  }
  
  public static void SetRed(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Red");
  }
  
  public static Int32? GetRedOffset(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.RedOffset");
  }
  
  public static void SetRedOffset(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.RedOffset");
  }
  
  public static Int32? GetRedModulation(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.RedModulation");
  }
  
  public static void SetRedModulation(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.RedModulation");
  }
  
  public static Int32? GetGreen(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Green");
  }
  
  public static void SetGreen(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Green");
  }
  
  public static Int32? GetGreenOffset(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.GreenOffset");
  }
  
  public static void SetGreenOffset(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.GreenOffset");
  }
  
  public static Int32? GetGreenModulation(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.GreenModulation");
  }
  
  public static void SetGreenModulation(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.GreenModulation");
  }
  
  public static Int32? GetBlue(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Blue");
  }
  
  public static void SetBlue(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Blue");
  }
  
  public static Int32? GetBlueOffset(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.BlueOffset");
  }
  
  public static void SetBlueOffset(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.BlueOffset");
  }
  
  public static Int32? GetBlueModulation(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.BlueModulation");
  }
  
  public static void SetBlueModulation(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.BlueModulation");
  }
  
  public static Boolean? GetGamma(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Gamma>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetGamma(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Gamma>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.Gamma();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetInverseGamma(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.InverseGamma>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetInverseGamma(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.InverseGamma>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.InverseGamma();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.RgbColorModelHex? CreateModelElement(DocumentFormat.OpenXml.Drawing.RgbColorModelHex? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.RgbColorModelHex();
      value.Val = GetVal(openXmlElement);
      value.LegacySpreadsheetColorIndex = GetLegacySpreadsheetColorIndex(openXmlElement);
      value.Tint = GetTint(openXmlElement);
      value.Shade = GetShade(openXmlElement);
      value.Complement = GetComplement(openXmlElement);
      value.Inverse = GetInverse(openXmlElement);
      value.Gray = GetGray(openXmlElement);
      value.Alpha = GetAlpha(openXmlElement);
      value.AlphaOffset = GetAlphaOffset(openXmlElement);
      value.AlphaModulation = GetAlphaModulation(openXmlElement);
      value.Hue = GetHue(openXmlElement);
      value.HueOffset = GetHueOffset(openXmlElement);
      value.HueModulation = GetHueModulation(openXmlElement);
      value.Saturation = GetSaturation(openXmlElement);
      value.SaturationOffset = GetSaturationOffset(openXmlElement);
      value.SaturationModulation = GetSaturationModulation(openXmlElement);
      value.Luminance = GetLuminance(openXmlElement);
      value.LuminanceOffset = GetLuminanceOffset(openXmlElement);
      value.LuminanceModulation = GetLuminanceModulation(openXmlElement);
      value.Red = GetRed(openXmlElement);
      value.RedOffset = GetRedOffset(openXmlElement);
      value.RedModulation = GetRedModulation(openXmlElement);
      value.Green = GetGreen(openXmlElement);
      value.GreenOffset = GetGreenOffset(openXmlElement);
      value.GreenModulation = GetGreenModulation(openXmlElement);
      value.Blue = GetBlue(openXmlElement);
      value.BlueOffset = GetBlueOffset(openXmlElement);
      value.BlueModulation = GetBlueModulation(openXmlElement);
      value.Gamma = GetGamma(openXmlElement);
      value.InverseGamma = GetInverseGamma(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.RgbColorModelHex? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.RgbColorModelHex, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
