namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PaperSource Class.
/// </summary>
public class PaperSourceImpl: ModelElementImpl, PaperSource
{
  public DocumentFormat.OpenXml.Wordprocessing.PaperSource? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.PaperSource?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// First Page Printer Tray Code
  /// </summary>
  public UInt16? First
  {
    get => (UInt16?)OpenXmlElement?.First?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.First = (System.UInt16?)value;
    }
  }
  
  /// <summary>
  /// Non-First Page Printer Tray Code
  /// </summary>
  public UInt16? Other
  {
    get => (UInt16?)OpenXmlElement?.Other?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Other = (System.UInt16?)value;
    }
  }
  
}
