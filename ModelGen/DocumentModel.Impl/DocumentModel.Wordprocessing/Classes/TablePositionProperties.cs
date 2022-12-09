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
    get => (Int16?)OpenXmlElement?.LeftFromText?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LeftFromText = (System.Int16?)value;
    }
  }
  
  /// <summary>
  /// (Distance From Right of Table to Text
  /// </summary>
  public Int16? RightFromText
  {
    get => (Int16?)OpenXmlElement?.RightFromText?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RightFromText = (System.Int16?)value;
    }
  }
  
  /// <summary>
  /// Distance From Top of Table to Text
  /// </summary>
  public Int16? TopFromText
  {
    get => (Int16?)OpenXmlElement?.TopFromText?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.TopFromText = (System.Int16?)value;
    }
  }
  
  /// <summary>
  /// Distance From Bottom of Table to Text
  /// </summary>
  public Int16? BottomFromText
  {
    get => (Int16?)OpenXmlElement?.BottomFromText?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BottomFromText = (System.Int16?)value;
    }
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
    get => (Int32?)OpenXmlElement?.TablePositionX?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.TablePositionX = (System.Int32?)value;
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
  
  /// <summary>
  /// Absolute Vertical Distance From Anchor
  /// </summary>
  public Int32? TablePositionY
  {
    get => (Int32?)OpenXmlElement?.TablePositionY?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.TablePositionY = (System.Int32?)value;
    }
  }
  
}
