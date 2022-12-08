namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Horizontal Positioning.
/// </summary>
public class HorizontalPositionImpl: ModelElementImpl, HorizontalPosition
{
  public DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
  
  /// <summary>
  /// Relative Horizontal Alignment.
  /// </summary>
  public String? HorizontalAlignment
  {
    get;
    set;
  }
  
  /// <summary>
  /// Absolute Position Offset.
  /// </summary>
  public String? PositionOffset
  {
    get;
    set;
  }
  
  /// <summary>
  /// PercentagePositionHeightOffset, this property is only available in Office 2010 and later..
  /// </summary>
  public String? PercentagePositionHeightOffset
  {
    get;
    set;
  }
  
}
