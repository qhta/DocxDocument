namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Vertical Positioning.
/// </summary>
public class VerticalPositionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition>, VerticalPosition
{
  /// <summary>
  /// Vertical Position Relative Base
  /// </summary>
  public VerticalRelativePositionKind? RelativeFrom
  {
    get => (VerticalRelativePositionKind?)OpenXmlElement?.RelativeFrom?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RelativeFrom = (DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalRelativePositionValues?)value;
    }
  }
  
}
