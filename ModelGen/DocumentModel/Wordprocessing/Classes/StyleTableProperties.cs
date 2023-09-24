namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of table properties which shall be applied to the table. These properties are not conditional and shall always be applied (although they are applied before all conditional formatting properties).
/// </summary>
public partial class StyleTableProperties
{
  
  /// <summary>
  ///   TableStyleRowBandSize.
  /// </summary>
  public Int32? TableStyleRowBandSize { get; set; }
  
  
  /// <summary>
  ///   TableStyleColumnBandSize.
  /// </summary>
  public Int32? TableStyleColumnBandSize { get; set; }
  
  
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
