namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the StyleColor Class.
/// </summary>
public static class StyleColorConverter
{
  /// <summary>
  /// val, this property is only available in Office 2013 and later.
  /// </summary>
  public static String? GetVal(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }
  
  public static Int32? GetTint(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Tint");
  }
  
  public static void SetTint(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Tint");
  }
  
  public static Int32? GetShade(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Shade");
  }
  
  public static void SetShade(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Shade");
  }
  
  public static Boolean? GetComplement(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Complement>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetComplement(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Boolean? value)
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
  
  public static Boolean? GetInverse(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Inverse>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetInverse(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Boolean? value)
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
  
  public static Boolean? GetGray(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Gray>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetGray(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Boolean? value)
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
  
  public static Int32? GetAlpha(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Alpha");
  }
  
  public static void SetAlpha(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Alpha");
  }
  
  public static Int32? GetAlphaOffset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.AlphaOffset");
  }
  
  public static void SetAlphaOffset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.AlphaOffset");
  }
  
  public static Int32? GetAlphaModulation(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.AlphaModulation");
  }
  
  public static void SetAlphaModulation(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.AlphaModulation");
  }
  
  public static Int32? GetHue(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Hue");
  }
  
  public static void SetHue(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Hue");
  }
  
  public static Int32? GetHueOffset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.HueOffset");
  }
  
  public static void SetHueOffset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.HueOffset");
  }
  
  public static Int32? GetHueModulation(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.HueModulation");
  }
  
  public static void SetHueModulation(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.HueModulation");
  }
  
  public static Int32? GetSaturation(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Saturation");
  }
  
  public static void SetSaturation(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Saturation");
  }
  
  public static Int32? GetSaturationOffset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.SaturationOffset");
  }
  
  public static void SetSaturationOffset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.SaturationOffset");
  }
  
  public static Int32? GetSaturationModulation(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.SaturationModulation");
  }
  
  public static void SetSaturationModulation(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.SaturationModulation");
  }
  
  public static Int32? GetLuminance(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Luminance");
  }
  
  public static void SetLuminance(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Luminance");
  }
  
  public static Int32? GetLuminanceOffset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.LuminanceOffset");
  }
  
  public static void SetLuminanceOffset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.LuminanceOffset");
  }
  
  public static Int32? GetLuminanceModulation(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.LuminanceModulation");
  }
  
  public static void SetLuminanceModulation(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.LuminanceModulation");
  }
  
  public static Int32? GetRed(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Red");
  }
  
  public static void SetRed(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Red");
  }
  
  public static Int32? GetRedOffset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.RedOffset");
  }
  
  public static void SetRedOffset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.RedOffset");
  }
  
  public static Int32? GetRedModulation(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.RedModulation");
  }
  
  public static void SetRedModulation(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.RedModulation");
  }
  
  public static Int32? GetGreen(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Green");
  }
  
  public static void SetGreen(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Green");
  }
  
  public static Int32? GetGreenOffset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.GreenOffset");
  }
  
  public static void SetGreenOffset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.GreenOffset");
  }
  
  public static Int32? GetGreenModulation(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.GreenModulation");
  }
  
  public static void SetGreenModulation(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.GreenModulation");
  }
  
  public static Int32? GetBlue(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Blue");
  }
  
  public static void SetBlue(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Blue");
  }
  
  public static Int32? GetBlueOffset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.BlueOffset");
  }
  
  public static void SetBlueOffset(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.BlueOffset");
  }
  
  public static Int32? GetBlueModulation(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.BlueModulation");
  }
  
  public static void SetBlueModulation(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.BlueModulation");
  }
  
  public static Boolean? GetGamma(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Gamma>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetGamma(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Boolean? value)
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
  
  public static Boolean? GetInverseGamma(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.InverseGamma>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetInverseGamma(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement, Boolean? value)
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
  
  public static DocumentModel.Drawings.ChartsStyle.StyleColor? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartsStyle.StyleColor();
      value.Val = GetVal(openXmlElement);
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartsStyle.StyleColor? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
