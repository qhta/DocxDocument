namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Alpha Modulate Effect.
/// </summary>
public static class AlphaModulationEffectConverter
{
  /// <summary>
  /// EffectContainer.
  /// </summary>
  public static DocumentModel.Drawings.EffectContainer? GetEffectContainer(DocumentFormat.OpenXml.Drawing.AlphaModulationEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectContainer>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.EffectContainerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEffectContainer(DocumentFormat.OpenXml.Drawing.AlphaModulationEffect? openXmlElement, DocumentModel.Drawings.EffectContainer? value)
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
  
  public static DocumentModel.Drawings.AlphaModulationEffect? CreateModelElement(DocumentFormat.OpenXml.Drawing.AlphaModulationEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AlphaModulationEffect();
      value.EffectContainer = GetEffectContainer(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.AlphaModulationEffect? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.AlphaModulationEffect, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEffectContainer(openXmlElement, value?.EffectContainer);
      return openXmlElement;
    }
    return default;
  }
}
