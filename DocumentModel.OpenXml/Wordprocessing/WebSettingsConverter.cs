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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFrameset(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement, DocumentModel.Wordprocessing.Frameset? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Divs.
  /// </summary>
  public static DocumentModel.Wordprocessing.Divs? GetDivs(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDivs(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement, DocumentModel.Wordprocessing.Divs? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// OptimizeForBrowser.
  /// </summary>
  public static Boolean? GetOptimizeForBrowser(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetOptimizeForBrowser(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// RelyOnVML.
  /// </summary>
  public static Boolean? GetRelyOnVML(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRelyOnVML(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// AllowPNG.
  /// </summary>
  public static Boolean? GetAllowPNG(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAllowPNG(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// DoNotRelyOnCSS.
  /// </summary>
  public static Boolean? GetDoNotRelyOnCSS(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDoNotRelyOnCSS(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// DoNotSaveAsSingleFile.
  /// </summary>
  public static Boolean? GetDoNotSaveAsSingleFile(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDoNotSaveAsSingleFile(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// DoNotOrganizeInFolder.
  /// </summary>
  public static Boolean? GetDoNotOrganizeInFolder(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDoNotOrganizeInFolder(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// DoNotUseLongFileNames.
  /// </summary>
  public static Boolean? GetDoNotUseLongFileNames(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDoNotUseLongFileNames(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// PixelsPerInch.
  /// </summary>
  public static Int32? GetPixelsPerInch(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPixelsPerInch(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
  
}
