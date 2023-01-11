namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Web Page Settings.
/// </summary>
public static class WebSettingsConverter
{
  /// <summary>
  /// Frameset.
  /// </summary>
  public static DocumentModel.Wordprocessing.Frameset? GetFrameset(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Frameset>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FramesetConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFrameset(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement, DocumentModel.Wordprocessing.Frameset? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Divs.
  /// </summary>
  public static DocumentModel.Wordprocessing.Divs? GetDivs(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Divs>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DivsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDivs(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement, DocumentModel.Wordprocessing.Divs? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// WebPageEncoding.
  /// </summary>
  public static String? GetWebPageEncoding(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement)
  {
    return openXmlElement?.WebPageEncoding?.Val?.Value;
  }
  
  public static void SetWebPageEncoding(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.WebPageEncoding = new DocumentFormat.OpenXml.Wordprocessing.WebPageEncoding { Val = value };
      else
        openXmlElement.WebPageEncoding = null;
    }
  }
  
  /// <summary>
  /// OptimizeForBrowser.
  /// </summary>
  public static Boolean? GetOptimizeForBrowser(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.OptimizeForBrowser>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetOptimizeForBrowser(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// RelyOnVML.
  /// </summary>
  public static Boolean? GetRelyOnVML(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RelyOnVML>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetRelyOnVML(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// AllowPNG.
  /// </summary>
  public static Boolean? GetAllowPNG(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AllowPNG>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetAllowPNG(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// DoNotRelyOnCSS.
  /// </summary>
  public static Boolean? GetDoNotRelyOnCSS(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotRelyOnCSS>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDoNotRelyOnCSS(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// DoNotSaveAsSingleFile.
  /// </summary>
  public static Boolean? GetDoNotSaveAsSingleFile(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotSaveAsSingleFile>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDoNotSaveAsSingleFile(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// DoNotOrganizeInFolder.
  /// </summary>
  public static Boolean? GetDoNotOrganizeInFolder(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotOrganizeInFolder>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDoNotOrganizeInFolder(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// DoNotUseLongFileNames.
  /// </summary>
  public static Boolean? GetDoNotUseLongFileNames(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DoNotUseLongFileNames>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDoNotUseLongFileNames(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// PixelsPerInch.
  /// </summary>
  public static Int32? GetPixelsPerInch(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.PixelsPerInch");
  }
  
  public static void SetPixelsPerInch(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.PixelsPerInch");
  }
  
  /// <summary>
  /// TargetScreenSize.
  /// </summary>
  public static DocumentModel.Wordprocessing.TargetScreenSizeKind? GetTargetScreenSize(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TargetScreenSize>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TargetScreenSizeValues, DocumentModel.Wordprocessing.TargetScreenSizeKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetTargetScreenSize(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement, DocumentModel.Wordprocessing.TargetScreenSizeKind? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
