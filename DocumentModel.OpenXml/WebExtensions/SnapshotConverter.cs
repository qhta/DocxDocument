namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the Snapshot Class.
/// </summary>
public static class SnapshotConverter
{
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  private static String? GetEmbed(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement)
  {
    return openXmlElement?.Embed?.Value;
  }
  
  private static void SetEmbed(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Embed = new StringValue { Value = value };
    else
      openXmlElement.Embed = null;
  }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  private static String? GetLink(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement)
  {
    return openXmlElement?.Link?.Value;
  }
  
  private static void SetLink(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Link = new StringValue { Value = value };
    else
      openXmlElement.Link = null;
  }
  
  /// <summary>
  /// Compression state for blips.
  /// </summary>
  private static DocumentModel.Drawings.BlipCompressionKind? GetCompressionState(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues, DocumentModel.Drawings.BlipCompressionKind>(openXmlElement?.CompressionState?.Value);
  }
  
  private static void SetCompressionState(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement, DocumentModel.Drawings.BlipCompressionKind? value)
  {
    openXmlElement.CompressionState = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues, DocumentModel.Drawings.BlipCompressionKind>(value);
  }
  
  private static DocumentModel.Drawings.AlphaBiLevel? GetAlphaBiLevel(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaBiLevel>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AlphaBiLevelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAlphaBiLevel(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement, DocumentModel.Drawings.AlphaBiLevel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaBiLevel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.AlphaBiLevelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AlphaBiLevel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetAlphaCeiling(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaCeiling>();
    return itemElement != null;
  }
  
  private static void SetAlphaCeiling(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaCeiling>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.AlphaCeiling();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetAlphaFloor(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaFloor>();
    return itemElement != null;
  }
  
  private static void SetAlphaFloor(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaFloor>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.AlphaFloor();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.AlphaInverse? GetAlphaInverse(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaInverse>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AlphaInverseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAlphaInverse(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement, DocumentModel.Drawings.AlphaInverse? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaInverse>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.AlphaInverseConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AlphaInverse>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.AlphaModulationEffect? GetAlphaModulationEffect(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaModulationEffect>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AlphaModulationEffectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAlphaModulationEffect(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement, DocumentModel.Drawings.AlphaModulationEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaModulationEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.AlphaModulationEffectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AlphaModulationEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.AlphaModulationFixed? GetAlphaModulationFixed(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaModulationFixed>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AlphaModulationFixedConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAlphaModulationFixed(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement, DocumentModel.Drawings.AlphaModulationFixed? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaModulationFixed>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.AlphaModulationFixedConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AlphaModulationFixed>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.AlphaReplace? GetAlphaReplace(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaReplace>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AlphaReplaceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAlphaReplace(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement, DocumentModel.Drawings.AlphaReplace? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AlphaReplace>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.AlphaReplaceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AlphaReplace>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.BiLevel? GetBiLevel(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BiLevel>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BiLevelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBiLevel(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement, DocumentModel.Drawings.BiLevel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BiLevel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.BiLevelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BiLevel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Blur? GetBlur(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blur>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BlurConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBlur(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement, DocumentModel.Drawings.Blur? value)
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
  
  private static DocumentModel.Drawings.ColorChange? GetColorChange(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorChange>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ColorChangeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColorChange(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement, DocumentModel.Drawings.ColorChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ColorChangeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ColorChange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.ColorReplacement? GetColorReplacement(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorReplacement>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ColorReplacementConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColorReplacement(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement, DocumentModel.Drawings.ColorReplacement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ColorReplacement>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ColorReplacementConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ColorReplacement>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Duotone? GetDuotone(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Duotone>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.DuotoneConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDuotone(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement, DocumentModel.Drawings.Duotone? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Duotone>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.DuotoneConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Duotone>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.FillOverlay? GetFillOverlay(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillOverlay>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.FillOverlayConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFillOverlay(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement, DocumentModel.Drawings.FillOverlay? value)
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
  
  private static Boolean? GetGrayscale(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Grayscale>();
    return itemElement != null;
  }
  
  private static void SetGrayscale(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Grayscale>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Grayscale();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Hsl? GetHsl(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Hsl>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.HslConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHsl(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement, DocumentModel.Drawings.Hsl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Hsl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.HslConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Hsl>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.LuminanceEffect? GetLuminanceEffect(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LuminanceEffect>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.LuminanceEffectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLuminanceEffect(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement, DocumentModel.Drawings.LuminanceEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LuminanceEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.LuminanceEffectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LuminanceEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.TintEffect? GetTintEffect(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.TintEffect>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.TintEffectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTintEffect(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement, DocumentModel.Drawings.TintEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TintEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.TintEffectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.TintEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.BlipExtensionList? GetBlipExtensionList(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BlipExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BlipExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBlipExtensionList(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot openXmlElement, DocumentModel.Drawings.BlipExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BlipExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.BlipExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BlipExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.WebExtensions.Snapshot? CreateModelElement(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebExtensions.Snapshot();
      value.Embed = GetEmbed(openXmlElement);
      value.Link = GetLink(openXmlElement);
      value.CompressionState = GetCompressionState(openXmlElement);
      value.AlphaBiLevel = GetAlphaBiLevel(openXmlElement);
      value.AlphaCeiling = GetAlphaCeiling(openXmlElement);
      value.AlphaFloor = GetAlphaFloor(openXmlElement);
      value.AlphaInverse = GetAlphaInverse(openXmlElement);
      value.AlphaModulationEffect = GetAlphaModulationEffect(openXmlElement);
      value.AlphaModulationFixed = GetAlphaModulationFixed(openXmlElement);
      value.AlphaReplace = GetAlphaReplace(openXmlElement);
      value.BiLevel = GetBiLevel(openXmlElement);
      value.Blur = GetBlur(openXmlElement);
      value.ColorChange = GetColorChange(openXmlElement);
      value.ColorReplacement = GetColorReplacement(openXmlElement);
      value.Duotone = GetDuotone(openXmlElement);
      value.FillOverlay = GetFillOverlay(openXmlElement);
      value.Grayscale = GetGrayscale(openXmlElement);
      value.Hsl = GetHsl(openXmlElement);
      value.LuminanceEffect = GetLuminanceEffect(openXmlElement);
      value.TintEffect = GetTintEffect(openXmlElement);
      value.BlipExtensionList = GetBlipExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.WebExtensions.Snapshot? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEmbed(openXmlElement, value?.Embed);
      SetLink(openXmlElement, value?.Link);
      SetCompressionState(openXmlElement, value?.CompressionState);
      SetAlphaBiLevel(openXmlElement, value?.AlphaBiLevel);
      SetAlphaCeiling(openXmlElement, value?.AlphaCeiling);
      SetAlphaFloor(openXmlElement, value?.AlphaFloor);
      SetAlphaInverse(openXmlElement, value?.AlphaInverse);
      SetAlphaModulationEffect(openXmlElement, value?.AlphaModulationEffect);
      SetAlphaModulationFixed(openXmlElement, value?.AlphaModulationFixed);
      SetAlphaReplace(openXmlElement, value?.AlphaReplace);
      SetBiLevel(openXmlElement, value?.BiLevel);
      SetBlur(openXmlElement, value?.Blur);
      SetColorChange(openXmlElement, value?.ColorChange);
      SetColorReplacement(openXmlElement, value?.ColorReplacement);
      SetDuotone(openXmlElement, value?.Duotone);
      SetFillOverlay(openXmlElement, value?.FillOverlay);
      SetGrayscale(openXmlElement, value?.Grayscale);
      SetHsl(openXmlElement, value?.Hsl);
      SetLuminanceEffect(openXmlElement, value?.LuminanceEffect);
      SetTintEffect(openXmlElement, value?.TintEffect);
      SetBlipExtensionList(openXmlElement, value?.BlipExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
