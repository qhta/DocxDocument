namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PaperSource Class.
/// </summary>
public partial class PaperSourceImpl: ModelElementImpl, PaperSource
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.PaperSource? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.PaperSource?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public PaperSourceImpl(): base() {}
  
  public PaperSourceImpl(DocumentFormat.OpenXml.Wordprocessing.PaperSource openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// First Page Printer Tray Code
  /// </summary>
  public UInt16? First
  {
    get => (System.UInt16?)OpenXmlElement?.First?.Value;
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
    get => (System.UInt16?)OpenXmlElement?.Other?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Other = (System.UInt16?)value;
    }
  }
  
}
