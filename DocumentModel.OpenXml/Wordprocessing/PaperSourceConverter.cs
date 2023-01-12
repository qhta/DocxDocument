namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PaperSource Class.
/// </summary>
public static class PaperSourceConverter
{
  /// <summary>
  /// First Page Printer Tray Code
  /// </summary>
  public static UInt16? GetFirst(DocumentFormat.OpenXml.Wordprocessing.PaperSource? openXmlElement)
  {
    return openXmlElement?.First?.Value;
  }
  
  public static void SetFirst(DocumentFormat.OpenXml.Wordprocessing.PaperSource? openXmlElement, UInt16? value)
  {
    if (openXmlElement != null)
      openXmlElement.First = value;
  }
  
  /// <summary>
  /// Non-First Page Printer Tray Code
  /// </summary>
  public static UInt16? GetOther(DocumentFormat.OpenXml.Wordprocessing.PaperSource? openXmlElement)
  {
    return openXmlElement?.Other?.Value;
  }
  
  public static void SetOther(DocumentFormat.OpenXml.Wordprocessing.PaperSource? openXmlElement, UInt16? value)
  {
    if (openXmlElement != null)
      openXmlElement.Other = value;
  }
  
  public static DocumentModel.Wordprocessing.PaperSource? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.PaperSource? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.PaperSource, new()
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
