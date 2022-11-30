namespace DocumentModel.Spreadsheet;

/// <summary>
/// Border Properties.
/// </summary>
public interface IBorder // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Diagonal Up
  /// </summary>
  public System.Boolean? DiagonalUp { get ; set; }
  
  /// <summary>
  /// Diagonal Down
  /// </summary>
  public System.Boolean? DiagonalDown { get ; set; }
  
  /// <summary>
  /// Outline
  /// </summary>
  public System.Boolean? Outline { get ; set; }
  
  /// <summary>
  /// StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Spreadsheet.IStartBorder? StartBorder { get ; set; }
  
  /// <summary>
  /// EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Spreadsheet.IEndBorder? EndBorder { get ; set; }
  
  /// <summary>
  /// Left Border.
  /// </summary>
  public DocumentModel.Spreadsheet.ILeftBorder? LeftBorder { get ; set; }
  
  /// <summary>
  /// Right Border.
  /// </summary>
  public DocumentModel.Spreadsheet.IRightBorder? RightBorder { get ; set; }
  
  /// <summary>
  /// Top Border.
  /// </summary>
  public DocumentModel.Spreadsheet.ITopBorder? TopBorder { get ; set; }
  
  /// <summary>
  /// Bottom Border.
  /// </summary>
  public DocumentModel.Spreadsheet.IBottomBorder? BottomBorder { get ; set; }
  
  /// <summary>
  /// Diagonal.
  /// </summary>
  public DocumentModel.Spreadsheet.IDiagonalBorder? DiagonalBorder { get ; set; }
  
  /// <summary>
  /// Vertical Inner Border.
  /// </summary>
  public DocumentModel.Spreadsheet.IVerticalBorder? VerticalBorder { get ; set; }
  
  /// <summary>
  /// Horizontal Inner Borders.
  /// </summary>
  public DocumentModel.Spreadsheet.IHorizontalBorder? HorizontalBorder { get ; set; }
  
}
