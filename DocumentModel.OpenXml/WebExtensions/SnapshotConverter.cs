namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the Snapshot Class.
/// </summary>
public static class SnapshotConverter
{
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  private static String? GetEmbed(DXO13WE.Snapshot openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Embed);
  }
  
  private static bool CmpEmbed(DXO13WE.Snapshot openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Embed, value, diffs, objName, "Embed");
  }
  
  private static void SetEmbed(DXO13WE.Snapshot openXmlElement, String? value)
  {
    openXmlElement.Embed = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  private static String? GetLink(DXO13WE.Snapshot openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Link);
  }
  
  private static bool CmpLink(DXO13WE.Snapshot openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Link, value, diffs, objName, "Link");
  }
  
  private static void SetLink(DXO13WE.Snapshot openXmlElement, String? value)
  {
    openXmlElement.Link = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Compression state for blips.
  /// </summary>
  private static DMD.BlipCompressionKind? GetCompressionState(DXO13WE.Snapshot openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues, DMD.BlipCompressionKind>(openXmlElement?.CompressionState?.Value);
  }
  
  private static bool CmpCompressionState(DXO13WE.Snapshot openXmlElement, DMD.BlipCompressionKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues, DMD.BlipCompressionKind>(openXmlElement?.CompressionState?.Value, value, diffs, objName, propName);
  }
  
  private static void SetCompressionState(DXO13WE.Snapshot openXmlElement, DMD.BlipCompressionKind? value)
  {
    openXmlElement.CompressionState = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues, DMD.BlipCompressionKind>(value);
  }
  
  private static DMD.AlphaBiLevel? GetAlphaBiLevel(DXO13WE.Snapshot openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.AlphaBiLevel>();
    if (element != null)
      return DMXD.AlphaBiLevelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaBiLevel(DXO13WE.Snapshot openXmlElement, DMD.AlphaBiLevel? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.AlphaBiLevelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.AlphaBiLevel>(), value, diffs, objName, propName);
  }
  
  private static void SetAlphaBiLevel(DXO13WE.Snapshot openXmlElement, DMD.AlphaBiLevel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AlphaBiLevel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AlphaBiLevelConverter.CreateOpenXmlElement<DXD.AlphaBiLevel>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetAlphaCeiling(DXO13WE.Snapshot openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.AlphaCeiling>() != null;
  }
  
  private static bool CmpAlphaCeiling(DXO13WE.Snapshot openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.AlphaCeiling>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.AlphaCeiling", val, value);
    return false;
  }
  
  private static void SetAlphaCeiling(DXO13WE.Snapshot openXmlElement, Boolean? value)
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
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetAlphaFloor(DXO13WE.Snapshot openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.AlphaFloor>() != null;
  }
  
  private static bool CmpAlphaFloor(DXO13WE.Snapshot openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.AlphaFloor>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.AlphaFloor", val, value);
    return false;
  }
  
  private static void SetAlphaFloor(DXO13WE.Snapshot openXmlElement, Boolean? value)
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
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.AlphaInverse? GetAlphaInverse(DXO13WE.Snapshot openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.AlphaInverse>();
    if (element != null)
      return DMXD.AlphaInverseConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaInverse(DXO13WE.Snapshot openXmlElement, DMD.AlphaInverse? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.AlphaInverseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.AlphaInverse>(), value, diffs, objName, propName);
  }
  
  private static void SetAlphaInverse(DXO13WE.Snapshot openXmlElement, DMD.AlphaInverse? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AlphaInverse>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AlphaInverseConverter.CreateOpenXmlElement<DXD.AlphaInverse>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.AlphaModulationEffect? GetAlphaModulationEffect(DXO13WE.Snapshot openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.AlphaModulationEffect>();
    if (element != null)
      return DMXD.AlphaModulationEffectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaModulationEffect(DXO13WE.Snapshot openXmlElement, DMD.AlphaModulationEffect? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.AlphaModulationEffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.AlphaModulationEffect>(), value, diffs, objName, propName);
  }
  
  private static void SetAlphaModulationEffect(DXO13WE.Snapshot openXmlElement, DMD.AlphaModulationEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AlphaModulationEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AlphaModulationEffectConverter.CreateOpenXmlElement<DXD.AlphaModulationEffect>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.AlphaModulationFixed? GetAlphaModulationFixed(DXO13WE.Snapshot openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.AlphaModulationFixed>();
    if (element != null)
      return DMXD.AlphaModulationFixedConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaModulationFixed(DXO13WE.Snapshot openXmlElement, DMD.AlphaModulationFixed? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.AlphaModulationFixedConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.AlphaModulationFixed>(), value, diffs, objName, propName);
  }
  
  private static void SetAlphaModulationFixed(DXO13WE.Snapshot openXmlElement, DMD.AlphaModulationFixed? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AlphaModulationFixed>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AlphaModulationFixedConverter.CreateOpenXmlElement<DXD.AlphaModulationFixed>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.AlphaReplace? GetAlphaReplace(DXO13WE.Snapshot openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.AlphaReplace>();
    if (element != null)
      return DMXD.AlphaReplaceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlphaReplace(DXO13WE.Snapshot openXmlElement, DMD.AlphaReplace? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.AlphaReplaceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.AlphaReplace>(), value, diffs, objName, propName);
  }
  
  private static void SetAlphaReplace(DXO13WE.Snapshot openXmlElement, DMD.AlphaReplace? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AlphaReplace>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AlphaReplaceConverter.CreateOpenXmlElement<DXD.AlphaReplace>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.BiLevel? GetBiLevel(DXO13WE.Snapshot openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.BiLevel>();
    if (element != null)
      return DMXD.BiLevelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBiLevel(DXO13WE.Snapshot openXmlElement, DMD.BiLevel? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.BiLevelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.BiLevel>(), value, diffs, objName, propName);
  }
  
  private static void SetBiLevel(DXO13WE.Snapshot openXmlElement, DMD.BiLevel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.BiLevel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BiLevelConverter.CreateOpenXmlElement<DXD.BiLevel>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Blur? GetBlur(DXO13WE.Snapshot openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Blur>();
    if (element != null)
      return DMXD.BlurConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBlur(DXO13WE.Snapshot openXmlElement, DMD.Blur? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.BlurConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Blur>(), value, diffs, objName, propName);
  }
  
  private static void SetBlur(DXO13WE.Snapshot openXmlElement, DMD.Blur? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Blur>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BlurConverter.CreateOpenXmlElement<DXD.Blur>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.ColorChange? GetColorChange(DXO13WE.Snapshot openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ColorChange>();
    if (element != null)
      return DMXD.ColorChangeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorChange(DXO13WE.Snapshot openXmlElement, DMD.ColorChange? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ColorChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ColorChange>(), value, diffs, objName, propName);
  }
  
  private static void SetColorChange(DXO13WE.Snapshot openXmlElement, DMD.ColorChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ColorChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ColorChangeConverter.CreateOpenXmlElement<DXD.ColorChange>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.ColorReplacement? GetColorReplacement(DXO13WE.Snapshot openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ColorReplacement>();
    if (element != null)
      return DMXD.ColorReplacementConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorReplacement(DXO13WE.Snapshot openXmlElement, DMD.ColorReplacement? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ColorReplacementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ColorReplacement>(), value, diffs, objName, propName);
  }
  
  private static void SetColorReplacement(DXO13WE.Snapshot openXmlElement, DMD.ColorReplacement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ColorReplacement>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ColorReplacementConverter.CreateOpenXmlElement<DXD.ColorReplacement>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Duotone? GetDuotone(DXO13WE.Snapshot openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Duotone>();
    if (element != null)
      return DMXD.DuotoneConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDuotone(DXO13WE.Snapshot openXmlElement, DMD.Duotone? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.DuotoneConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Duotone>(), value, diffs, objName, propName);
  }
  
  private static void SetDuotone(DXO13WE.Snapshot openXmlElement, DMD.Duotone? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Duotone>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.DuotoneConverter.CreateOpenXmlElement<DXD.Duotone>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.FillOverlay? GetFillOverlay(DXO13WE.Snapshot openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.FillOverlay>();
    if (element != null)
      return DMXD.FillOverlayConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFillOverlay(DXO13WE.Snapshot openXmlElement, DMD.FillOverlay? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.FillOverlayConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.FillOverlay>(), value, diffs, objName, propName);
  }
  
  private static void SetFillOverlay(DXO13WE.Snapshot openXmlElement, DMD.FillOverlay? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.FillOverlay>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.FillOverlayConverter.CreateOpenXmlElement<DXD.FillOverlay>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean GetGrayscale(DXO13WE.Snapshot openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.Grayscale>() != null;
  }
  
  private static bool CmpGrayscale(DXO13WE.Snapshot openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.Grayscale>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.Grayscale", val, value);
    return false;
  }
  
  private static void SetGrayscale(DXO13WE.Snapshot openXmlElement, Boolean? value)
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
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Hsl? GetHsl(DXO13WE.Snapshot openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Hsl>();
    if (element != null)
      return DMXD.HslConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHsl(DXO13WE.Snapshot openXmlElement, DMD.Hsl? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.HslConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Hsl>(), value, diffs, objName, propName);
  }
  
  private static void SetHsl(DXO13WE.Snapshot openXmlElement, DMD.Hsl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Hsl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.HslConverter.CreateOpenXmlElement<DXD.Hsl>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.LuminanceEffect? GetLuminanceEffect(DXO13WE.Snapshot openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.LuminanceEffect>();
    if (element != null)
      return DMXD.LuminanceEffectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLuminanceEffect(DXO13WE.Snapshot openXmlElement, DMD.LuminanceEffect? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LuminanceEffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.LuminanceEffect>(), value, diffs, objName, propName);
  }
  
  private static void SetLuminanceEffect(DXO13WE.Snapshot openXmlElement, DMD.LuminanceEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.LuminanceEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.LuminanceEffectConverter.CreateOpenXmlElement<DXD.LuminanceEffect>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.TintEffect? GetTintEffect(DXO13WE.Snapshot openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.TintEffect>();
    if (element != null)
      return DMXD.TintEffectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTintEffect(DXO13WE.Snapshot openXmlElement, DMD.TintEffect? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.TintEffectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.TintEffect>(), value, diffs, objName, propName);
  }
  
  private static void SetTintEffect(DXO13WE.Snapshot openXmlElement, DMD.TintEffect? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.TintEffect>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.TintEffectConverter.CreateOpenXmlElement<DXD.TintEffect>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.BlipExtensionList? GetBlipExtensionList(DXO13WE.Snapshot openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.BlipExtensionList>();
    if (element != null)
      return DMXD.BlipExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBlipExtensionList(DXO13WE.Snapshot openXmlElement, DMD.BlipExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.BlipExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.BlipExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetBlipExtensionList(DXO13WE.Snapshot openXmlElement, DMD.BlipExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.BlipExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BlipExtensionListConverter.CreateOpenXmlElement<DXD.BlipExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.WebExtensions.Snapshot? CreateModelElement(DXO13WE.Snapshot? openXmlElement)
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
  
  public static bool CompareModelElement(DXO13WE.Snapshot? openXmlElement, DMWE.Snapshot? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEmbed(openXmlElement, value.Embed, diffs, objName, propName))
        ok = false;
      if (!CmpLink(openXmlElement, value.Link, diffs, objName, propName))
        ok = false;
      if (!CmpCompressionState(openXmlElement, value.CompressionState, diffs, objName, propName))
        ok = false;
      if (!CmpAlphaBiLevel(openXmlElement, value.AlphaBiLevel, diffs, objName, propName))
        ok = false;
      if (!CmpAlphaCeiling(openXmlElement, value.AlphaCeiling, diffs, objName, propName))
        ok = false;
      if (!CmpAlphaFloor(openXmlElement, value.AlphaFloor, diffs, objName, propName))
        ok = false;
      if (!CmpAlphaInverse(openXmlElement, value.AlphaInverse, diffs, objName, propName))
        ok = false;
      if (!CmpAlphaModulationEffect(openXmlElement, value.AlphaModulationEffect, diffs, objName, propName))
        ok = false;
      if (!CmpAlphaModulationFixed(openXmlElement, value.AlphaModulationFixed, diffs, objName, propName))
        ok = false;
      if (!CmpAlphaReplace(openXmlElement, value.AlphaReplace, diffs, objName, propName))
        ok = false;
      if (!CmpBiLevel(openXmlElement, value.BiLevel, diffs, objName, propName))
        ok = false;
      if (!CmpBlur(openXmlElement, value.Blur, diffs, objName, propName))
        ok = false;
      if (!CmpColorChange(openXmlElement, value.ColorChange, diffs, objName, propName))
        ok = false;
      if (!CmpColorReplacement(openXmlElement, value.ColorReplacement, diffs, objName, propName))
        ok = false;
      if (!CmpDuotone(openXmlElement, value.Duotone, diffs, objName, propName))
        ok = false;
      if (!CmpFillOverlay(openXmlElement, value.FillOverlay, diffs, objName, propName))
        ok = false;
      if (!CmpGrayscale(openXmlElement, value.Grayscale, diffs, objName, propName))
        ok = false;
      if (!CmpHsl(openXmlElement, value.Hsl, diffs, objName, propName))
        ok = false;
      if (!CmpLuminanceEffect(openXmlElement, value.LuminanceEffect, diffs, objName, propName))
        ok = false;
      if (!CmpTintEffect(openXmlElement, value.TintEffect, diffs, objName, propName))
        ok = false;
      if (!CmpBlipExtensionList(openXmlElement, value.BlipExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMWE.Snapshot value)
    where OpenXmlElementType: DXO13WE.Snapshot, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13WE.Snapshot openXmlElement, DMWE.Snapshot value)
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
