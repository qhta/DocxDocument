namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Horizontal Positioning.
/// </summary>
public class HorizontalPositionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition>, HorizontalPosition
{
  /// <summary>
  /// Horizontal Position Relative Base
  /// </summary>
  public HorizontalRelativePositionKind? RelativeFrom
  {
    get => (HorizontalRelativePositionKind?)OpenXmlElement?.RelativeFrom?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RelativeFrom = (DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalRelativePositionValues?)value;
    }
  }
  
}
