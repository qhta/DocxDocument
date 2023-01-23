namespace DocumentModel.OpenXml.Wordprocessing;

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
    return DMXW.FramesetConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Frameset>());
  }
  
  private static bool CmpFrameset(DXW.WebSettings openXmlElement, DMW.Frameset? value, DiffList? diffs, string? objName)
  {
    return DMXW.FramesetConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.Frameset>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXW.DivsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Divs>());
  }
  
  private static bool CmpDivs(DXW.WebSettings openXmlElement, DMW.Divs? value, DiffList? diffs, string? objName)
  {
    return DMXW.DivsConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.Divs>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
      return openXmlElement.GetFirstChild<DXW.WebPageEncoding>()?.Val?.Value == value;
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
    return openXmlElement.GetFirstChild<DXW.OptimizeForBrowser>()?.Val?.Value;
  }
  
  private static bool CmpOptimizeForBrowser(DXW.WebSettings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.OptimizeForBrowser>()?.Val?.Value == value;
  }
  
  private static void SetOptimizeForBrowser(DXW.WebSettings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.OptimizeForBrowser>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.OptimizeForBrowser();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// RelyOnVML.
  /// </summary>
  private static Boolean? GetRelyOnVML(DXW.WebSettings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.RelyOnVML>()?.Val?.Value;
  }
  
  private static bool CmpRelyOnVML(DXW.WebSettings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.RelyOnVML>()?.Val?.Value == value;
  }
  
  private static void SetRelyOnVML(DXW.WebSettings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.RelyOnVML>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.RelyOnVML();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// AllowPNG.
  /// </summary>
  private static Boolean? GetAllowPNG(DXW.WebSettings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.AllowPNG>()?.Val?.Value;
  }
  
  private static bool CmpAllowPNG(DXW.WebSettings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.AllowPNG>()?.Val?.Value == value;
  }
  
  private static void SetAllowPNG(DXW.WebSettings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.AllowPNG>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.AllowPNG();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DoNotRelyOnCSS.
  /// </summary>
  private static Boolean? GetDoNotRelyOnCSS(DXW.WebSettings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotRelyOnCSS>()?.Val?.Value;
  }
  
  private static bool CmpDoNotRelyOnCSS(DXW.WebSettings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotRelyOnCSS>()?.Val?.Value == value;
  }
  
  private static void SetDoNotRelyOnCSS(DXW.WebSettings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotRelyOnCSS>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotRelyOnCSS();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DoNotSaveAsSingleFile.
  /// </summary>
  private static Boolean? GetDoNotSaveAsSingleFile(DXW.WebSettings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotSaveAsSingleFile>()?.Val?.Value;
  }
  
  private static bool CmpDoNotSaveAsSingleFile(DXW.WebSettings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotSaveAsSingleFile>()?.Val?.Value == value;
  }
  
  private static void SetDoNotSaveAsSingleFile(DXW.WebSettings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotSaveAsSingleFile>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotSaveAsSingleFile();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DoNotOrganizeInFolder.
  /// </summary>
  private static Boolean? GetDoNotOrganizeInFolder(DXW.WebSettings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotOrganizeInFolder>()?.Val?.Value;
  }
  
  private static bool CmpDoNotOrganizeInFolder(DXW.WebSettings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotOrganizeInFolder>()?.Val?.Value == value;
  }
  
  private static void SetDoNotOrganizeInFolder(DXW.WebSettings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotOrganizeInFolder>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotOrganizeInFolder();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DoNotUseLongFileNames.
  /// </summary>
  private static Boolean? GetDoNotUseLongFileNames(DXW.WebSettings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotUseLongFileNames>()?.Val?.Value;
  }
  
  private static bool CmpDoNotUseLongFileNames(DXW.WebSettings openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.DoNotUseLongFileNames>()?.Val?.Value == value;
  }
  
  private static void SetDoNotUseLongFileNames(DXW.WebSettings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DoNotUseLongFileNames>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DoNotUseLongFileNames();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PixelsPerInch.
  /// </summary>
  private static Int32? GetPixelsPerInch(DXW.WebSettings openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.PixelsPerInch>()?.Val?.Value;
  }
  
  private static bool CmpPixelsPerInch(DXW.WebSettings openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXW.PixelsPerInch>()?.Val?.Value == value;
  }
  
  private static void SetPixelsPerInch(DXW.WebSettings openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PixelsPerInch>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.PixelsPerInch{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TargetScreenSize.
  /// </summary>
  private static DMW.TargetScreenSizeKind? GetTargetScreenSize(DXW.WebSettings openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TargetScreenSizeValues, DMW.TargetScreenSizeKind>(openXmlElement.GetFirstChild<DXW.TargetScreenSize>()?.Val?.Value);
  }
  
  private static bool CmpTargetScreenSize(DXW.WebSettings openXmlElement, DMW.TargetScreenSizeKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TargetScreenSizeValues, DMW.TargetScreenSizeKind>(openXmlElement.GetFirstChild<DXW.TargetScreenSize>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTargetScreenSize(DXW.WebSettings openXmlElement, DMW.TargetScreenSizeKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TargetScreenSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.TargetScreenSize, DocumentFormat.OpenXml.Wordprocessing.TargetScreenSizeValues, DMW.TargetScreenSizeKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.WebSettings? CreateModelElement(DXW.WebSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.WebSettings();
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
  
  public static bool CompareModelElement(DXW.WebSettings? openXmlElement, DMW.WebSettings? value, DiffList? diffs, string? objName)
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.WebSettings? value)
    where OpenXmlElementType: DXW.WebSettings, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
