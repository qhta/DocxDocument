namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of table cell properties which shall be applied to all regions within a table which match the conditional formatting type specified on the parent tblStylePr element. These properties are applied in the order specified via the style hierarchy.
/// </summary>
public partial class TableStyleConditionalFormattingTableCellProperties
{
  
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
  ///   TableCellVerticalAlignment.
  /// </summary>
  public DocumentModel.Wordprocessing.TableVerticalAlignmentKind? TableCellVerticalAlignment { get; set; }
  
}
