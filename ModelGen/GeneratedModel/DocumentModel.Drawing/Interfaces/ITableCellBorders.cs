namespace DocumentModel.Drawing;

/// <summary>
/// Table Cell Borders.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILeftBorder))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IRightBorder))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITopBorder))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBottomBorder))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IInsideHorizontalBorder))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IInsideVerticalBorder))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITopLeftToBottomRightBorder))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITopRightToBottomLeftBorder))]
public interface ITableCellBorders // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Left Border.
  /// </summary>
  public DocumentModel.Drawing.ILeftBorder? LeftBorder { get ; set; }
  
  /// <summary>
  /// Right Border.
  /// </summary>
  public DocumentModel.Drawing.IRightBorder? RightBorder { get ; set; }
  
  /// <summary>
  /// Top Border.
  /// </summary>
  public DocumentModel.Drawing.ITopBorder? TopBorder { get ; set; }
  
  /// <summary>
  /// Bottom Border.
  /// </summary>
  public DocumentModel.Drawing.IBottomBorder? BottomBorder { get ; set; }
  
  /// <summary>
  /// Inside Horizontal Border.
  /// </summary>
  public DocumentModel.Drawing.IInsideHorizontalBorder? InsideHorizontalBorder { get ; set; }
  
  /// <summary>
  /// Inside Vertical Border.
  /// </summary>
  public DocumentModel.Drawing.IInsideVerticalBorder? InsideVerticalBorder { get ; set; }
  
  /// <summary>
  /// Top Left to Bottom Right Border.
  /// </summary>
  public ITopLeftToBottomRightBorder? TopLeftToBottomRightBorder { get ; set; }
  
  /// <summary>
  /// Top Right to Bottom Left Border.
  /// </summary>
  public ITopRightToBottomLeftBorder? TopRightToBottomLeftBorder { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
