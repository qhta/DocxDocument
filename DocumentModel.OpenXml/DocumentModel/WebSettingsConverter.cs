namespace DocumentModel.OpenXml;

/// <summary>
/// Web Page Settings.
/// </summary>
public static class WebSettingsConverter
{
  /// <summary>
  /// Frameset.
  /// </summary>
  private static DMW.Frameset? GetFrameset(DXW.WebSettings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Frameset>();
    if (element != null)
      return DMXW.FramesetConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFrameset(DXW.WebSettings openXmlElement, DMW.Frameset? value, DiffList? diffs, string? objName)
  {
    return DMXW.FramesetConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Frameset>(), value, diffs, objName);
  }
  
  private static void SetFrameset(DXW.WebSettings openXmlElement, DMW.Frameset? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Frameset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FramesetConverter.CreateOpenXmlElement<DXW.Frameset>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Divs.
  /// </summary>
  private static DMW.Divs? GetDivs(DXW.WebSettings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Divs>();
    if (element != null)
      return DMXW.DivsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDivs(DXW.WebSettings openXmlElement, DMW.Divs? value, DiffList? diffs, string? objName)
  {
    return DMXW.DivsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Divs>(), value, diffs, objName);
  }
  
  private static void SetDivs(DXW.WebSettings openXmlElement, DMW.Divs? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Divs>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DivsConverter.CreateOpenXmlElement<DXW.Divs>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// WebPageEncoding.
  /// </summary>
  private static String? GetWebPageEncoding(DXW.WebSettings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.WebPageEncoding>()?.Val?.Value;
  }
  
  private static bool CmpWebPageEncoding(DXW.WebSettings openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.WebPageEncoding>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "WebPageEncoding", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetWebPageEncoding(DXW.WebSettings openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.WebPageEncoding>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.WebPageEncoding { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// OptimizeForBrowser.
  /// </summary>
  private static Boolean? GetOptimizeForBrowser(DXW.WebSettings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.OptimizeForBrowser>());
  }
  
  private static bool CmpOptimizeForBrowser(DXW.WebSettings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.OptimizeForBrowser>(), value, diffs, objName);
  }
  
  private static void SetOptimizeForBrowser(DXW.WebSettings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.OptimizeForBrowser>(openXmlElement, value);
  }
  
  /// <summary>
  /// RelyOnVML.
  /// </summary>
  private static Boolean? GetRelyOnVML(DXW.WebSettings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.RelyOnVML>());
  }
  
  private static bool CmpRelyOnVML(DXW.WebSettings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.RelyOnVML>(), value, diffs, objName);
  }
  
  private static void SetRelyOnVML(DXW.WebSettings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.RelyOnVML>(openXmlElement, value);
  }
  
  /// <summary>
  /// AllowPNG.
  /// </summary>
  private static Boolean? GetAllowPNG(DXW.WebSettings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.AllowPNG>());
  }
  
