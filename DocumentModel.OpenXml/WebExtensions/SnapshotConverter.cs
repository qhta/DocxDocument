namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the Snapshot Class.
/// </summary>
public static class SnapshotConverter
{
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  private static String? GetEmbed(DXO2013WebExt.Snapshot openXmlElement)
  {
    return openXmlElement?.Embed?.Value;
  }
  
  private static void SetEmbed(DXO2013WebExt.Snapshot openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Embed = new StringValue { Value = value };
    else
      openXmlElement.Embed = null;
  }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  private static String? GetLink(DXO2013WebExt.Snapshot openXmlElement)
  {
    return openXmlElement?.Link?.Value;
  }
  
  private static void SetLink(DXO2013WebExt.Snapshot openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Link = new StringValue { Value = value };
    else
      openXmlElement.Link = null;
  }
  
  /// <summary>
  /// Compression state for blips.
  /// </summary>
  private static DMDraws.BlipCompressionKind? GetCompressionState(DXO2013WebExt.Snapshot openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues, DMDraws.BlipCompressionKind>(openXmlElement?.CompressionState?.Value);
  }
  
  private static void SetCompressionState(DXO2013WebExt.Snapshot openXmlElement, DMDraws.BlipCompressionKind? value)
  {
    openXmlElement.CompressionState = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues, DMDraws.BlipCompressionKind>(value);
  }
  
