namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of table cell properties which shall be applied to the table. These properties are not conditional and shall always be applied (although they are applied before all conditional formatting properties).
/// </summary>
public partial class StyleTableCellProperties
{
  
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
  ///   TableCellVerticalAlignment.
  /// </summary>
  public DocumentModel.Wordprocessing.TableVerticalAlignmentValues? TableCellVerticalAlignment { get; set; }
  
}
