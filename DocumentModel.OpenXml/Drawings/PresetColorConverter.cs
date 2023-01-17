namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Preset Color.
/// </summary>
public static class PresetColorConverter
{
  /// <summary>
  /// Value
  /// </summary>
  private static DocumentModel.Drawings.PresetColorKind? GetVal(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetColorValues, DocumentModel.Drawings.PresetColorKind>(openXmlElement?.Val?.Value);
  }
  
  private static void SetVal(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, DocumentModel.Drawings.PresetColorKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PresetColorValues, DocumentModel.Drawings.PresetColorKind>(value);
  }
  
  private static Int32? GetTint(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Tint>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetTint(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Tint>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Tint{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetShade(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Shade>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetShade(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Shade>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Shade{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetComplement(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Complement>();
    return itemElement != null;
  }
  
  private static void SetComplement(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Boolean? value)
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
  
  private static Boolean? GetInverse(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Inverse>();
    return itemElement != null;
  }
  
  private static void SetInverse(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Boolean? value)
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
  
  private static Boolean? GetGray(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Gray>();
    return itemElement != null;
  }
  
  private static void SetGray(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Boolean? value)
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
  
  private static Int32? GetAlpha(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Alpha>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetAlpha(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Alpha>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Alpha{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetAlphaOffset(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetAlphaOffset(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.AlphaOffset{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetAlphaModulation(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetAlphaModulation(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.AlphaModulation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetHue(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Hue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetHue(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Hue>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Hue{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetHueOffset(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HueOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetHueOffset(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HueOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.HueOffset{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetHueModulation(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HueModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetHueModulation(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HueModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.HueModulation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetSaturation(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Saturation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSaturation(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Saturation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Saturation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetSaturationOffset(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SaturationOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSaturationOffset(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SaturationOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.SaturationOffset{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetSaturationModulation(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SaturationModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSaturationModulation(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SaturationModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.SaturationModulation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetLuminance(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Luminance>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetLuminance(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Luminance>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Luminance{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetLuminanceOffset(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LuminanceOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetLuminanceOffset(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LuminanceOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.LuminanceOffset{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetLuminanceModulation(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LuminanceModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetLuminanceModulation(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LuminanceModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.LuminanceModulation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetRed(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Red>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetRed(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Red>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Red{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetRedOffset(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RedOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetRedOffset(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RedOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.RedOffset{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetRedModulation(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RedModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetRedModulation(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RedModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.RedModulation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetGreen(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Green>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetGreen(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Green>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Green{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetGreenOffset(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.GreenOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetGreenOffset(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GreenOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.GreenOffset{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetGreenModulation(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.GreenModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetGreenModulation(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GreenModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.GreenModulation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetBlue(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetBlue(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blue>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Blue{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetBlueOffset(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BlueOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetBlueOffset(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BlueOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.BlueOffset{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetBlueModulation(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BlueModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetBlueModulation(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BlueModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.BlueModulation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetGamma(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Gamma>();
    return itemElement != null;
  }
  
  private static void SetGamma(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Boolean? value)
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
  
  private static Boolean? GetInverseGamma(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.InverseGamma>();
    return itemElement != null;
  }
  
  private static void SetInverseGamma(DocumentFormat.OpenXml.Drawing.PresetColor openXmlElement, Boolean? value)
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
  
  public static DocumentModel.Drawings.PresetColor? CreateModelElement(DocumentFormat.OpenXml.Drawing.PresetColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PresetColor();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.PresetColor? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.PresetColor, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetTint(openXmlElement, value?.Tint);
      SetShade(openXmlElement, value?.Shade);
      SetComplement(openXmlElement, value?.Complement);
      SetInverse(openXmlElement, value?.Inverse);
      SetGray(openXmlElement, value?.Gray);
      SetAlpha(openXmlElement, value?.Alpha);
      SetAlphaOffset(openXmlElement, value?.AlphaOffset);
      SetAlphaModulation(openXmlElement, value?.AlphaModulation);
      SetHue(openXmlElement, value?.Hue);
      SetHueOffset(openXmlElement, value?.HueOffset);
      SetHueModulation(openXmlElement, value?.HueModulation);
      SetSaturation(openXmlElement, value?.Saturation);
      SetSaturationOffset(openXmlElement, value?.SaturationOffset);
      SetSaturationModulation(openXmlElement, value?.SaturationModulation);
      SetLuminance(openXmlElement, value?.Luminance);
      SetLuminanceOffset(openXmlElement, value?.LuminanceOffset);
      SetLuminanceModulation(openXmlElement, value?.LuminanceModulation);
      SetRed(openXmlElement, value?.Red);
      SetRedOffset(openXmlElement, value?.RedOffset);
      SetRedModulation(openXmlElement, value?.RedModulation);
      SetGreen(openXmlElement, value?.Green);
      SetGreenOffset(openXmlElement, value?.GreenOffset);
      SetGreenModulation(openXmlElement, value?.GreenModulation);
      SetBlue(openXmlElement, value?.Blue);
      SetBlueOffset(openXmlElement, value?.BlueOffset);
      SetBlueModulation(openXmlElement, value?.BlueModulation);
      SetGamma(openXmlElement, value?.Gamma);
      SetInverseGamma(openXmlElement, value?.InverseGamma);
      return openXmlElement;
    }
    return default;
  }
}
