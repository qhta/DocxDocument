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
  public DocumentModel.Wordprocessing.TableWidthType? TableCellWidth { get; set; }
  
  
  /// <summary>
  ///   GridSpan.
  /// </summary>
  public Int32? GridSpan { get; set; }
  
  
  /// <summary>
  ///   HorizontalMerge.
  /// </summary>
  public DocumentModel.Wordprocessing.MergedCellValues? HorizontalMerge { get; set; }
  
  
  /// <summary>
  ///   VerticalMerge.
  /// </summary>
  public DocumentModel.Wordprocessing.MergedCellValues? VerticalMerge { get; set; }
  
  
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
  public Boolean? NoWrap { get; set; }
  
  
  /// <summary>
  ///   TableCellMargin.
  /// </summary>
  public DocumentModel.Wordprocessing.TableCellMargin? TableCellMargin { get; set; }
  
  
  /// <summary>
  ///   TextDirection.
  /// </summary>
  public DocumentModel.Wordprocessing.TextDirectionValues? TextDirection { get; set; }
  
  
  /// <summary>
  ///   TableCellFitText.
  /// </summary>
  public Boolean? TableCellFitText { get; set; }
  
  
  /// <summary>
  ///   TableCellVerticalAlignment.
  /// </summary>
  public DocumentModel.Wordprocessing.TableVerticalAlignmentValues? TableCellVerticalAlignment { get; set; }
  
  
  /// <summary>
  ///   HideMark.
  /// </summary>
  public Boolean? HideMark { get; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CellInsertion { get; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CellDeletion { get; set; }
  
  public DocumentModel.Wordprocessing.CellMerge? CellMerge { get; set; }
  
  public DocumentModel.Wordprocessing.TableCellPropertiesChange? TableCellPropertiesChange { get; set; }
  
}
