namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the Blip Class.
/// </summary>
public static class BlipConverter
{
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  public static String? GetEmbed(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetEmbed(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  public static String? GetLink(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetLink(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Compression state for blips.
  /// </summary>
  public static DocumentModel.Drawings.BlipCompressionKind? GetCompressionState(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues, DocumentModel.Drawings.BlipCompressionKind>(openXmlElement?.CompressionState?.Value);
  }
  
  public static void SetCompressionState(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement, DocumentModel.Drawings.BlipCompressionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.CompressionState = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues, DocumentModel.Drawings.BlipCompressionKind>(value);
  }
  
  public static DocumentModel.Drawings.AlphaBiLevel? GetAlphaBiLevel(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlphaBiLevel(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement, DocumentModel.Drawings.AlphaBiLevel? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetAlphaCeiling(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlphaCeiling(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetAlphaFloor(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlphaFloor(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.AlphaInverse? GetAlphaInverse(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlphaInverse(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement, DocumentModel.Drawings.AlphaInverse? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.AlphaModulationEffect? GetAlphaModulationEffect(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlphaModulationEffect(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement, DocumentModel.Drawings.AlphaModulationEffect? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.AlphaModulationFixed? GetAlphaModulationFixed(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlphaModulationFixed(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement, DocumentModel.Drawings.AlphaModulationFixed? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.AlphaReplace? GetAlphaReplace(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlphaReplace(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement, DocumentModel.Drawings.AlphaReplace? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.BiLevel? GetBiLevel(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBiLevel(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement, DocumentModel.Drawings.BiLevel? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Blur? GetBlur(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBlur(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement, DocumentModel.Drawings.Blur? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.ColorChange? GetColorChange(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetColorChange(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement, DocumentModel.Drawings.ColorChange? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.ColorReplacement? GetColorReplacement(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetColorReplacement(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement, DocumentModel.Drawings.ColorReplacement? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Duotone? GetDuotone(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDuotone(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement, DocumentModel.Drawings.Duotone? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.FillOverlay? GetFillOverlay(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFillOverlay(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement, DocumentModel.Drawings.FillOverlay? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetGrayscale(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGrayscale(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Hsl? GetHsl(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHsl(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement, DocumentModel.Drawings.Hsl? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.LuminanceEffect? GetLuminanceEffect(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLuminanceEffect(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement, DocumentModel.Drawings.LuminanceEffect? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.TintEffect? GetTintEffect(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTintEffect(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement, DocumentModel.Drawings.TintEffect? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.BlipExtensionList? GetBlipExtensionList(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBlipExtensionList(DocumentFormat.OpenXml.Drawing.Blip? openXmlElement, DocumentModel.Drawings.BlipExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
