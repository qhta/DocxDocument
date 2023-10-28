namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of properties which shall be applied a specific table cell. Each unique property is specified by a child element of this element. In any instance where there is a conflict between the table level, table-level exception, or row level properties with a corresponding table cell property, these properties shall overwrite the table or row wide properties.
/// </summary>
public partial class TableCellProperties
{
  
  /// <summary>
  ///   ConditionalFormatStyle.
  /// </summary>
  public DMW.ConditionalFormatStyle? ConditionalFormatStyle { get; set; }
  
  
  /// <summary>
  ///   TableCellWidth.
  /// </summary>
  public DMW.TableCellWidth? TableCellWidth { get; set; }
  
  
  /// <summary>
  ///   GridSpan.
  /// </summary>
  public DMW.GridSpan? GridSpan { get; set; }
  
  
  /// <summary>
  ///   HorizontalMerge.
  /// </summary>
  public DMW.MergedCellKind? HorizontalMerge { get; set; }
  
  
  /// <summary>
  ///   VerticalMerge.
  /// </summary>
  public DMW.MergedCellKind? VerticalMerge { get; set; }
  
  
  /// <summary>
  ///   TableCellBorders.
  /// </summary>
  public DMW.TableCellBorders? TableCellBorders { get; set; }
  
  
  /// <summary>
  ///   Shading.
  /// </summary>
  public DMW.Shading? Shading { get; set; }
  
  
  /// <summary>
  ///   NoWrap.
  /// </summary>
  public DMW.NoWrap? NoWrap { get; set; }
  
  
  /// <summary>
  ///   TableCellMargin.
  /// </summary>
  public DMW.TableCellMargin? TableCellMargin { get; set; }
  
  
  /// <summary>
  ///   TextDirection.
  /// </summary>
  public DMW.TextDirectionKind? TextDirection { get; set; }
  
  
  /// <summary>
  ///   TableCellFitText.
  /// </summary>
  public DMW.TableCellFitText? TableCellFitText { get; set; }
  
  
  /// <summary>
  ///   TableCellVerticalAlignment.
  /// </summary>
  public DMW.TableVerticalAlignmentKind? TableCellVerticalAlignment { get; set; }
  
  
  /// <summary>
  ///   HideMark.
  /// </summary>
  public DMW.HideMark? HideMark { get; set; }
  
  public DMW.CellInsertion? CellInsertion { get; set; }
  
  public DMW.CellDeletion? CellDeletion { get; set; }
  
  public DMW.CellMerge? CellMerge { get; set; }
  
  public DMW.TableCellPropertiesChange? TableCellPropertiesChange { get; set; }
  
}
