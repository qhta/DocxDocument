namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Preset Shadow.
/// </summary>
public static class PresetShadowConverter
{
  /// <summary>
  /// Preset Shadow
  /// </summary>
  public static DocumentModel.Drawings.PresetShadowKind? GetPreset(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetShadowValues, DocumentModel.Drawings.PresetShadowKind>(openXmlElement?.Preset?.Value);
  }
  
  public static void SetPreset(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement, DocumentModel.Drawings.PresetShadowKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Preset = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PresetShadowValues, DocumentModel.Drawings.PresetShadowKind>(value);
  }
  
  /// <summary>
  /// Distance
  /// </summary>
  public static Int64? GetDistance(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement)
  {
    return openXmlElement?.Distance?.Value;
  }
  
  public static void SetDistance(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Distance = value;
  }
  
  /// <summary>
  /// Direction
  /// </summary>
  public static Int32? GetDirection(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement)
  {
    return openXmlElement?.Direction?.Value;
  }
  
  public static void SetDirection(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Direction = value;
  }
  
  /// <summary>
  /// RGB Color Model - Percentage Variant.
  /// </summary>
  public static DocumentModel.Drawings.RgbColorModelPercentage? GetRgbColorModelPercentage(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.RgbColorModelPercentageConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRgbColorModelPercentage(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement, DocumentModel.Drawings.RgbColorModelPercentage? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.RgbColorModelPercentageConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// RGB Color Model - Hex Variant.
  /// </summary>
  public static DocumentModel.Drawings.RgbColorModelHex? GetRgbColorModelHex(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.RgbColorModelHexConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRgbColorModelHex(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement, DocumentModel.Drawings.RgbColorModelHex? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.RgbColorModelHexConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Hue, Saturation, Luminance Color Model.
  /// </summary>
  public static DocumentModel.Drawings.HslColor? GetHslColor(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HslColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.HslColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetHslColor(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement, DocumentModel.Drawings.HslColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HslColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.HslColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.HslColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// System Color.
  /// </summary>
  public static DocumentModel.Drawings.SystemColor? GetSystemColor(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SystemColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSystemColor(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement, DocumentModel.Drawings.SystemColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.SystemColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SystemColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Scheme Color.
  /// </summary>
  public static DocumentModel.Drawings.SchemeColor? GetSchemeColor(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SchemeColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSchemeColor(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement, DocumentModel.Drawings.SchemeColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.SchemeColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SchemeColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Preset Color.
  /// </summary>
  public static DocumentModel.Drawings.PresetColor? GetPresetColor(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PresetColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPresetColor(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement, DocumentModel.Drawings.PresetColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.PresetColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PresetColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.PresetShadow? CreateModelElement(DocumentFormat.OpenXml.Drawing.PresetShadow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PresetShadow();
      value.Preset = GetPreset(openXmlElement);
      value.Distance = GetDistance(openXmlElement);
      value.Direction = GetDirection(openXmlElement);
      value.RgbColorModelPercentage = GetRgbColorModelPercentage(openXmlElement);
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.HslColor = GetHslColor(openXmlElement);
      value.SystemColor = GetSystemColor(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      value.PresetColor = GetPresetColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.PresetShadow? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.PresetShadow, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
