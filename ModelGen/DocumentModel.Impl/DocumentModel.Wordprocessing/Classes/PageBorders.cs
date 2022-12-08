namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PageBorders Class.
/// </summary>
public class PageBordersImpl: ModelElementImpl, PageBorders
{
  public DocumentFormat.OpenXml.Wordprocessing.PageBorders? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.PageBorders?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Z-Ordering of Page Border
  /// </summary>
  public PageBorderZOrderKind? ZOrder
  {
    get => (PageBorderZOrderKind?)OpenXmlElement?.ZOrder?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ZOrder = (DocumentFormat.OpenXml.Wordprocessing.PageBorderZOrderValues?)value;
    }
  }
  
  /// <summary>
  /// Pages to Display Page Borders
  /// </summary>
  public PageBorderDisplayKind? Display
  {
    get => (PageBorderDisplayKind?)OpenXmlElement?.Display?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Display = (DocumentFormat.OpenXml.Wordprocessing.PageBorderDisplayValues?)value;
    }
  }
  
  /// <summary>
  /// Page Border Positioning
  /// </summary>
  public PageBorderOffsetKind? OffsetFrom
  {
    get => (PageBorderOffsetKind?)OpenXmlElement?.OffsetFrom?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.OffsetFrom = (DocumentFormat.OpenXml.Wordprocessing.PageBorderOffsetValues?)value;
    }
  }
  
  /// <summary>
  /// Top Border.
  /// </summary>
  public BorderType? TopBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Left Border.
  /// </summary>
  public BorderType? LeftBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bottom Border.
  /// </summary>
  public BorderType? BottomBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Right Border.
  /// </summary>
  public BorderType? RightBorder
  {
    get;
    set;
  }
  
}
