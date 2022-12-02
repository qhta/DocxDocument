namespace DocumentModel.Wordprocessing;

/// <summary>
/// Style Table Cell Properties.
/// </summary>
public interface IStyleTableCellProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Shading.
  /// </summary>
  public IShading? Shading { get ; set; }
  
  /// <summary>
  /// NoWrap.
  /// </summary>
  public OnOffOnlyKind? NoWrap { get ; set; }
  
  /// <summary>
  /// TableCellMargin.
  /// </summary>
  public ITableCellMargin? TableCellMargin { get ; set; }
  
  /// <summary>
  /// TableCellVerticalAlignment.
  /// </summary>
  public TableVerticalAlignmentKind? TableCellVerticalAlignment { get ; set; }
  
}
