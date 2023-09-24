namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of table properties which shall be applied to all regions within a table which match the conditional formatting type specified on the parent tblStylePr element. These properties are applied in the order specified via the style hierarchy.
/// </summary>
public partial class TableStyleConditionalFormattingTableProperties
{
  
  /// <summary>
  ///   TableJustification.
  /// </summary>
  public TableRowAlignmentKind? TableJustification { get; set; }
  
  
  /// <summary>
  ///   TableCellSpacing.
  /// </summary>
  public TableWidthType? TableCellSpacing { get; set; }
  
  
  /// <summary>
  ///   TableIndentation.
  /// </summary>
  public TableIndentation? TableIndentation { get; set; }
  
  
  /// <summary>
  ///   TableBorders.
  /// </summary>
  public TableBorders? TableBorders { get; set; }
  
  
  /// <summary>
  ///   Shading.
  /// </summary>
  public Shading? Shading { get; set; }
  
  
  /// <summary>
  ///   TableCellMarginDefault.
  /// </summary>
  public TableCellMarginDefault? TableCellMarginDefault { get; set; }
  
}
