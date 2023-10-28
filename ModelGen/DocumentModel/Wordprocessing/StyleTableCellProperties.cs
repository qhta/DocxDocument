namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of table cell properties which shall be applied to the table. These properties are not conditional and shall always be applied (although they are applied before all conditional formatting properties).
/// </summary>
public partial class StyleTableCellProperties
{
  
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
  ///   TableCellVerticalAlignment.
  /// </summary>
  public DMW.TableVerticalAlignmentKind? TableCellVerticalAlignment { get; set; }
  
}
