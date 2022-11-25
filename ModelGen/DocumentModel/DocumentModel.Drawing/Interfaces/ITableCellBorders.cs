namespace DocumentModel.Drawing;

/// <summary>
/// Table Cell Borders.
/// </summary>
public interface ITableCellBorders // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Left Border.
  /// </summary>
  public DocumentModel.Drawing.IThemeableLineStyleType? LeftBorder { get ; set; }
  
  /// <summary>
  /// Right Border.
  /// </summary>
  public DocumentModel.Drawing.IThemeableLineStyleType? RightBorder { get ; set; }
  
  /// <summary>
  /// Top Border.
  /// </summary>
  public DocumentModel.Drawing.IThemeableLineStyleType? TopBorder { get ; set; }
  
  /// <summary>
  /// Bottom Border.
  /// </summary>
  public DocumentModel.Drawing.IThemeableLineStyleType? BottomBorder { get ; set; }
  
  /// <summary>
  /// Inside Horizontal Border.
  /// </summary>
  public DocumentModel.Drawing.IThemeableLineStyleType? InsideHorizontalBorder { get ; set; }
  
  /// <summary>
  /// Inside Vertical Border.
  /// </summary>
  public DocumentModel.Drawing.IThemeableLineStyleType? InsideVerticalBorder { get ; set; }
  
  /// <summary>
  /// Top Left to Bottom Right Border.
  /// </summary>
  public DocumentModel.Drawing.IThemeableLineStyleType? TopLeftToBottomRightBorder { get ; set; }
  
  /// <summary>
  /// Top Right to Bottom Left Border.
  /// </summary>
  public DocumentModel.Drawing.IThemeableLineStyleType? TopRightToBottomLeftBorder { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
