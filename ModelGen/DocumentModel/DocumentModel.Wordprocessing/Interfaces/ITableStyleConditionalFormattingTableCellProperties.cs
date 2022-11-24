namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Style Conditional Formatting Table Cell Properties.
/// </summary>
public interface ITableStyleConditionalFormattingTableCellProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// TableCellBorders.
  /// </summary>
  public ITableCellBorders? TableCellBorders { get ; set; }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public IShading? Shading { get ; set; }
  
  /// <summary>
  /// NoWrap.
  /// </summary>
  public INoWrap? NoWrap { get ; set; }
  
  /// <summary>
  /// TableCellMargin.
  /// </summary>
  public ITableCellMargin? TableCellMargin { get ; set; }
  
  /// <summary>
  /// TableCellVerticalAlignment.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues>? TableCellVerticalAlignment { get ; set; }
  
}
