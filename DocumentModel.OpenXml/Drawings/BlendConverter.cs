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
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectContainer>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.EffectContainerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEffectContainer(DocumentFormat.OpenXml.Drawing.Blend? openXmlElement, DocumentModel.Drawings.EffectContainer? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
