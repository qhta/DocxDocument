namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Vertical Positioning.
/// </summary>
public class VerticalPositionImpl: ModelElementImpl, VerticalPosition
{
  public DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
  
  /// <summary>
  /// Relative Vertical Alignment.
  /// </summary>
  public String? VerticalAlignment
  {
    get;
    set;
  }
  
  /// <summary>
  /// PositionOffset.
  /// </summary>
  public String? PositionOffset
  {
    get;
    set;
  }
  
  /// <summary>
  /// PercentagePositionVerticalOffset, this property is only available in Office 2010 and later..
  /// </summary>
  public String? PercentagePositionVerticalOffset
  {
    get;
    set;
  }
  
}
