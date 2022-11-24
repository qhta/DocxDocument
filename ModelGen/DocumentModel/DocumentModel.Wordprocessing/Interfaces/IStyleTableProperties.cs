namespace DocumentModel.Wordprocessing;

/// <summary>
/// Style Table Properties.
/// </summary>
public interface IStyleTableProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// TableStyleRowBandSize.
  /// </summary>
  public ITableStyleRowBandSize? TableStyleRowBandSize { get ; set; }
  
  /// <summary>
  /// TableStyleColumnBandSize.
  /// </summary>
  public ITableStyleColumnBandSize? TableStyleColumnBandSize { get ; set; }
  
  /// <summary>
  /// TableJustification.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues>? TableJustification { get ; set; }
  
  /// <summary>
  /// TableCellSpacing.
  /// </summary>
  public ITableCellSpacing? TableCellSpacing { get ; set; }
  
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
