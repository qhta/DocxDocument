namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Fill Overlay Effect.
/// </summary>
public static class FillOverlayConverter
{
  /// <summary>
  /// Blend
  /// </summary>
  public static DocumentModel.Drawings.BlendMode? GetBlend(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlendModeValues, DocumentModel.Drawings.BlendMode>(openXmlElement?.Blend?.Value);
  }
  
  public static void SetBlend(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement, DocumentModel.Drawings.BlendMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.Blend = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlendModeValues, DocumentModel.Drawings.BlendMode>(value);
  }
  
  /// <summary>
  /// NoFill.
  /// </summary>
  public static Boolean? GetNoFill(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNoFill(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// SolidFill.
  /// </summary>
  public static DocumentModel.Drawings.SolidFill? GetSolidFill(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSolidFill(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement, DocumentModel.Drawings.SolidFill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// GradientFill.
  /// </summary>
  public static DocumentModel.Drawings.GradientFill? GetGradientFill(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGradientFill(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement, DocumentModel.Drawings.GradientFill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// BlipFill.
  /// </summary>
  public static DocumentModel.Drawings.BlipFill? GetBlipFill(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBlipFill(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement, DocumentModel.Drawings.BlipFill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Pattern Fill.
  /// </summary>
  public static DocumentModel.Drawings.PatternFill? GetPatternFill(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPatternFill(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement, DocumentModel.Drawings.PatternFill? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Group Fill.
  /// </summary>
  public static Boolean? GetGroupFill(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGroupFill(DocumentFormat.OpenXml.Drawing.FillOverlay? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
