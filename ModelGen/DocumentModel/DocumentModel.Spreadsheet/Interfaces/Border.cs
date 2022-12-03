namespace DocumentModel.Spreadsheet;

/// <summary>
/// Border Properties.
/// </summary>
public interface Border // : DocumentModel.BaseTypes.ModelElement
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
  public StartBorder? StartBorder { get ; set; }
  
  /// <summary>
  /// EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public EndBorder? EndBorder { get ; set; }
  
  /// <summary>
  /// Left Border.
  /// </summary>
  public LeftBorder? LeftBorder { get ; set; }
  
  /// <summary>
  /// Right Border.
  /// </summary>
  public RightBorder? RightBorder { get ; set; }
  
  /// <summary>
  /// Top Border.
  /// </summary>
  public TopBorder? TopBorder { get ; set; }
  
  /// <summary>
  /// Bottom Border.
  /// </summary>
  public BottomBorder? BottomBorder { get ; set; }
  
  /// <summary>
  /// Diagonal.
  /// </summary>
  public DiagonalBorder? DiagonalBorder { get ; set; }
  
  /// <summary>
  /// Vertical Inner Border.
  /// </summary>
  public VerticalBorder? VerticalBorder { get ; set; }
  
  /// <summary>
  /// Horizontal Inner Borders.
  /// </summary>
  public HorizontalBorder? HorizontalBorder { get ; set; }
  
}
