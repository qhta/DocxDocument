namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the Snapshot Class.
/// </summary>
public static class SnapshotConverter
{
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  public static String? GetEmbed(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetEmbed(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  public static String? GetLink(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetLink(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Compression state for blips.
  /// </summary>
  public static DocumentModel.Drawings.BlipCompressionKind? GetCompressionState(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues, DocumentModel.Drawings.BlipCompressionKind>(openXmlElement?.CompressionState?.Value);
  }
  
  public static void SetCompressionState(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement, DocumentModel.Drawings.BlipCompressionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.CompressionState = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues, DocumentModel.Drawings.BlipCompressionKind>(value);
  }
  
  public static DocumentModel.Drawings.AlphaBiLevel? GetAlphaBiLevel(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlphaBiLevel(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement, DocumentModel.Drawings.AlphaBiLevel? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetAlphaCeiling(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlphaCeiling(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetAlphaFloor(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlphaFloor(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.AlphaInverse? GetAlphaInverse(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlphaInverse(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement, DocumentModel.Drawings.AlphaInverse? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.AlphaModulationEffect? GetAlphaModulationEffect(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlphaModulationEffect(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement, DocumentModel.Drawings.AlphaModulationEffect? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.AlphaModulationFixed? GetAlphaModulationFixed(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlphaModulationFixed(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement, DocumentModel.Drawings.AlphaModulationFixed? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.AlphaReplace? GetAlphaReplace(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAlphaReplace(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement, DocumentModel.Drawings.AlphaReplace? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.BiLevel? GetBiLevel(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBiLevel(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement, DocumentModel.Drawings.BiLevel? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Blur? GetBlur(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBlur(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement, DocumentModel.Drawings.Blur? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.ColorChange? GetColorChange(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetColorChange(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement, DocumentModel.Drawings.ColorChange? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.ColorReplacement? GetColorReplacement(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetColorReplacement(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement, DocumentModel.Drawings.ColorReplacement? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Duotone? GetDuotone(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDuotone(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement, DocumentModel.Drawings.Duotone? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.FillOverlay? GetFillOverlay(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFillOverlay(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement, DocumentModel.Drawings.FillOverlay? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetGrayscale(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGrayscale(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Hsl? GetHsl(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHsl(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement, DocumentModel.Drawings.Hsl? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.LuminanceEffect? GetLuminanceEffect(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLuminanceEffect(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement, DocumentModel.Drawings.LuminanceEffect? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.TintEffect? GetTintEffect(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTintEffect(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement, DocumentModel.Drawings.TintEffect? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.BlipExtensionList? GetBlipExtensionList(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBlipExtensionList(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement, DocumentModel.Drawings.BlipExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
