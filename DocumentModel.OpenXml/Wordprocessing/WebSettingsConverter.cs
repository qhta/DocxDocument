namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Web Page Settings.
/// </summary>
public static class WebSettingsConverter
{
  /// <summary>
  /// Frameset.
  /// </summary>
  private static DocumentModel.Wordprocessing.Frameset? GetFrameset(DocumentFormat.OpenXml.Wordprocessing.WebSettings openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Frameset>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FramesetConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFrameset(DocumentFormat.OpenXml.Wordprocessing.WebSettings openXmlElement, DocumentModel.Wordprocessing.Frameset? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Frameset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.FramesetConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Frameset>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Divs.
  /// </summary>
  private static DocumentModel.Wordprocessing.Divs? GetDivs(DocumentFormat.OpenXml.Wordprocessing.WebSettings openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Divs>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DivsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDivs(DocumentFormat.OpenXml.Wordprocessing.WebSettings openXmlElement, DocumentModel.Wordprocessing.Divs? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Divs>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.DivsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Divs>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// WebPageEncoding.
  /// </summary>
  private static String? GetWebPageEncoding(DocumentFormat.OpenXml.Wordprocessing.WebSettings openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WebPageEncoding>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetWebPageEncoding(DocumentFormat.OpenXml.Wordprocessing.WebSettings openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WebPageEncoding>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.WebPageEncoding { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// OptimizeForBrowser.
  /// </summary>
  private static Boolean? GetOptimizeForBrowser(DocumentFormat.OpenXml.Wordprocessing.WebSettings openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.OptimizeForBrowser>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetOptimizeForBrowser(DocumentFormat.OpenXml.Wordprocessing.WebSettings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.OptimizeForBrowser>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.OptimizeForBrowser();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// RelyOnVML.
  /// </summary>
  private static Boolean? GetRelyOnVML(DocumentFormat.OpenXml.Wordprocessing.WebSettings openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RelyOnVML>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetRelyOnVML(DocumentFormat.OpenXml.Wordprocessing.WebSettings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RelyOnVML>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.RelyOnVML();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// AllowPNG.
  /// </summary>
  private static Boolean? GetAllowPNG(DocumentFormat.OpenXml.Wordprocessing.WebSettings openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AllowPNG>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetAllowPNG(DocumentFormat.OpenXml.Wordprocessing.WebSettings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AllowPNG>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.AllowPNG();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DoNotRelyOnCSS.
  /// </summary>
  private static Boolean? GetDoNotRelyOnCSS(DocumentFormat.OpenXml.Wordprocessing.WebSettings openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotRelyOnCSS>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDoNotRelyOnCSS(DocumentFormat.OpenXml.Wordprocessing.WebSettings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotRelyOnCSS>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotRelyOnCSS();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DoNotSaveAsSingleFile.
  /// </summary>
  private static Boolean? GetDoNotSaveAsSingleFile(DocumentFormat.OpenXml.Wordprocessing.WebSettings openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotSaveAsSingleFile>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDoNotSaveAsSingleFile(DocumentFormat.OpenXml.Wordprocessing.WebSettings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotSaveAsSingleFile>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotSaveAsSingleFile();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DoNotOrganizeInFolder.
  /// </summary>
  private static Boolean? GetDoNotOrganizeInFolder(DocumentFormat.OpenXml.Wordprocessing.WebSettings openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotOrganizeInFolder>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDoNotOrganizeInFolder(DocumentFormat.OpenXml.Wordprocessing.WebSettings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotOrganizeInFolder>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotOrganizeInFolder();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DoNotUseLongFileNames.
  /// </summary>
  private static Boolean? GetDoNotUseLongFileNames(DocumentFormat.OpenXml.Wordprocessing.WebSettings openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotUseLongFileNames>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetDoNotUseLongFileNames(DocumentFormat.OpenXml.Wordprocessing.WebSettings openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotUseLongFileNames>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DoNotUseLongFileNames();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PixelsPerInch.
  /// </summary>
  private static Int32? GetPixelsPerInch(DocumentFormat.OpenXml.Wordprocessing.WebSettings openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PixelsPerInch>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPixelsPerInch(DocumentFormat.OpenXml.Wordprocessing.WebSettings openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PixelsPerInch>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.PixelsPerInch{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TargetScreenSize.
  /// </summary>
  private static DocumentModel.Wordprocessing.TargetScreenSizeKind? GetTargetScreenSize(DocumentFormat.OpenXml.Wordprocessing.WebSettings openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TargetScreenSize>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TargetScreenSizeValues, DocumentModel.Wordprocessing.TargetScreenSizeKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTargetScreenSize(DocumentFormat.OpenXml.Wordprocessing.WebSettings openXmlElement, DocumentModel.Wordprocessing.TargetScreenSizeKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TargetScreenSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TargetScreenSize, DocumentFormat.OpenXml.Wordprocessing.TargetScreenSizeValues, DocumentModel.Wordprocessing.TargetScreenSizeKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.WebSettings? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.WebSettings, new()
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
