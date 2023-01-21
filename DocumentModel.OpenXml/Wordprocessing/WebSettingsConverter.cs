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
    var itemElement = openXmlElement?.GetFirstChild<DXW.Frameset>();
    if (itemElement != null)
      return DMXW.FramesetConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.Divs>();
    if (itemElement != null)
      return DMXW.DivsConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.WebPageEncoding>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.OptimizeForBrowser>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.RelyOnVML>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.AllowPNG>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotRelyOnCSS>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotSaveAsSingleFile>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotOrganizeInFolder>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.DoNotUseLongFileNames>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.PixelsPerInch>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXW.TargetScreenSize>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TargetScreenSizeValues, DMW.TargetScreenSizeKind>(itemElement.Val.Value);
    return null;
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
