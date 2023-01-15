using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using Divs = DocumentModel.Wordprocessing.Divs;
using Frameset = DocumentModel.Wordprocessing.Frameset;
using WebSettings = DocumentFormat.OpenXml.Wordprocessing.WebSettings;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Web Page Settings.
/// </summary>
public static class WebSettingsConverter
{
  /// <summary>
  ///   Frameset.
  /// </summary>
  public static Frameset? GetFrameset(WebSettings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Frameset>();
    if (itemElement != null)
      return FramesetConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFrameset(WebSettings? openXmlElement, Frameset? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Frameset>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FramesetConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Frameset>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Divs.
  /// </summary>
  public static Divs? GetDivs(WebSettings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Divs>();
    if (itemElement != null)
      return DivsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDivs(WebSettings? openXmlElement, Divs? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Divs>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DivsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Divs>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   WebPageEncoding.
  /// </summary>
  public static String? GetWebPageEncoding(WebSettings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<WebPageEncoding>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetWebPageEncoding(WebSettings? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<WebPageEncoding>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new WebPageEncoding { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   OptimizeForBrowser.
  /// </summary>
  public static Boolean? GetOptimizeForBrowser(WebSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<OptimizeForBrowser>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetOptimizeForBrowser(WebSettings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<OptimizeForBrowser>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new OptimizeForBrowser();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   RelyOnVML.
  /// </summary>
  public static Boolean? GetRelyOnVML(WebSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RelyOnVML>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetRelyOnVML(WebSettings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<RelyOnVML>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new RelyOnVML();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   AllowPNG.
  /// </summary>
  public static Boolean? GetAllowPNG(WebSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AllowPNG>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAllowPNG(WebSettings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<AllowPNG>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new AllowPNG();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DoNotRelyOnCSS.
  /// </summary>
  public static Boolean? GetDoNotRelyOnCSS(WebSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotRelyOnCSS>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotRelyOnCSS(WebSettings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotRelyOnCSS>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotRelyOnCSS();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DoNotSaveAsSingleFile.
  /// </summary>
  public static Boolean? GetDoNotSaveAsSingleFile(WebSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotSaveAsSingleFile>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotSaveAsSingleFile(WebSettings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotSaveAsSingleFile>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotSaveAsSingleFile();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DoNotOrganizeInFolder.
  /// </summary>
  public static Boolean? GetDoNotOrganizeInFolder(WebSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotOrganizeInFolder>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotOrganizeInFolder(WebSettings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotOrganizeInFolder>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotOrganizeInFolder();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DoNotUseLongFileNames.
  /// </summary>
  public static Boolean? GetDoNotUseLongFileNames(WebSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotUseLongFileNames>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotUseLongFileNames(WebSettings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotUseLongFileNames>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotUseLongFileNames();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   PixelsPerInch.
  /// </summary>
  public static Int32? GetPixelsPerInch(WebSettings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PixelsPerInch>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetPixelsPerInch(WebSettings? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PixelsPerInch>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new PixelsPerInch { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   TargetScreenSize.
  /// </summary>
  public static TargetScreenSizeKind? GetTargetScreenSize(WebSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TargetScreenSize>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TargetScreenSizeValues, TargetScreenSizeKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTargetScreenSize(WebSettings? openXmlElement, TargetScreenSizeKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TargetScreenSize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<TargetScreenSize, TargetScreenSizeValues, TargetScreenSizeKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.WebSettings? CreateModelElement(WebSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.WebSettings();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.WebSettings? value)
    where OpenXmlElementType : WebSettings, new()
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