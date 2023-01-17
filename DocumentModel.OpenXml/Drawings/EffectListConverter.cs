namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Effect Container.
/// </summary>
public static class EffectListConverter
{
  /// <summary>
  /// Blur Effect.
  /// </summary>
  private static DocumentModel.Drawings.Blur? GetBlur(DocumentFormat.OpenXml.Drawing.EffectList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blur>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BlurConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBlur(DocumentFormat.OpenXml.Drawing.EffectList openXmlElement, DocumentModel.Drawings.Blur? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blur>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.BlurConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Blur>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FillOverlay.
  /// </summary>
  private static DocumentModel.Drawings.FillOverlay? GetFillOverlay(DocumentFormat.OpenXml.Drawing.EffectList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillOverlay>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.FillOverlayConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFillOverlay(DocumentFormat.OpenXml.Drawing.EffectList openXmlElement, DocumentModel.Drawings.FillOverlay? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillOverlay>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.FillOverlayConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.FillOverlay>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Glow.
  /// </summary>
  private static DocumentModel.Drawings.Glow? GetGlow(DocumentFormat.OpenXml.Drawing.EffectList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Glow>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.GlowConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGlow(DocumentFormat.OpenXml.Drawing.EffectList openXmlElement, DocumentModel.Drawings.Glow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Glow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.GlowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Glow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// InnerShadow.
  /// </summary>
  private static DocumentModel.Drawings.InnerShadow? GetInnerShadow(DocumentFormat.OpenXml.Drawing.EffectList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.InnerShadow>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.InnerShadowConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetInnerShadow(DocumentFormat.OpenXml.Drawing.EffectList openXmlElement, DocumentModel.Drawings.InnerShadow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.InnerShadow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.InnerShadowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.InnerShadow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// OuterShadow.
  /// </summary>
  private static DocumentModel.Drawings.OuterShadow? GetOuterShadow(DocumentFormat.OpenXml.Drawing.EffectList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.OuterShadow>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.OuterShadowConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOuterShadow(DocumentFormat.OpenXml.Drawing.EffectList openXmlElement, DocumentModel.Drawings.OuterShadow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.OuterShadow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.OuterShadowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.OuterShadow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PresetShadow.
  /// </summary>
  private static DocumentModel.Drawings.PresetShadow? GetPresetShadow(DocumentFormat.OpenXml.Drawing.EffectList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetShadow>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PresetShadowConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPresetShadow(DocumentFormat.OpenXml.Drawing.EffectList openXmlElement, DocumentModel.Drawings.PresetShadow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetShadow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.PresetShadowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PresetShadow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Reflection.
  /// </summary>
  private static DocumentModel.Drawings.Reflection? GetReflection(DocumentFormat.OpenXml.Drawing.EffectList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Reflection>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ReflectionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetReflection(DocumentFormat.OpenXml.Drawing.EffectList openXmlElement, DocumentModel.Drawings.Reflection? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Reflection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ReflectionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Reflection>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SoftEdge.
  /// </summary>
  private static DocumentModel.Drawings.SoftEdge? GetSoftEdge(DocumentFormat.OpenXml.Drawing.EffectList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SoftEdge>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SoftEdgeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSoftEdge(DocumentFormat.OpenXml.Drawing.EffectList openXmlElement, DocumentModel.Drawings.SoftEdge? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SoftEdge>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.SoftEdgeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SoftEdge>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.EffectList? CreateModelElement(DocumentFormat.OpenXml.Drawing.EffectList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.EffectList();
      value.Blur = GetBlur(openXmlElement);
      value.FillOverlay = GetFillOverlay(openXmlElement);
      value.Glow = GetGlow(openXmlElement);
      value.InnerShadow = GetInnerShadow(openXmlElement);
      value.OuterShadow = GetOuterShadow(openXmlElement);
      value.PresetShadow = GetPresetShadow(openXmlElement);
      value.Reflection = GetReflection(openXmlElement);
      value.SoftEdge = GetSoftEdge(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.EffectList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.EffectList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBlur(openXmlElement, value?.Blur);
      SetFillOverlay(openXmlElement, value?.FillOverlay);
      SetGlow(openXmlElement, value?.Glow);
      SetInnerShadow(openXmlElement, value?.InnerShadow);
      SetOuterShadow(openXmlElement, value?.OuterShadow);
      SetPresetShadow(openXmlElement, value?.PresetShadow);
      SetReflection(openXmlElement, value?.Reflection);
      SetSoftEdge(openXmlElement, value?.SoftEdge);
      return openXmlElement;
    }
    return default;
  }
}
