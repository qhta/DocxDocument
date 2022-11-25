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
  public DocumentModel.Spreadsheet.IBorderPropertiesType? StartBorder { get ; set; }
  
  /// <summary>
  /// EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Spreadsheet.IBorderPropertiesType? EndBorder { get ; set; }
  
  /// <summary>
  /// Left Border.
  /// </summary>
  public DocumentModel.Spreadsheet.IBorderPropertiesType? LeftBorder { get ; set; }
  
  /// <summary>
  /// Right Border.
  /// </summary>
  public DocumentModel.Spreadsheet.IBorderPropertiesType? RightBorder { get ; set; }
  
  /// <summary>
  /// Top Border.
  /// </summary>
  public DocumentModel.Spreadsheet.IBorderPropertiesType? TopBorder { get ; set; }
  
  /// <summary>
  /// Bottom Border.
  /// </summary>
  public DocumentModel.Spreadsheet.IBorderPropertiesType? BottomBorder { get ; set; }
  
  /// <summary>
  /// Diagonal.
  /// </summary>
  public DocumentModel.Spreadsheet.IBorderPropertiesType? DiagonalBorder { get ; set; }
  
  /// <summary>
  /// Vertical Inner Border.
  /// </summary>
  public DocumentModel.Spreadsheet.IBorderPropertiesType? VerticalBorder { get ; set; }
  
  /// <summary>
  /// Horizontal Inner Borders.
  /// </summary>
  public DocumentModel.Spreadsheet.IBorderPropertiesType? HorizontalBorder { get ; set; }
  
}
