namespace DocumentModel.Wordprocessing;

/// <summary>
/// Magnification Setting.
/// </summary>
public class ZoomImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.Zoom>, Zoom
{
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
  
}
