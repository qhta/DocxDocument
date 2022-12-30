namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Table Cell Properties.
/// </summary>
public partial class PreviousTableCellProperties
{
  /// <summary>
  /// ConditionalFormatStyle.
  /// </summary>
  public DocumentModel.Wordprocessing.ConditionalFormatStyle? ConditionalFormatStyle { get; set; }
  
  /// <summary>
  /// TableCellWidth.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? TableCellWidth { get; set; }
  
  /// <summary>
  /// GridSpan.
  /// </summary>
  public Int32? GridSpan { get; set; }
  
  /// <summary>
  /// HorizontalMerge.
  /// </summary>
  public DocumentModel.Wordprocessing.MergedCellKind? HorizontalMerge { get; set; }
  
  /// <summary>
  /// VerticalMerge.
  /// </summary>
  public DocumentModel.Wordprocessing.MergedCellKind? VerticalMerge { get; set; }
  
  /// <summary>
  /// TableCellBorders.
  /// </summary>
  public DocumentModel.Wordprocessing.TableCellBorders? TableCellBorders { get; set; }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public DocumentModel.Wordprocessing.Shading? Shading { get; set; }
  
  /// <summary>
  /// NoWrap.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? NoWrap { get; set; }
  
  /// <summary>
  /// TableCellMargin.
  /// </summary>
  public DocumentModel.Wordprocessing.TableCellMargin? TableCellMargin { get; set; }
  
  /// <summary>
  /// TextDirection.
  /// </summary>
  public DocumentModel.Wordprocessing.TextDirectionKind? TextDirection { get; set; }
  
  /// <summary>
  /// TableCellFitText.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? TableCellFitText { get; set; }
  
  /// <summary>
  /// TableCellVerticalAlignment.
  /// </summary>
  public DocumentModel.Wordprocessing.TableVerticalAlignmentKind? TableCellVerticalAlignment { get; set; }
  
  /// <summary>
  /// HideMark.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? HideMark { get; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CellInsertion { get; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CellDeletion { get; set; }
  
  public DocumentModel.Wordprocessing.CellMerge? CellMerge { get; set; }
  
}
