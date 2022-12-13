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
  
  public PageBordersImpl(): base() {}
  
  public PageBordersImpl(DocumentFormat.OpenXml.Wordprocessing.PageBorders openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Z-Ordering of Page Border
  /// </summary>
  public DocumentModel.Wordprocessing.PageBorderZOrderKind? ZOrder
  {
    get => (DocumentModel.Wordprocessing.PageBorderZOrderKind?)OpenXmlElement?.ZOrder?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ZOrder = (DocumentFormat.OpenXml.Wordprocessing.PageBorderZOrderValues?)value;
    }
  }
  
  /// <summary>
  /// Pages to Display Page Borders
  /// </summary>
  public DocumentModel.Wordprocessing.PageBorderDisplayKind? Display
  {
    get => (DocumentModel.Wordprocessing.PageBorderDisplayKind?)OpenXmlElement?.Display?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Display = (DocumentFormat.OpenXml.Wordprocessing.PageBorderDisplayValues?)value;
    }
  }
  
  /// <summary>
  /// Page Border Positioning
  /// </summary>
  public DocumentModel.Wordprocessing.PageBorderOffsetKind? OffsetFrom
  {
    get => (DocumentModel.Wordprocessing.PageBorderOffsetKind?)OpenXmlElement?.OffsetFrom?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.OffsetFrom = (DocumentFormat.OpenXml.Wordprocessing.PageBorderOffsetValues?)value;
    }
  }
  
  /// <summary>
  /// Top Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? TopBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Left Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? LeftBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Bottom Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? BottomBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Right Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? RightBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
