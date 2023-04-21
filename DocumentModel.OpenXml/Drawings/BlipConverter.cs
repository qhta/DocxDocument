namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the Blip Class.
/// </summary>
public static class BlipConverter
{
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  private static String? GetEmbed(DXD.Blip openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Embed);
  }
  
  private static bool CmpEmbed(DXD.Blip openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Embed, value, diffs, objName, "Embed");
  }
  
  private static void SetEmbed(DXD.Blip openXmlElement, String? value)
  {
    openXmlElement.Embed = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  private static String? GetLink(DXD.Blip openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Link);
  }
  
  private static bool CmpLink(DXD.Blip openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Link, value, diffs, objName, "Link");
  }
  
  private static void SetLink(DXD.Blip openXmlElement, String? value)
  {
    openXmlElement.Link = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Compression state for blips.
  /// </summary>
  private static DMD.BlipCompressionKind? GetCompressionState(DXD.Blip openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues, DMD.BlipCompressionKind>(openXmlElement?.CompressionState?.Value);
  }
  
  private static bool CmpCompressionState(DXD.Blip openXmlElement, DMD.BlipCompressionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues, DMD.BlipCompressionKind>(openXmlElement?.CompressionState?.Value, value, diffs, objName);
  }
  
  private static void SetCompressionState(DXD.Blip openXmlElement, DMD.BlipCompressionKind? value)
  {
    openXmlElement.CompressionState = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues, DMD.BlipCompressionKind>(value);
  }
  
  private static DMD.AlphaBiLevel? GetAlphaBiLevel(DXD.Blip openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.AlphaBiLevel>();
    if (element != null)
      return DMXD.AlphaBiLevelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaBiLevel(DXD.Blip openXmlElement, DMD.AlphaBiLevel? value, DiffList? diffs, string? objName)
  {
    return DMXD.AlphaBiLevelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.AlphaBiLevel>(), value, diffs, objName);
  }
  
  private static void SetAlphaBiLevel(DXD.Blip openXmlElement, DMD.AlphaBiLevel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AlphaBiLevel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AlphaBiLevelConverter.CreateOpenXmlElement<DXD.AlphaBiLevel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetAlphaCeiling(DXD.Blip openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.AlphaCeiling>() != null;
  }
  
  private static bool CmpAlphaCeiling(DXD.Blip openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.AlphaCeiling>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.AlphaCeiling", val, value);
    return false;
  }
  
  private static void SetAlphaCeiling(DXD.Blip openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.AlphaCeiling>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.AlphaCeiling();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetAlphaFloor(DXD.Blip openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.AlphaFloor>() != null;
  }
  
  private static bool CmpAlphaFloor(DXD.Blip openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.AlphaFloor>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.AlphaFloor", val, value);
    return false;
  }
  
  private static void SetAlphaFloor(DXD.Blip openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.AlphaFloor>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.AlphaFloor();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.AlphaInverse? GetAlphaInverse(DXD.Blip openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.AlphaInverse>();
    if (element != null)
      return DMXD.AlphaInverseConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaInverse(DXD.Blip openXmlElement, DMD.AlphaInverse? value, DiffList? diffs, string? objName)
  {
    return DMXD.AlphaInverseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.AlphaInverse>(), value, diffs, objName);
  }
  
  private static void SetAlphaInverse(DXD.Blip openXmlElement, DMD.AlphaInverse? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AlphaInverse>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AlphaInverseConverter.CreateOpenXmlElement<DXD.AlphaInverse>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.AlphaModulationEffect? GetAlphaModulationEffect(DXD.Blip openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.AlphaModulationEffect>();
    if (element != null)
      return DMXD.AlphaModulationEffectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaModulationEffect(DXD.Blip openXmlElement, DMD.AlphaModulationEffect? value, DiffList? diffs, string? objName)
  {
    return DMXD.AlphaModulationEffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.AlphaModulationEffect>(), value, diffs, objName);
  }
  
  private static void SetAlphaModulationEffect(DXD.Blip openXmlElement, DMD.AlphaModulationEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AlphaModulationEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AlphaModulationEffectConverter.CreateOpenXmlElement<DXD.AlphaModulationEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.AlphaModulationFixed? GetAlphaModulationFixed(DXD.Blip openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.AlphaModulationFixed>();
    if (element != null)
      return DMXD.AlphaModulationFixedConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaModulationFixed(DXD.Blip openXmlElement, DMD.AlphaModulationFixed? value, DiffList? diffs, string? objName)
  {
    return DMXD.AlphaModulationFixedConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.AlphaModulationFixed>(), value, diffs, objName);
  }
  
  private static void SetAlphaModulationFixed(DXD.Blip openXmlElement, DMD.AlphaModulationFixed? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AlphaModulationFixed>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AlphaModulationFixedConverter.CreateOpenXmlElement<DXD.AlphaModulationFixed>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.AlphaReplace? GetAlphaReplace(DXD.Blip openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.AlphaReplace>();
    if (element != null)
      return DMXD.AlphaReplaceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaReplace(DXD.Blip openXmlElement, DMD.AlphaReplace? value, DiffList? diffs, string? objName)
  {
    return DMXD.AlphaReplaceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.AlphaReplace>(), value, diffs, objName);
  }
  
  private static void SetAlphaReplace(DXD.Blip openXmlElement, DMD.AlphaReplace? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AlphaReplace>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AlphaReplaceConverter.CreateOpenXmlElement<DXD.AlphaReplace>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.BiLevel? GetBiLevel(DXD.Blip openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.BiLevel>();
    if (element != null)
      return DMXD.BiLevelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBiLevel(DXD.Blip openXmlElement, DMD.BiLevel? value, DiffList? diffs, string? objName)
  {
    return DMXD.BiLevelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.BiLevel>(), value, diffs, objName);
  }
  
  private static void SetBiLevel(DXD.Blip openXmlElement, DMD.BiLevel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.BiLevel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BiLevelConverter.CreateOpenXmlElement<DXD.BiLevel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.Blur? GetBlur(DXD.Blip openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Blur>();
    if (element != null)
      return DMXD.BlurConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBlur(DXD.Blip openXmlElement, DMD.Blur? value, DiffList? diffs, string? objName)
  {
    return DMXD.BlurConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Blur>(), value, diffs, objName);
  }
  
  private static void SetBlur(DXD.Blip openXmlElement, DMD.Blur? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Blur>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BlurConverter.CreateOpenXmlElement<DXD.Blur>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.ColorChange? GetColorChange(DXD.Blip openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ColorChange>();
    if (element != null)
      return DMXD.ColorChangeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorChange(DXD.Blip openXmlElement, DMD.ColorChange? value, DiffList? diffs, string? objName)
  {
    return DMXD.ColorChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ColorChange>(), value, diffs, objName);
  }
  
  private static void SetColorChange(DXD.Blip openXmlElement, DMD.ColorChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ColorChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ColorChangeConverter.CreateOpenXmlElement<DXD.ColorChange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.ColorReplacement? GetColorReplacement(DXD.Blip openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ColorReplacement>();
    if (element != null)
      return DMXD.ColorReplacementConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorReplacement(DXD.Blip openXmlElement, DMD.ColorReplacement? value, DiffList? diffs, string? objName)
  {
    return DMXD.ColorReplacementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ColorReplacement>(), value, diffs, objName);
  }
  
  private static void SetColorReplacement(DXD.Blip openXmlElement, DMD.ColorReplacement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ColorReplacement>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ColorReplacementConverter.CreateOpenXmlElement<DXD.ColorReplacement>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.Duotone? GetDuotone(DXD.Blip openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Duotone>();
    if (element != null)
      return DMXD.DuotoneConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDuotone(DXD.Blip openXmlElement, DMD.Duotone? value, DiffList? diffs, string? objName)
  {
    return DMXD.DuotoneConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Duotone>(), value, diffs, objName);
  }
  
  private static void SetDuotone(DXD.Blip openXmlElement, DMD.Duotone? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Duotone>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.DuotoneConverter.CreateOpenXmlElement<DXD.Duotone>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.FillOverlay? GetFillOverlay(DXD.Blip openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.FillOverlay>();
    if (element != null)
      return DMXD.FillOverlayConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFillOverlay(DXD.Blip openXmlElement, DMD.FillOverlay? value, DiffList? diffs, string? objName)
  {
    return DMXD.FillOverlayConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.FillOverlay>(), value, diffs, objName);
  }
  
  private static void SetFillOverlay(DXD.Blip openXmlElement, DMD.FillOverlay? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.FillOverlay>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.FillOverlayConverter.CreateOpenXmlElement<DXD.FillOverlay>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean GetGrayscale(DXD.Blip openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.Grayscale>() != null;
  }
  
  private static bool CmpGrayscale(DXD.Blip openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.Grayscale>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.Grayscale", val, value);
    return false;
  }
  
  private static void SetGrayscale(DXD.Blip openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.Grayscale>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.Grayscale();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.Hsl? GetHsl(DXD.Blip openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Hsl>();
    if (element != null)
      return DMXD.HslConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHsl(DXD.Blip openXmlElement, DMD.Hsl? value, DiffList? diffs, string? objName)
  {
    return DMXD.HslConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Hsl>(), value, diffs, objName);
  }
  
  private static void SetHsl(DXD.Blip openXmlElement, DMD.Hsl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Hsl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.HslConverter.CreateOpenXmlElement<DXD.Hsl>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.LuminanceEffect? GetLuminanceEffect(DXD.Blip openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.LuminanceEffect>();
    if (element != null)
      return DMXD.LuminanceEffectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLuminanceEffect(DXD.Blip openXmlElement, DMD.LuminanceEffect? value, DiffList? diffs, string? objName)
  {
    return DMXD.LuminanceEffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.LuminanceEffect>(), value, diffs, objName);
  }
  
  private static void SetLuminanceEffect(DXD.Blip openXmlElement, DMD.LuminanceEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.LuminanceEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.LuminanceEffectConverter.CreateOpenXmlElement<DXD.LuminanceEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.TintEffect? GetTintEffect(DXD.Blip openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.TintEffect>();
    if (element != null)
      return DMXD.TintEffectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTintEffect(DXD.Blip openXmlElement, DMD.TintEffect? value, DiffList? diffs, string? objName)
  {
    return DMXD.TintEffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.TintEffect>(), value, diffs, objName);
  }
  
  private static void SetTintEffect(DXD.Blip openXmlElement, DMD.TintEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.TintEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.TintEffectConverter.CreateOpenXmlElement<DXD.TintEffect>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.BlipExtensionList? GetBlipExtensionList(DXD.Blip openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.BlipExtensionList>();
    if (element != null)
      return DMXD.BlipExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBlipExtensionList(DXD.Blip openXmlElement, DMD.BlipExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXD.BlipExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.BlipExtensionList>(), value, diffs, objName);
  }
  
  private static void SetBlipExtensionList(DXD.Blip openXmlElement, DMD.BlipExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.BlipExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BlipExtensionListConverter.CreateOpenXmlElement<DXD.BlipExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Blip? CreateModelElement(DXD.Blip? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Blip();
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
  
  public static bool CompareModelElement(DXD.Blip? openXmlElement, DMD.Blip? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Blip value)
    where OpenXmlElementType: DXD.Blip, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Blip openXmlElement, DMD.Blip value)
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
