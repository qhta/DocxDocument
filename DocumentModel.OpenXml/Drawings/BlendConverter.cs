namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Blend Effect.
/// </summary>
public static class BlendConverter
{
  /// <summary>
  /// Blend Mode
  /// </summary>
  private static DocumentModel.Drawings.BlendMode? GetBlendMode(DocumentFormat.OpenXml.Drawing.Blend openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlendModeValues, DocumentModel.Drawings.BlendMode>(openXmlElement?.BlendMode?.Value);
  }
  
  private static void SetBlendMode(DocumentFormat.OpenXml.Drawing.Blend openXmlElement, DocumentModel.Drawings.BlendMode? value)
  {
    openXmlElement.BlendMode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlendModeValues, DocumentModel.Drawings.BlendMode>(value);
  }
  
  /// <summary>
  /// Effect to blend.
  /// </summary>
  private static DocumentModel.Drawings.EffectContainer? GetEffectContainer(DocumentFormat.OpenXml.Drawing.Blend openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectContainer>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.EffectContainerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEffectContainer(DocumentFormat.OpenXml.Drawing.Blend openXmlElement, DocumentModel.Drawings.EffectContainer? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectContainer>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.EffectContainerConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EffectContainer>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Blend? CreateModelElement(DocumentFormat.OpenXml.Drawing.Blend? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Blend();
      value.BlendMode = GetBlendMode(openXmlElement);
      value.EffectContainer = GetEffectContainer(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Blend? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Blend, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBlendMode(openXmlElement, value?.BlendMode);
      SetEffectContainer(openXmlElement, value?.EffectContainer);
      return openXmlElement;
    }
    return default;
  }
}
