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
  
  public TablePositionPropertiesImpl(): base() {}
  
  public TablePositionPropertiesImpl(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Distance From Left of Table to Text
  /// </summary>
  public Int16? LeftFromText
  {
    get => (System.Int16?)OpenXmlElement?.LeftFromText?.Value;
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
    get => (System.Int16?)OpenXmlElement?.RightFromText?.Value;
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
    get => (System.Int16?)OpenXmlElement?.TopFromText?.Value;
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
    get => (System.Int16?)OpenXmlElement?.BottomFromText?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BottomFromText = (System.Int16?)value;
    }
  }
  
  /// <summary>
  /// Table Vertical Anchor
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalAnchorKind? VerticalAnchor
  {
    get => (DocumentModel.Wordprocessing.VerticalAnchorKind?)OpenXmlElement?.VerticalAnchor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalAnchor = (DocumentFormat.OpenXml.Wordprocessing.VerticalAnchorValues?)value;
    }
  }
  
  /// <summary>
  /// Table Horizontal Anchor
  /// </summary>
  public DocumentModel.Wordprocessing.HorizontalAnchorKind? HorizontalAnchor
  {
    get => (DocumentModel.Wordprocessing.HorizontalAnchorKind?)OpenXmlElement?.HorizontalAnchor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalAnchor = (DocumentFormat.OpenXml.Wordprocessing.HorizontalAnchorValues?)value;
    }
  }
  
  /// <summary>
  /// Relative Horizontal Alignment From Anchor
  /// </summary>
  public DocumentModel.Wordprocessing.HorizontalAlignmentKind? TablePositionXAlignment
  {
    get => (DocumentModel.Wordprocessing.HorizontalAlignmentKind?)OpenXmlElement?.TablePositionXAlignment?.Value;
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
    get => (System.Int32?)OpenXmlElement?.TablePositionX?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.TablePositionX = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Relative Vertical Alignment from Anchor
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalAlignmentKind? TablePositionYAlignment
  {
    get => (DocumentModel.Wordprocessing.VerticalAlignmentKind?)OpenXmlElement?.TablePositionYAlignment?.Value;
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
    get => (System.Int32?)OpenXmlElement?.TablePositionY?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.TablePositionY = (System.Int32?)value;
    }
  }
  
}
