namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of table properties which shall be applied to the table. These properties are not conditional and shall always be applied (although they are applied before all conditional formatting properties).
/// </summary>
public partial class StyleTableProperties
{
  
  /// <summary>
  ///   TableStyleRowBandSize.
  /// </summary>
  public DMW.TableStyleRowBandSize? TableStyleRowBandSize { get; set; }
  
  
  /// <summary>
  ///   TableStyleColumnBandSize.
  /// </summary>
  public DMW.TableStyleColumnBandSize? TableStyleColumnBandSize { get; set; }
  
  
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
