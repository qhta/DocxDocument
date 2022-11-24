namespace DocumentModel.Drawing;

/// <summary>
/// Table Cell Borders.
/// </summary>
public interface ITableCellBorders // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Left Border.
  /// </summary>
  public ILeftBorder? LeftBorder { get ; set; }
  
  /// <summary>
  /// Right Border.
  /// </summary>
  public IRightBorder? RightBorder { get ; set; }
  
  /// <summary>
  /// Top Border.
  /// </summary>
  public ITopBorder? TopBorder { get ; set; }
  
  /// <summary>
  /// Bottom Border.
  /// </summary>
  public IBottomBorder? BottomBorder { get ; set; }
  
  /// <summary>
  /// Inside Horizontal Border.
  /// </summary>
  public InsideHorizontalBorder? InsideHorizontalBorder { get ; set; }
  
  /// <summary>
  /// Inside Vertical Border.
  /// </summary>
  public InsideVerticalBorder? InsideVerticalBorder { get ; set; }
  
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
  public IExtensionList? ExtensionList { get ; set; }
  
}
