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
    return StringValueConverter.GetValue(openXmlElement?.Embed);
  }
  
  private static bool CmpEmbed(DXO2013WebExt.Snapshot openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Embed, value, diffs, objName, "Embed");
  }
  
  private static void SetEmbed(DXO2013WebExt.Snapshot openXmlElement, String? value)
  {
    openXmlElement.Embed = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  private static String? GetLink(DXO2013WebExt.Snapshot openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Link);
  }
  
  private static bool CmpLink(DXO2013WebExt.Snapshot openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Link, value, diffs, objName, "Link");
  }
  
  private static void SetLink(DXO2013WebExt.Snapshot openXmlElement, String? value)
  {
    openXmlElement.Link = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Compression state for blips.
  /// </summary>
  private static DMDraws.BlipCompressionKind? GetCompressionState(DXO2013WebExt.Snapshot openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues, DMDraws.BlipCompressionKind>(openXmlElement?.CompressionState?.Value);
  }
  
  private static bool CmpCompressionState(DXO2013WebExt.Snapshot openXmlElement, DMDraws.BlipCompressionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues, DMDraws.BlipCompressionKind>(openXmlElement?.CompressionState?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCompressionState(DXO2013WebExt.Snapshot openXmlElement, DMDraws.BlipCompressionKind? value)
  {
    openXmlElement.CompressionState = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues, DMDraws.BlipCompressionKind>(value);
  }
  
  private static DMDraws.AlphaBiLevel? GetAlphaBiLevel(DXO2013WebExt.Snapshot openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.AlphaBiLevel>();
    if (element != null)
      return DMXDraws.AlphaBiLevelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaBiLevel(DXO2013WebExt.Snapshot openXmlElement, DMDraws.AlphaBiLevel? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AlphaBiLevelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.AlphaBiLevel>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement.GetFirstChild<DXDraw.AlphaCeiling>() != null;
  }
  
  private static bool CmpAlphaCeiling(DXO2013WebExt.Snapshot openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.AlphaCeiling>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.AlphaCeiling", val, value);
    return false;
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
    return openXmlElement.GetFirstChild<DXDraw.AlphaFloor>() != null;
  }
  
  private static bool CmpAlphaFloor(DXO2013WebExt.Snapshot openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.AlphaFloor>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.AlphaFloor", val, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXDraw.AlphaInverse>();
    if (element != null)
      return DMXDraws.AlphaInverseConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaInverse(DXO2013WebExt.Snapshot openXmlElement, DMDraws.AlphaInverse? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AlphaInverseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.AlphaInverse>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.AlphaModulationEffect>();
    if (element != null)
      return DMXDraws.AlphaModulationEffectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaModulationEffect(DXO2013WebExt.Snapshot openXmlElement, DMDraws.AlphaModulationEffect? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AlphaModulationEffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.AlphaModulationEffect>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.AlphaModulationFixed>();
    if (element != null)
      return DMXDraws.AlphaModulationFixedConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaModulationFixed(DXO2013WebExt.Snapshot openXmlElement, DMDraws.AlphaModulationFixed? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AlphaModulationFixedConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.AlphaModulationFixed>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.AlphaReplace>();
    if (element != null)
      return DMXDraws.AlphaReplaceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaReplace(DXO2013WebExt.Snapshot openXmlElement, DMDraws.AlphaReplace? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AlphaReplaceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.AlphaReplace>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.BiLevel>();
    if (element != null)
      return DMXDraws.BiLevelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBiLevel(DXO2013WebExt.Snapshot openXmlElement, DMDraws.BiLevel? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BiLevelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.BiLevel>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.Blur>();
    if (element != null)
      return DMXDraws.BlurConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBlur(DXO2013WebExt.Snapshot openXmlElement, DMDraws.Blur? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BlurConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Blur>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.ColorChange>();
    if (element != null)
      return DMXDraws.ColorChangeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorChange(DXO2013WebExt.Snapshot openXmlElement, DMDraws.ColorChange? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ColorChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ColorChange>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.ColorReplacement>();
    if (element != null)
      return DMXDraws.ColorReplacementConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorReplacement(DXO2013WebExt.Snapshot openXmlElement, DMDraws.ColorReplacement? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ColorReplacementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ColorReplacement>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.Duotone>();
    if (element != null)
      return DMXDraws.DuotoneConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDuotone(DXO2013WebExt.Snapshot openXmlElement, DMDraws.Duotone? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.DuotoneConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Duotone>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.FillOverlay>();
    if (element != null)
      return DMXDraws.FillOverlayConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFillOverlay(DXO2013WebExt.Snapshot openXmlElement, DMDraws.FillOverlay? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.FillOverlayConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.FillOverlay>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement.GetFirstChild<DXDraw.Grayscale>() != null;
  }
  
  private static bool CmpGrayscale(DXO2013WebExt.Snapshot openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.Grayscale>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.Grayscale", val, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXDraw.Hsl>();
    if (element != null)
      return DMXDraws.HslConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHsl(DXO2013WebExt.Snapshot openXmlElement, DMDraws.Hsl? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.HslConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Hsl>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.LuminanceEffect>();
    if (element != null)
      return DMXDraws.LuminanceEffectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLuminanceEffect(DXO2013WebExt.Snapshot openXmlElement, DMDraws.LuminanceEffect? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.LuminanceEffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.LuminanceEffect>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.TintEffect>();
    if (element != null)
      return DMXDraws.TintEffectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTintEffect(DXO2013WebExt.Snapshot openXmlElement, DMDraws.TintEffect? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.TintEffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.TintEffect>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.BlipExtensionList>();
    if (element != null)
      return DMXDraws.BlipExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBlipExtensionList(DXO2013WebExt.Snapshot openXmlElement, DMDraws.BlipExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BlipExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.BlipExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.WebExtensions.Snapshot? CreateModelElement(DXO2013WebExt.Snapshot? openXmlElement)
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
  
  public static bool CompareModelElement(DXO2013WebExt.Snapshot? openXmlElement, DMWebExt.Snapshot? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEmbed(openXmlElement, value.Embed, diffs, objName))
        ok = false;
      if (!CmpLink(openXmlElement, value.Link, diffs, objName))
        ok = false;
      if (!CmpCompressionState(openXmlElement, value.CompressionState, diffs, objName))
        ok = false;
      if (!CmpAlphaBiLevel(openXmlElement, value.AlphaBiLevel, diffs, objName))
        ok = false;
      if (!CmpAlphaCeiling(openXmlElement, value.AlphaCeiling, diffs, objName))
        ok = false;
      if (!CmpAlphaFloor(openXmlElement, value.AlphaFloor, diffs, objName))
        ok = false;
      if (!CmpAlphaInverse(openXmlElement, value.AlphaInverse, diffs, objName))
        ok = false;
      if (!CmpAlphaModulationEffect(openXmlElement, value.AlphaModulationEffect, diffs, objName))
        ok = false;
      if (!CmpAlphaModulationFixed(openXmlElement, value.AlphaModulationFixed, diffs, objName))
        ok = false;
      if (!CmpAlphaReplace(openXmlElement, value.AlphaReplace, diffs, objName))
        ok = false;
      if (!CmpBiLevel(openXmlElement, value.BiLevel, diffs, objName))
        ok = false;
      if (!CmpBlur(openXmlElement, value.Blur, diffs, objName))
        ok = false;
      if (!CmpColorChange(openXmlElement, value.ColorChange, diffs, objName))
        ok = false;
      if (!CmpColorReplacement(openXmlElement, value.ColorReplacement, diffs, objName))
        ok = false;
      if (!CmpDuotone(openXmlElement, value.Duotone, diffs, objName))
        ok = false;
      if (!CmpFillOverlay(openXmlElement, value.FillOverlay, diffs, objName))
        ok = false;
      if (!CmpGrayscale(openXmlElement, value.Grayscale, diffs, objName))
        ok = false;
      if (!CmpHsl(openXmlElement, value.Hsl, diffs, objName))
        ok = false;
      if (!CmpLuminanceEffect(openXmlElement, value.LuminanceEffect, diffs, objName))
        ok = false;
      if (!CmpTintEffect(openXmlElement, value.TintEffect, diffs, objName))
        ok = false;
      if (!CmpBlipExtensionList(openXmlElement, value.BlipExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMWebExt.Snapshot value)
    where OpenXmlElementType: DXO2013WebExt.Snapshot, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013WebExt.Snapshot openXmlElement, DMWebExt.Snapshot value)
  {
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
    }
  }
