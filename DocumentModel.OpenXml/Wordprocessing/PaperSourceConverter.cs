using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the PaperSource Class.
/// </summary>
public static class PaperSourceConverter
{
  /// <summary>
  ///   First Page Printer Tray Code
  /// </summary>
  public static UInt16? GetFirst(PaperSource? openXmlElement)
  {
    return openXmlElement?.First?.Value;
  }

  public static void SetFirst(PaperSource? openXmlElement, UInt16? value)
  {
    if (openXmlElement != null)
      openXmlElement.First = value;
  }

  /// <summary>
  ///   Non-First Page Printer Tray Code
  /// </summary>
  public static UInt16? GetOther(PaperSource? openXmlElement)
  {
    return openXmlElement?.Other?.Value;
  }

  public static void SetOther(PaperSource? openXmlElement, UInt16? value)
  {
    if (openXmlElement != null)
      openXmlElement.Other = value;
  }

  public static DocumentModel.Wordprocessing.PaperSource? CreateModelElement(PaperSource? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PaperSource();
      value.First = GetFirst(openXmlElement);
      value.Other = GetOther(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.PaperSource? value)
    where OpenXmlElementType : PaperSource, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFirst(openXmlElement, value?.First);
      SetOther(openXmlElement, value?.Other);
      return openXmlElement;
    }
    return default;
  }
}