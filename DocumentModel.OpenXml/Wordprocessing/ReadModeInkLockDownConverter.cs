namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Freeze Document Layout.
/// </summary>
public static class ReadModeInkLockDownConverter
{
  /// <summary>
  /// Use Actual Pages, Not Virtual Pages
  /// </summary>
  private static Boolean? GetUseActualPages(DocumentFormat.OpenXml.Wordprocessing.ReadModeInkLockDown openXmlElement)
  {
    return openXmlElement?.UseActualPages?.Value;
  }
  
  private static void SetUseActualPages(DocumentFormat.OpenXml.Wordprocessing.ReadModeInkLockDown openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UseActualPages = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.UseActualPages = null;
  }
  
  /// <summary>
  /// Virtual Page Width
  /// </summary>
  private static UInt32? GetWidth(DocumentFormat.OpenXml.Wordprocessing.ReadModeInkLockDown openXmlElement)
  {
    return openXmlElement.Width?.Value;
  }
  
  private static void SetWidth(DocumentFormat.OpenXml.Wordprocessing.ReadModeInkLockDown openXmlElement, UInt32? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// Virtual Page Height
  /// </summary>
  private static UInt32? GetHeight(DocumentFormat.OpenXml.Wordprocessing.ReadModeInkLockDown openXmlElement)
  {
    return openXmlElement.Height?.Value;
  }
  
  private static void SetHeight(DocumentFormat.OpenXml.Wordprocessing.ReadModeInkLockDown openXmlElement, UInt32? value)
  {
    openXmlElement.Height = value;
  }
  
  /// <summary>
  /// Font Size Scaling
  /// </summary>
  private static String? GetFontSize(DocumentFormat.OpenXml.Wordprocessing.ReadModeInkLockDown openXmlElement)
  {
    return openXmlElement?.FontSize?.Value;
  }
  
  private static void SetFontSize(DocumentFormat.OpenXml.Wordprocessing.ReadModeInkLockDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FontSize = new StringValue { Value = value };
    else
      openXmlElement.FontSize = null;
  }
  
  public static DocumentModel.Wordprocessing.ReadModeInkLockDown? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.ReadModeInkLockDown? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ReadModeInkLockDown();
      value.UseActualPages = GetUseActualPages(openXmlElement);
      value.Width = GetWidth(openXmlElement);
      value.Height = GetHeight(openXmlElement);
      value.FontSize = GetFontSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ReadModeInkLockDown? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.ReadModeInkLockDown, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUseActualPages(openXmlElement, value?.UseActualPages);
      SetWidth(openXmlElement, value?.Width);
      SetHeight(openXmlElement, value?.Height);
      SetFontSize(openXmlElement, value?.FontSize);
      return openXmlElement;
    }
    return default;
  }
}
