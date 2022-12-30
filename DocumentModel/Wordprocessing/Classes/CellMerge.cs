namespace DocumentModel.Wordprocessing;

/// <summary>
/// Vertically Merged/Split Table Cells.
/// </summary>
public partial class CellMerge
{
  /// <summary>
  /// vMerge
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalMergeRevisionKind? VerticalMerge { get; set; }
  
  /// <summary>
  /// vMergeOrig
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalMergeRevisionKind? VerticalMergeOriginal { get; set; }
  
  /// <summary>
  /// author
  /// </summary>
  public String? Author { get; set; }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date { get; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id { get; set; }
  
}
