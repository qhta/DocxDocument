namespace DocumentModel.Spreadsheet;

/// <summary>
/// Border Properties.
/// </summary>
public interface IBorder // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Diagonal Up
  /// </summary>
  public Boolean? DiagonalUp { get ; set; }
  
  /// <summary>
  /// Diagonal Down
  /// </summary>
  public Boolean? DiagonalDown { get ; set; }
  
  /// <summary>
  /// Outline
  /// </summary>
  public Boolean? Outline { get ; set; }
  
  /// <summary>
  /// StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public IStartBorder? StartBorder { get ; set; }
  
  /// <summary>
  /// EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public IEndBorder? EndBorder { get ; set; }
  
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
  /// Diagonal.
  /// </summary>
  public IDiagonalBorder? DiagonalBorder { get ; set; }
  
  /// <summary>
  /// Vertical Inner Border.
  /// </summary>
  public IVerticalBorder? VerticalBorder { get ; set; }
  
  /// <summary>
  /// Horizontal Inner Borders.
  /// </summary>
  public IHorizontalBorder? HorizontalBorder { get ; set; }
  
}
