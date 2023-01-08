namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Blend Effect.
/// </summary>
public static class BlendConverter
{
  /// <summary>
  /// Blend Mode
  /// </summary>
  public static DocumentModel.Drawings.BlendMode? GetBlendMode(DocumentFormat.OpenXml.Drawing.Blend? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlendModeValues, DocumentModel.Drawings.BlendMode>(openXmlElement?.BlendMode?.Value);
  }
  
  public static void SetBlendMode(DocumentFormat.OpenXml.Drawing.Blend? openXmlElement, DocumentModel.Drawings.BlendMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.BlendMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlendModeValues, DocumentModel.Drawings.BlendMode>(value);
  }
  
  /// <summary>
  /// Effect to blend.
  /// </summary>
  public static DocumentModel.Drawings.EffectContainer? GetEffectContainer(DocumentFormat.OpenXml.Drawing.Blend? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEffectContainer(DocumentFormat.OpenXml.Drawing.Blend? openXmlElement, DocumentModel.Drawings.EffectContainer? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
