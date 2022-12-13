namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Style Conditional Formatting Table Properties.
/// </summary>
public interface TableStyleConditionalFormattingTableProperties
{
  /// <summary>
  /// TableJustification.
  /// </summary>
  public DocumentModel.Wordprocessing.TableRowAlignmentKind? TableJustification { get ; set; }
  
  /// <summary>
  /// TableCellSpacing.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? TableCellSpacing { get ; set; }
  
  /// <summary>
  /// TableIndentation.
  /// </summary>
  public DocumentModel.Wordprocessing.TableIndentation? TableIndentation { get ; set; }
  
  /// <summary>
  /// TableBorders.
  /// </summary>
  public DocumentModel.Wordprocessing.TableBorders? TableBorders { get ; set; }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public DocumentModel.Wordprocessing.Shading? Shading { get ; set; }
  
  /// <summary>
  /// TableCellMarginDefault.
  /// </summary>
  public DocumentModel.Wordprocessing.TableCellMarginDefault? TableCellMarginDefault { get ; set; }
  
}
