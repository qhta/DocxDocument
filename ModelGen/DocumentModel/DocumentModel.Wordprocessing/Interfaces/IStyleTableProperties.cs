namespace DocumentModel.Wordprocessing;

/// <summary>
/// Style Table Properties.
/// </summary>
public interface IStyleTableProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// TableStyleRowBandSize.
  /// </summary>
  public System.Int32? TableStyleRowBandSize { get ; set; }
  
  /// <summary>
  /// TableStyleColumnBandSize.
  /// </summary>
  public System.Int32? TableStyleColumnBandSize { get ; set; }
  
  /// <summary>
  /// TableJustification.
  /// </summary>
  public DocumentModel.Wordprocessing.TableRowAlignmentKind? TableJustification { get ; set; }
  
  /// <summary>
  /// TableCellSpacing.
  /// </summary>
  public DocumentModel.Wordprocessing.ITableWidthType? TableCellSpacing { get ; set; }
  
  /// <summary>
  /// TableIndentation.
  /// </summary>
  public DocumentModel.Wordprocessing.ITableIndentation? TableIndentation { get ; set; }
  
  /// <summary>
  /// TableBorders.
  /// </summary>
  public DocumentModel.Wordprocessing.ITableBorders? TableBorders { get ; set; }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public DocumentModel.Wordprocessing.IShading? Shading { get ; set; }
  
  /// <summary>
  /// TableCellMarginDefault.
  /// </summary>
  public DocumentModel.Wordprocessing.ITableCellMarginDefault? TableCellMarginDefault { get ; set; }
  
}
