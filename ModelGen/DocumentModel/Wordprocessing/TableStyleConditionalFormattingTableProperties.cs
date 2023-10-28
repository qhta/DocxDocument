namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of table properties which shall be applied to all regions within a table which match the conditional formatting type specified on the parent tblStylePr element. These properties are applied in the order specified via the style hierarchy.
/// </summary>
public partial class TableStyleConditionalFormattingTableProperties
{
  
  /// <summary>
  ///   TableJustification.
  /// </summary>
  public DMW.TableRowAlignmentKind? TableJustification { get; set; }
  
  
  /// <summary>
  ///   TableCellSpacing.
  /// </summary>
  public DMW.TableCellSpacing? TableCellSpacing { get; set; }
  
  
  /// <summary>
  ///   TableIndentation.
  /// </summary>
  public DMW.TableIndentation? TableIndentation { get; set; }
  
  
  /// <summary>
  ///   TableBorders.
  /// </summary>
  public DMW.TableBorders? TableBorders { get; set; }
  
  
  /// <summary>
  ///   Shading.
  /// </summary>
  public DMW.Shading? Shading { get; set; }
  
  
  /// <summary>
  ///   TableCellMarginDefault.
  /// </summary>
  public DMW.TableCellMarginDefault? TableCellMarginDefault { get; set; }
  
}
