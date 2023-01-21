namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PaperSource Class.
/// </summary>
public static class PaperSourceConverter
{
  /// <summary>
  /// First Page Printer Tray Code
  /// </summary>
  private static UInt16? GetFirst(DXW.PaperSource openXmlElement)
  {
    return openXmlElement.First?.Value;
  }
  
  private static void SetFirst(DXW.PaperSource openXmlElement, UInt16? value)
  {
    openXmlElement.First = value;
  }
  
  /// <summary>
  /// Non-First Page Printer Tray Code
  /// </summary>
  private static UInt16? GetOther(DXW.PaperSource openXmlElement)
  {
    return openXmlElement.Other?.Value;
  }
  
  private static void SetOther(DXW.PaperSource openXmlElement, UInt16? value)
  {
    openXmlElement.Other = value;
  }
  
  public static DMW.PaperSource? CreateModelElement(DXW.PaperSource? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PaperSource();
      value.First = GetFirst(openXmlElement);
      value.Other = GetOther(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.PaperSource? value)
    where OpenXmlElementType: DXW.PaperSource, new()
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
