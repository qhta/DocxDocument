namespace DocumentModel.Wordprocessing;

/// <summary>
/// Style Table Properties.
/// </summary>
public interface IStyleTableProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// TableStyleRowBandSize.
  /// </summary>
  public Int32? TableStyleRowBandSize { get ; set; }
  
  /// <summary>
  /// TableStyleColumnBandSize.
  /// </summary>
  public Int32? TableStyleColumnBandSize { get ; set; }
  
  /// <summary>
  /// TableJustification.
  /// </summary>
  public TableRowAlignmentKind? TableJustification { get ; set; }
  
  /// <summary>
  /// TableCellSpacing.
  /// </summary>
  public ITableWidthType? TableCellSpacing { get ; set; }
  
  /// <summary>
  /// TableIndentation.
  /// </summary>
  public ITableIndentation? TableIndentation { get ; set; }
  
  /// <summary>
  /// TableBorders.
  /// </summary>
  public ITableBorders? TableBorders { get ; set; }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public IShading? Shading { get ; set; }
  
  /// <summary>
  /// TableCellMarginDefault.
  /// </summary>
  public ITableCellMarginDefault? TableCellMarginDefault { get ; set; }
  
}
