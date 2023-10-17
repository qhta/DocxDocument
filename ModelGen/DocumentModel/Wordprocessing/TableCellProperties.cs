namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of properties which shall be applied a specific table cell. Each unique property is specified by a child element of this element. In any instance where there is a conflict between the table level, table-level exception, or row level properties with a corresponding table cell property, these properties shall overwrite the table or row wide properties.
/// </summary>
public partial class TableCellProperties
{
  
  /// <summary>
  ///   ConditionalFormatStyle.
  /// </summary>
  public DocumentModel.Wordprocessing.ConditionalFormatStyle? ConditionalFormatStyle { get; set; }
  
  
  /// <summary>
  ///   TableCellWidth.
  /// </summary>
  public DocumentModel.Wordprocessing.TableCellWidth? TableCellWidth { get; set; }
  
  
  /// <summary>
  ///   GridSpan.
  /// </summary>
  public DocumentModel.Wordprocessing.GridSpan? GridSpan { get; set; }
  
  
  /// <summary>
  ///   HorizontalMerge.
  /// </summary>
  public DocumentModel.Wordprocessing.MergedCellKind? HorizontalMerge { get; set; }
  
  
  /// <summary>
  ///   VerticalMerge.
  /// </summary>
  public DocumentModel.Wordprocessing.MergedCellKind? VerticalMerge { get; set; }
  
  
  /// <summary>
  ///   TableCellBorders.
  /// </summary>
  public DocumentModel.Wordprocessing.TableCellBorders? TableCellBorders { get; set; }
  
  
  /// <summary>
  ///   Shading.
  /// </summary>
  public DocumentModel.Wordprocessing.Shading? Shading { get; set; }
  
  
  /// <summary>
  ///   NoWrap.
  /// </summary>
  public DocumentModel.Wordprocessing.NoWrap? NoWrap { get; set; }
  
  
  /// <summary>
  ///   TableCellMargin.
  /// </summary>
  public DocumentModel.Wordprocessing.TableCellMargin? TableCellMargin { get; set; }
  
  
  /// <summary>
  ///   TextDirection.
  /// </summary>
  public DocumentModel.Wordprocessing.TextDirectionKind? TextDirection { get; set; }
  
  
  /// <summary>
  ///   TableCellFitText.
  /// </summary>
  public DocumentModel.Wordprocessing.TableCellFitText? TableCellFitText { get; set; }
  
  
  /// <summary>
  ///   TableCellVerticalAlignment.
  /// </summary>
  public DocumentModel.Wordprocessing.TableVerticalAlignmentKind? TableCellVerticalAlignment { get; set; }
  
  
  /// <summary>
  ///   HideMark.
  /// </summary>
  public DocumentModel.Wordprocessing.HideMark? HideMark { get; set; }
  
  public DocumentModel.Wordprocessing.CellInsertion? CellInsertion { get; set; }
  
  public DocumentModel.Wordprocessing.CellDeletion? CellDeletion { get; set; }
  
  public DocumentModel.Wordprocessing.CellMerge? CellMerge { get; set; }
  
  public DocumentModel.Wordprocessing.TableCellPropertiesChange? TableCellPropertiesChange { get; set; }
  
}
