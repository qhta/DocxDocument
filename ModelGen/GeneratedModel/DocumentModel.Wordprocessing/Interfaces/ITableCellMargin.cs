namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableCellMargin Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITopMargin))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILeftMargin))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IStartMargin))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBottomMargin))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRightMargin))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IEndMargin))]
public interface ITableCellMargin // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Table Cell Top Margin Exception.
  /// </summary>
  public ITopMargin? TopMargin { get ; set; }
  
  /// <summary>
  /// Table Cell Left Margin Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.ILeftMargin? LeftMargin { get ; set; }
  
  /// <summary>
  /// StartMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public IStartMargin? StartMargin { get ; set; }
  
  /// <summary>
  /// Table Cell Bottom Margin Exception.
  /// </summary>
  public IBottomMargin? BottomMargin { get ; set; }
  
  /// <summary>
  /// Table Cell Right Margin Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.IRightMargin? RightMargin { get ; set; }
  
  /// <summary>
  /// EndMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public IEndMargin? EndMargin { get ; set; }
  
}