  private static bool CmpAllowPNG(DXW.WebSettings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.AllowPNG>(), value, diffs, objName);
  }
  
  private static void SetAllowPNG(DXW.WebSettings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.AllowPNG>(openXmlElement, value);
  }
  
  /// <summary>
  /// DoNotRelyOnCSS.
  /// </summary>
  private static Boolean? GetDoNotRelyOnCSS(DXW.WebSettings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotRelyOnCSS>());
  }
  
  private static bool CmpDoNotRelyOnCSS(DXW.WebSettings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotRelyOnCSS>(), value, diffs, objName);
  }
  
  private static void SetDoNotRelyOnCSS(DXW.WebSettings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotRelyOnCSS>(openXmlElement, value);
  }
  
  /// <summary>
  /// DoNotSaveAsSingleFile.
  /// </summary>
  private static Boolean? GetDoNotSaveAsSingleFile(DXW.WebSettings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotSaveAsSingleFile>());
  }
  
  private static bool CmpDoNotSaveAsSingleFile(DXW.WebSettings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotSaveAsSingleFile>(), value, diffs, objName);
  }
  
  private static void SetDoNotSaveAsSingleFile(DXW.WebSettings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotSaveAsSingleFile>(openXmlElement, value);
  }
  
  /// <summary>
  /// DoNotOrganizeInFolder.
  /// </summary>
  private static Boolean? GetDoNotOrganizeInFolder(DXW.WebSettings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotOrganizeInFolder>());
  }
  
  private static bool CmpDoNotOrganizeInFolder(DXW.WebSettings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotOrganizeInFolder>(), value, diffs, objName);
  }
  
  private static void SetDoNotOrganizeInFolder(DXW.WebSettings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotOrganizeInFolder>(openXmlElement, value);
  }
  
  /// <summary>
  /// DoNotUseLongFileNames.
  /// </summary>
  private static Boolean? GetDoNotUseLongFileNames(DXW.WebSettings openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DoNotUseLongFileNames>());
  }
  
  private static bool CmpDoNotUseLongFileNames(DXW.WebSettings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DoNotUseLongFileNames>(), value, diffs, objName);
  }
  
  private static void SetDoNotUseLongFileNames(DXW.WebSettings openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DoNotUseLongFileNames>(openXmlElement, value);
  }
  
  /// <summary>
  /// PixelsPerInch.
  /// </summary>
  private static Int32? GetPixelsPerInch(DXW.WebSettings openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.PixelsPerInch>()?.Val);
  }
  
  private static bool CmpPixelsPerInch(DXW.WebSettings openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.PixelsPerInch>()?.Val, value, diffs, objName, "PixelsPerInch");
  }
  
  private static void SetPixelsPerInch(DXW.WebSettings openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.PixelsPerInch,System.Int32>(openXmlElement, value);
  }
  
  /// <summary>
  /// TargetScreenSize.
  /// </summary>
  private static DMW.TargetScreenSizeKind? GetTargetScreenSize(DXW.WebSettings openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.TargetScreenSizeValues, DMW.TargetScreenSizeKind>(openXmlElement.GetFirstChild<DXW.TargetScreenSize>()?.Val?.Value);
  }
  
  private static bool CmpTargetScreenSize(DXW.WebSettings openXmlElement, DMW.TargetScreenSizeKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.TargetScreenSizeValues, DMW.TargetScreenSizeKind>(openXmlElement.GetFirstChild<DXW.TargetScreenSize>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetTargetScreenSize(DXW.WebSettings openXmlElement, DMW.TargetScreenSizeKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TargetScreenSize>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.TargetScreenSizeValues, DMW.TargetScreenSizeKind>(itemElement, (DMW.TargetScreenSizeKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TargetScreenSize, DXW.TargetScreenSizeValues, DMW.TargetScreenSizeKind>((DMW.TargetScreenSizeKind)value));
  }
  
  public static DocumentModel.WebSettings? CreateModelElement(DXW.WebSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebSettings();
      value.Frameset = GetFrameset(openXmlElement);
      value.Divs = GetDivs(openXmlElement);
      value.WebPageEncoding = GetWebPageEncoding(openXmlElement);
      value.OptimizeForBrowser = GetOptimizeForBrowser(openXmlElement);
      value.RelyOnVML = GetRelyOnVML(openXmlElement);
      value.AllowPNG = GetAllowPNG(openXmlElement);
      value.DoNotRelyOnCSS = GetDoNotRelyOnCSS(openXmlElement);
      value.DoNotSaveAsSingleFile = GetDoNotSaveAsSingleFile(openXmlElement);
      value.DoNotOrganizeInFolder = GetDoNotOrganizeInFolder(openXmlElement);
      value.DoNotUseLongFileNames = GetDoNotUseLongFileNames(openXmlElement);
      value.PixelsPerInch = GetPixelsPerInch(openXmlElement);
      value.TargetScreenSize = GetTargetScreenSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.WebSettings? openXmlElement, DM.WebSettings? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFrameset(openXmlElement, value.Frameset, diffs, objName))
        ok = false;
      if (!CmpDivs(openXmlElement, value.Divs, diffs, objName))
        ok = false;
      if (!CmpWebPageEncoding(openXmlElement, value.WebPageEncoding, diffs, objName))
        ok = false;
      if (!CmpOptimizeForBrowser(openXmlElement, value.OptimizeForBrowser, diffs, objName))
        ok = false;
      if (!CmpRelyOnVML(openXmlElement, value.RelyOnVML, diffs, objName))
        ok = false;
      if (!CmpAllowPNG(openXmlElement, value.AllowPNG, diffs, objName))
        ok = false;
      if (!CmpDoNotRelyOnCSS(openXmlElement, value.DoNotRelyOnCSS, diffs, objName))
        ok = false;
      if (!CmpDoNotSaveAsSingleFile(openXmlElement, value.DoNotSaveAsSingleFile, diffs, objName))
        ok = false;
      if (!CmpDoNotOrganizeInFolder(openXmlElement, value.DoNotOrganizeInFolder, diffs, objName))
        ok = false;
      if (!CmpDoNotUseLongFileNames(openXmlElement, value.DoNotUseLongFileNames, diffs, objName))
        ok = false;
      if (!CmpPixelsPerInch(openXmlElement, value.PixelsPerInch, diffs, objName))
        ok = false;
      if (!CmpTargetScreenSize(openXmlElement, value.TargetScreenSize, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.WebSettings value)
    where OpenXmlElementType: DXW.WebSettings, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.WebSettings openXmlElement, DM.WebSettings value)
  {
    SetFrameset(openXmlElement, value?.Frameset);
    SetDivs(openXmlElement, value?.Divs);
    SetWebPageEncoding(openXmlElement, value?.WebPageEncoding);
    SetOptimizeForBrowser(openXmlElement, value?.OptimizeForBrowser);
    SetRelyOnVML(openXmlElement, value?.RelyOnVML);
    SetAllowPNG(openXmlElement, value?.AllowPNG);
    SetDoNotRelyOnCSS(openXmlElement, value?.DoNotRelyOnCSS);
    SetDoNotSaveAsSingleFile(openXmlElement, value?.DoNotSaveAsSingleFile);
    SetDoNotOrganizeInFolder(openXmlElement, value?.DoNotOrganizeInFolder);
    SetDoNotUseLongFileNames(openXmlElement, value?.DoNotUseLongFileNames);
    SetPixelsPerInch(openXmlElement, value?.PixelsPerInch);
    SetTargetScreenSize(openXmlElement, value?.TargetScreenSize);
  }
}
