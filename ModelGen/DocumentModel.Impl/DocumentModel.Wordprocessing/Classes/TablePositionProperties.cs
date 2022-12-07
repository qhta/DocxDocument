namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TablePositionProperties Class.
/// </summary>
public class TablePositionPropertiesImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties>, TablePositionProperties
{
  /// <summary>
  /// Table Vertical Anchor
  /// </summary>
  public VerticalAnchorKind? VerticalAnchor
  {
    get => (VerticalAnchorKind?)OpenXmlElement?.VerticalAnchor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalAnchor = (DocumentFormat.OpenXml.Wordprocessing.VerticalAnchorValues?)value;
    }
  }
  
  /// <summary>
  /// Table Horizontal Anchor
  /// </summary>
  public HorizontalAnchorKind? HorizontalAnchor
  {
    get => (HorizontalAnchorKind?)OpenXmlElement?.HorizontalAnchor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalAnchor = (DocumentFormat.OpenXml.Wordprocessing.HorizontalAnchorValues?)value;
    }
  }
  
  /// <summary>
  /// Relative Horizontal Alignment From Anchor
  /// </summary>
  public HorizontalAlignmentKind? TablePositionXAlignment
  {
    get => (HorizontalAlignmentKind?)OpenXmlElement?.TablePositionXAlignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.TablePositionXAlignment = (DocumentFormat.OpenXml.Wordprocessing.HorizontalAlignmentValues?)value;
    }
  }
  
  /// <summary>
  /// Relative Vertical Alignment from Anchor
  /// </summary>
  public VerticalAlignmentKind? TablePositionYAlignment
  {
    get => (VerticalAlignmentKind?)OpenXmlElement?.TablePositionYAlignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.TablePositionYAlignment = (DocumentFormat.OpenXml.Wordprocessing.VerticalAlignmentValues?)value;
    }
  }
  
}