  private static DMDraws.AlphaBiLevel? GetAlphaBiLevel(DXO2013WebExt.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.AlphaBiLevel>();
    if (itemElement != null)
      return DMXDraws.AlphaBiLevelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAlphaBiLevel(DXO2013WebExt.Snapshot openXmlElement, DMDraws.AlphaBiLevel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.AlphaBiLevel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.AlphaBiLevelConverter.CreateOpenXmlElement<DXDraw.AlphaBiLevel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetAlphaCeiling(DXO2013WebExt.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.AlphaCeiling>();
    return itemElement != null;
  }
  
  private static void SetAlphaCeiling(DXO2013WebExt.Snapshot openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.AlphaCeiling>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.AlphaCeiling();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetAlphaFloor(DXO2013WebExt.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.AlphaFloor>();
    return itemElement != null;
  }
  
  private static void SetAlphaFloor(DXO2013WebExt.Snapshot openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.AlphaFloor>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.AlphaFloor();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.AlphaInverse? GetAlphaInverse(DXO2013WebExt.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.AlphaInverse>();
    if (itemElement != null)
      return DMXDraws.AlphaInverseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAlphaInverse(DXO2013WebExt.Snapshot openXmlElement, DMDraws.AlphaInverse? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.AlphaInverse>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.AlphaInverseConverter.CreateOpenXmlElement<DXDraw.AlphaInverse>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.AlphaModulationEffect? GetAlphaModulationEffect(DXO2013WebExt.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.AlphaModulationEffect>();
    if (itemElement != null)
      return DMXDraws.AlphaModulationEffectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAlphaModulationEffect(DXO2013WebExt.Snapshot openXmlElement, DMDraws.AlphaModulationEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.AlphaModulationEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.AlphaModulationEffectConverter.CreateOpenXmlElement<DXDraw.AlphaModulationEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.AlphaModulationFixed? GetAlphaModulationFixed(DXO2013WebExt.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.AlphaModulationFixed>();
    if (itemElement != null)
      return DMXDraws.AlphaModulationFixedConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAlphaModulationFixed(DXO2013WebExt.Snapshot openXmlElement, DMDraws.AlphaModulationFixed? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.AlphaModulationFixed>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.AlphaModulationFixedConverter.CreateOpenXmlElement<DXDraw.AlphaModulationFixed>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.AlphaReplace? GetAlphaReplace(DXO2013WebExt.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.AlphaReplace>();
    if (itemElement != null)
      return DMXDraws.AlphaReplaceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAlphaReplace(DXO2013WebExt.Snapshot openXmlElement, DMDraws.AlphaReplace? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.AlphaReplace>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.AlphaReplaceConverter.CreateOpenXmlElement<DXDraw.AlphaReplace>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.BiLevel? GetBiLevel(DXO2013WebExt.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BiLevel>();
    if (itemElement != null)
      return DMXDraws.BiLevelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBiLevel(DXO2013WebExt.Snapshot openXmlElement, DMDraws.BiLevel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BiLevel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BiLevelConverter.CreateOpenXmlElement<DXDraw.BiLevel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Blur? GetBlur(DXO2013WebExt.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Blur>();
    if (itemElement != null)
      return DMXDraws.BlurConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBlur(DXO2013WebExt.Snapshot openXmlElement, DMDraws.Blur? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Blur>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BlurConverter.CreateOpenXmlElement<DXDraw.Blur>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.ColorChange? GetColorChange(DXO2013WebExt.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ColorChange>();
    if (itemElement != null)
      return DMXDraws.ColorChangeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColorChange(DXO2013WebExt.Snapshot openXmlElement, DMDraws.ColorChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ColorChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ColorChangeConverter.CreateOpenXmlElement<DXDraw.ColorChange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.ColorReplacement? GetColorReplacement(DXO2013WebExt.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ColorReplacement>();
    if (itemElement != null)
      return DMXDraws.ColorReplacementConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColorReplacement(DXO2013WebExt.Snapshot openXmlElement, DMDraws.ColorReplacement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ColorReplacement>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ColorReplacementConverter.CreateOpenXmlElement<DXDraw.ColorReplacement>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Duotone? GetDuotone(DXO2013WebExt.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Duotone>();
    if (itemElement != null)
      return DMXDraws.DuotoneConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDuotone(DXO2013WebExt.Snapshot openXmlElement, DMDraws.Duotone? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Duotone>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.DuotoneConverter.CreateOpenXmlElement<DXDraw.Duotone>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.FillOverlay? GetFillOverlay(DXO2013WebExt.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.FillOverlay>();
    if (itemElement != null)
      return DMXDraws.FillOverlayConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFillOverlay(DXO2013WebExt.Snapshot openXmlElement, DMDraws.FillOverlay? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.FillOverlay>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.FillOverlayConverter.CreateOpenXmlElement<DXDraw.FillOverlay>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetGrayscale(DXO2013WebExt.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Grayscale>();
    return itemElement != null;
  }
  
  private static void SetGrayscale(DXO2013WebExt.Snapshot openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.Grayscale>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.Grayscale();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Hsl? GetHsl(DXO2013WebExt.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Hsl>();
    if (itemElement != null)
      return DMXDraws.HslConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHsl(DXO2013WebExt.Snapshot openXmlElement, DMDraws.Hsl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Hsl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HslConverter.CreateOpenXmlElement<DXDraw.Hsl>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.LuminanceEffect? GetLuminanceEffect(DXO2013WebExt.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.LuminanceEffect>();
    if (itemElement != null)
      return DMXDraws.LuminanceEffectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLuminanceEffect(DXO2013WebExt.Snapshot openXmlElement, DMDraws.LuminanceEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.LuminanceEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.LuminanceEffectConverter.CreateOpenXmlElement<DXDraw.LuminanceEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.TintEffect? GetTintEffect(DXO2013WebExt.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.TintEffect>();
    if (itemElement != null)
      return DMXDraws.TintEffectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTintEffect(DXO2013WebExt.Snapshot openXmlElement, DMDraws.TintEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.TintEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.TintEffectConverter.CreateOpenXmlElement<DXDraw.TintEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.BlipExtensionList? GetBlipExtensionList(DXO2013WebExt.Snapshot openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BlipExtensionList>();
    if (itemElement != null)
      return DMXDraws.BlipExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBlipExtensionList(DXO2013WebExt.Snapshot openXmlElement, DMDraws.BlipExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BlipExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BlipExtensionListConverter.CreateOpenXmlElement<DXDraw.BlipExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMWebExt.Snapshot? CreateModelElement(DXO2013WebExt.Snapshot? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMWebExt.Snapshot();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMWebExt.Snapshot? value)
    where OpenXmlElementType: DXO2013WebExt.Snapshot, new()
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
