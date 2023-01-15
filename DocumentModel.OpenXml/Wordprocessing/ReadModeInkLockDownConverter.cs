using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Freeze Document Layout.
/// </summary>
public static class ReadModeInkLockDownConverter
{
  /// <summary>
  ///   Use Actual Pages, Not Virtual Pages
  /// </summary>
  public static Boolean? GetUseActualPages(ReadModeInkLockDown? openXmlElement)
  {
    return openXmlElement?.UseActualPages?.Value;
  }

  public static void SetUseActualPages(ReadModeInkLockDown? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UseActualPages = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.UseActualPages = null;
  }

  /// <summary>
  ///   Virtual Page Width
  /// </summary>
  public static UInt32? GetWidth(ReadModeInkLockDown? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }

  public static void SetWidth(ReadModeInkLockDown? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Width = value;
  }

  /// <summary>
  ///   Virtual Page Height
  /// </summary>
  public static UInt32? GetHeight(ReadModeInkLockDown? openXmlElement)
  {
    return openXmlElement?.Height?.Value;
  }

  public static void SetHeight(ReadModeInkLockDown? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Height = value;
  }

  /// <summary>
  ///   Font Size Scaling
  /// </summary>
  public static String? GetFontSize(ReadModeInkLockDown? openXmlElement)
  {
    return openXmlElement?.FontSize?.Value;
  }

  public static void SetFontSize(ReadModeInkLockDown? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FontSize = new StringValue { Value = value };
      else
        openXmlElement.FontSize = null;
  }

  public static DocumentModel.Wordprocessing.ReadModeInkLockDown? CreateModelElement(ReadModeInkLockDown? openXmlElement)
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
    where OpenXmlElementType : ReadModeInkLockDown, new()
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