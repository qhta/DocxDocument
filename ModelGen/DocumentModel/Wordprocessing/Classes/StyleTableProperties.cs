namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of table properties which shall be applied to the table. These properties are not conditional and shall always be applied (although they are applied before all conditional formatting properties).
/// </summary>
public partial class StyleTableProperties
{
  
  /// <summary>
  ///   TableStyleRowBandSize.
  /// </summary>
  public DocumentModel.Wordprocessing.TableStyleRowBandSize? TableStyleRowBandSize { get; set; }
  
  
  /// <summary>
  ///   TableStyleColumnBandSize.
  /// </summary>
  public DocumentModel.Wordprocessing.TableStyleColumnBandSize? TableStyleColumnBandSize { get; set; }
  
  
  /// <summary>
  ///   TableJustification.
  /// </summary>
  public DocumentModel.Wordprocessing.TableRowAlignmentKind? TableJustification { get; set; }
  
  
  /// <summary>
  ///   TableCellSpacing.
  /// </summary>
  public DocumentModel.Wordprocessing.TableCellSpacing? TableCellSpacing { get; set; }
  
  
  /// <summary>
  ///   TableIndentation.
  /// </summary>
  public DocumentModel.Wordprocessing.TableIndentation? TableIndentation { get; set; }
  
  
  /// <summary>
  ///   TableBorders.
  /// </summary>
  public DocumentModel.Wordprocessing.TableBorders? TableBorders { get; set; }
  
  
  /// <summary>
  ///   Shading.
  /// </summary>
  public DocumentModel.Wordprocessing.Shading? Shading { get; set; }
  
  
  /// <summary>
  ///   TableCellMarginDefault.
  /// </summary>
  public DocumentModel.Wordprocessing.TableCellMarginDefault? TableCellMarginDefault { get; set; }
  
}
