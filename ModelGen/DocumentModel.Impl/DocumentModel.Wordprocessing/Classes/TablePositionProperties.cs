namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TablePositionProperties Class.
/// </summary>
public class TablePositionPropertiesImpl: ModelElementImpl, TablePositionProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Distance From Left of Table to Text
  /// </summary>
  public Int16? LeftFromText
  {
    get;
    set;
  }
  
  /// <summary>
  /// (Distance From Right of Table to Text
  /// </summary>
  public Int16? RightFromText
  {
    get;
    set;
  }
  
  /// <summary>
  /// Distance From Top of Table to Text
  /// </summary>
  public Int16? TopFromText
  {
    get;
    set;
  }
  
  /// <summary>
  /// Distance From Bottom of Table to Text
  /// </summary>
  public Int16? BottomFromText
  {
    get;
    set;
  }
  
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
  /// Absolute Horizontal Distance From Anchor
  /// </summary>
  public Int32? TablePositionX
  {
    get;
    set;
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
  
  /// <summary>
  /// Absolute Vertical Distance From Anchor
  /// </summary>
  public Int32? TablePositionY
  {
    get;
    set;
  }
  
}
