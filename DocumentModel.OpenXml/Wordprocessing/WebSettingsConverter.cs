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
    return FramesetConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Frameset>());
  }

  private static bool CmpFrameset(DXW.WebSettings openXmlElement, DMW.Frameset? value, DiffList? diffs, string? objName)
  {
    return FramesetConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Frameset>(), value, diffs, objName?.Concat2(".", openXmlElement?.GetType().Name));
  }

  private static void SetFrameset(DXW.WebSettings openXmlElement, DMW.Frameset? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Frameset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = FramesetConverter.CreateOpenXmlElement<DXW.Frameset>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  /// <summary>
  /// Divs.
  /// </summary>
  private static DMW.Divs? GetDivs(DXW.WebSettings openXmlElement)
  {
    return DivsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Divs>());
  }

  private static bool CmpDivs(DXW.WebSettings openXmlElement, DMW.Divs? value, DiffList? diffs, string? objName)
  {
    return DivsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Divs>(), value, diffs, objName?.Concat2(".", openXmlElement?.GetType().Name));
  }

  private static void SetDivs(DXW.WebSettings openXmlElement, DMW.Divs? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Divs>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DivsConverter.CreateOpenXmlElement<DXW.Divs>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  /// <summary>
  /// WebPageEncoding.
  /// </summary>
  private static string? GetWebPageEncoding(DXW.WebSettings openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.WebPageEncoding>()?.Val?.Value;
  }

  private static bool CmpWebPageEncoding(DXW.WebSettings openXmlElement, string? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.WebPageEncoding>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "WebPageEncoding", itemElement?.Val?.Value, value);
    return false;
  }

  private static void SetWebPageEncoding(DXW.WebSettings openXmlElement, string? value)
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
  private static bool? GetOptimizeForBrowser(DXW.WebSettings openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.OptimizeForBrowser>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }

  private static bool CmpOptimizeForBrowser(DXW.WebSettings openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    var val = GetOptimizeForBrowser(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.OptimizeForBrowser", val, value);
    return false;
  }

  private static void SetOptimizeForBrowser(DXW.WebSettings openXmlElement, bool? value)
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
  private static bool? GetRelyOnVML(DXW.WebSettings openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.RelyOnVML>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }

  private static bool CmpRelyOnVML(DXW.WebSettings openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    var val = GetRelyOnVML(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.RelyOnVML", val, value);
    return false;
  }

  private static void SetRelyOnVML(DXW.WebSettings openXmlElement, bool? value)
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
  private static bool? GetAllowPNG(DXW.WebSettings openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.AllowPNG>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }

  private static bool CmpAllowPNG(DXW.WebSettings openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    var val = GetAllowPNG(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.AllowPNG", val, value);
    return false;
  }

  private static void SetAllowPNG(DXW.WebSettings openXmlElement, bool? value)
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
  private static bool? GetDoNotRelyOnCSS(DXW.WebSettings openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.DoNotRelyOnCSS>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }

  private static bool CmpDoNotRelyOnCSS(DXW.WebSettings openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    var val = GetDoNotRelyOnCSS(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.DoNotRelyOnCSS", val, value);
    return false;
  }

  private static void SetDoNotRelyOnCSS(DXW.WebSettings openXmlElement, bool? value)
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
  private static bool? GetDoNotSaveAsSingleFile(DXW.WebSettings openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.DoNotSaveAsSingleFile>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }

  private static bool CmpDoNotSaveAsSingleFile(DXW.WebSettings openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    var val = GetDoNotSaveAsSingleFile(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.DoNotSaveAsSingleFile", val, value);
    return false;
  }

  private static void SetDoNotSaveAsSingleFile(DXW.WebSettings openXmlElement, bool? value)
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
  private static bool? GetDoNotOrganizeInFolder(DXW.WebSettings openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.DoNotOrganizeInFolder>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }

  private static bool CmpDoNotOrganizeInFolder(DXW.WebSettings openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    var val = GetDoNotOrganizeInFolder(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.DoNotOrganizeInFolder", val, value);
    return false;
  }

  private static void SetDoNotOrganizeInFolder(DXW.WebSettings openXmlElement, bool? value)
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
  private static bool? GetDoNotUseLongFileNames(DXW.WebSettings openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.DoNotUseLongFileNames>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }

  private static bool CmpDoNotUseLongFileNames(DXW.WebSettings openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    var val = GetDoNotUseLongFileNames(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.DoNotUseLongFileNames", val, value);
    return false;
  }

  private static void SetDoNotUseLongFileNames(DXW.WebSettings openXmlElement, bool? value)
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
  private static int? GetPixelsPerInch(DXW.WebSettings openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.PixelsPerInch>()?.Val?.Value;
  }

  private static bool CmpPixelsPerInch(DXW.WebSettings openXmlElement, int? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.PixelsPerInch>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.PixelsPerInch", itemElement?.Val?.Value, value);
    return false;
  }

  private static void SetPixelsPerInch(DXW.WebSettings openXmlElement, int? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PixelsPerInch>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.PixelsPerInch { Val = value };
      openXmlElement.AddChild(itemElement);
    }
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
    return EnumValueConverter.CmpValue<DXW.TargetScreenSizeValues, DMW.TargetScreenSizeKind>(openXmlElement.GetFirstChild<DXW.TargetScreenSize>()?.Val?.Value, value, diffs, objName?.Concat2(".", openXmlElement?.GetType().Name));
  }

  private static void SetTargetScreenSize(DXW.WebSettings openXmlElement, DMW.TargetScreenSizeKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TargetScreenSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.TargetScreenSize, DXW.TargetScreenSizeValues, DMW.TargetScreenSizeKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  public static DM.WebSettings? CreateModelElement(DXW.WebSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.WebSettings();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.WebSettings? value)
    where OpenXmlElementType : DXW.WebSettings, new()
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
