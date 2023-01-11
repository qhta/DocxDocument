namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Hue, Saturation, Luminance Color Model.
/// </summary>
public static class HslColorConverter
{
  /// <summary>
  /// Hue
  /// </summary>
  public static Int32? GetHueValue(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    return openXmlElement?.HueValue?.Value;
  }
  
  public static void SetHueValue(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HueValue = value;
  }
  
  /// <summary>
  /// Saturation
  /// </summary>
  public static Int32? GetSatValue(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    return openXmlElement?.SatValue?.Value;
  }
  
  public static void SetSatValue(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.SatValue = value;
  }
  
  /// <summary>
  /// Luminance
  /// </summary>
  public static Int32? GetLumValue(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    return openXmlElement?.LumValue?.Value;
  }
  
  public static void SetLumValue(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.LumValue = value;
  }
  
  public static Int32? GetTint(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Tint");
  }
  
  public static void SetTint(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Tint");
  }
  
  public static Int32? GetShade(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Shade");
  }
  
  public static void SetShade(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Shade");
  }
  
  public static Boolean? GetComplement(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Complement>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetComplement(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Boolean? value)
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
  
  public static Boolean? GetInverse(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Inverse>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetInverse(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Boolean? value)
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
  
  public static Boolean? GetGray(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Gray>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetGray(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Boolean? value)
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
  
  public static Int32? GetAlpha(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Alpha");
  }
  
  public static void SetAlpha(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Alpha");
  }
  
  public static Int32? GetAlphaOffset(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.AlphaOffset");
  }
  
  public static void SetAlphaOffset(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.AlphaOffset");
  }
  
  public static Int32? GetAlphaModulation(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.AlphaModulation");
  }
  
  public static void SetAlphaModulation(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.AlphaModulation");
  }
  
  public static Int32? GetHue(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Hue");
  }
  
  public static void SetHue(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Hue");
  }
  
  public static Int32? GetHueOffset(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.HueOffset");
  }
  
  public static void SetHueOffset(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.HueOffset");
  }
  
  public static Int32? GetHueModulation(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.HueModulation");
  }
  
  public static void SetHueModulation(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.HueModulation");
  }
  
  public static Int32? GetSaturation(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Saturation");
  }
  
  public static void SetSaturation(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Saturation");
  }
  
  public static Int32? GetSaturationOffset(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.SaturationOffset");
  }
  
  public static void SetSaturationOffset(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.SaturationOffset");
  }
  
  public static Int32? GetSaturationModulation(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.SaturationModulation");
  }
  
  public static void SetSaturationModulation(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.SaturationModulation");
  }
  
  public static Int32? GetLuminance(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Luminance");
  }
  
  public static void SetLuminance(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Luminance");
  }
  
  public static Int32? GetLuminanceOffset(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.LuminanceOffset");
  }
  
  public static void SetLuminanceOffset(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.LuminanceOffset");
  }
  
  public static Int32? GetLuminanceModulation(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.LuminanceModulation");
  }
  
  public static void SetLuminanceModulation(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.LuminanceModulation");
  }
  
  public static Int32? GetRed(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Red");
  }
  
  public static void SetRed(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Red");
  }
  
  public static Int32? GetRedOffset(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.RedOffset");
  }
  
  public static void SetRedOffset(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.RedOffset");
  }
  
  public static Int32? GetRedModulation(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.RedModulation");
  }
  
  public static void SetRedModulation(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.RedModulation");
  }
  
  public static Int32? GetGreen(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Green");
  }
  
  public static void SetGreen(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Green");
  }
  
  public static Int32? GetGreenOffset(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.GreenOffset");
  }
  
  public static void SetGreenOffset(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.GreenOffset");
  }
  
  public static Int32? GetGreenModulation(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.GreenModulation");
  }
  
  public static void SetGreenModulation(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.GreenModulation");
  }
  
  public static Int32? GetBlue(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Blue");
  }
  
  public static void SetBlue(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Blue");
  }
  
  public static Int32? GetBlueOffset(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.BlueOffset");
  }
  
  public static void SetBlueOffset(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.BlueOffset");
  }
  
  public static Int32? GetBlueModulation(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.BlueModulation");
  }
  
  public static void SetBlueModulation(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.BlueModulation");
  }
  
  public static Boolean? GetGamma(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Gamma>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetGamma(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Boolean? value)
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
  
  public static Boolean? GetInverseGamma(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.InverseGamma>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetInverseGamma(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement, Boolean? value)
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
  
  public static DocumentModel.Drawings.HslColor? CreateModelElement(DocumentFormat.OpenXml.Drawing.HslColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.HslColor();
      value.HueValue = GetHueValue(openXmlElement);
      value.SatValue = GetSatValue(openXmlElement);
      value.LumValue = GetLumValue(openXmlElement);
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.HslColor? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.HslColor, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
