namespace DocumentModel.Wordprocessing;

/// <summary>
/// Magnification Setting.
/// </summary>
public partial class ZoomImpl: ModelElementImpl, Zoom
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.Zoom? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Zoom?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ZoomImpl(): base() {}
  
  public ZoomImpl(DocumentFormat.OpenXml.Wordprocessing.Zoom openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Zoom Type
  /// </summary>
  public DocumentModel.Wordprocessing.PresetZoomKind? Val
  {
    get => (DocumentModel.Wordprocessing.PresetZoomKind?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.PresetZoomValues?)value;
    }
  }
  
  /// <summary>
  /// Zoom Percentage
  /// </summary>
  public String? Percent
  {
    get => (System.String?)OpenXmlElement?.Percent?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Percent = (System.String?)value;
    }
  }
  
}
