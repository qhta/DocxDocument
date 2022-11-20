namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PageBorders Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITopBorder))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILeftBorder))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBottomBorder))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRightBorder))]
public interface IPageBorders // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Z-Ordering of Page Border
  /// </summary>
  public PageBorderZOrderValues? ZOrder { get ; set; }
  
  /// <summary>
  /// Pages to Display Page Borders
  /// </summary>
  public PageBorderDisplayValues? Display { get ; set; }
  
  /// <summary>
  /// Page Border Positioning
  /// </summary>
  public PageBorderOffsetValues? OffsetFrom { get ; set; }
  
  /// <summary>
  /// Top Border.
  /// </summary>
  public DocumentModel.Wordprocessing.ITopBorder? TopBorder { get ; set; }
  
  /// <summary>
  /// Left Border.
  /// </summary>
  public DocumentModel.Wordprocessing.ILeftBorder? LeftBorder { get ; set; }
  
  /// <summary>
  /// Bottom Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IBottomBorder? BottomBorder { get ; set; }
  
  /// <summary>
  /// Right Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IRightBorder? RightBorder { get ; set; }
  
}
