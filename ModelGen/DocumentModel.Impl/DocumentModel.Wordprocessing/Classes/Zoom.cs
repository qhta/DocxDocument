namespace DocumentModel.Wordprocessing;

/// <summary>
/// Magnification Setting.
/// </summary>
public class ZoomImpl: ModelElementImpl, Zoom
{
  public DocumentFormat.OpenXml.Wordprocessing.Zoom? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Zoom?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ZoomImpl(): base() {}
  
  public ZoomImpl(DocumentFormat.OpenXml.Wordprocessing.Zoom openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Zoom Type
  /// </summary>
  public PresetZoomKind? Val
  {
    get => (PresetZoomKind?)OpenXmlElement?.Val?.Value;
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
    get => (String?)OpenXmlElement?.Percent?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Percent = (System.String?)value;
    }
  }
  
}
