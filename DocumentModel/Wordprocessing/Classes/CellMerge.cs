namespace DocumentModel.Wordprocessing;

/// <summary>
///   Vertically Merged/Split Table Cells.
/// </summary>
public class CellMerge: ModelElement
{
  /// <summary>
  ///   vMerge
  /// </summary>
  public VerticalMergeRevisionKind? VerticalMerge { get; set; }

  /// <summary>
  ///   vMergeOrig
  /// </summary>
  public VerticalMergeRevisionKind? VerticalMergeOriginal { get; set; }

  /// <summary>
  ///   author
  /// </summary>
  public String? Author { get; set; }

  /// <summary>
  ///   date
  /// </summary>
  public DateTime? Date { get; set; }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public String? Id { get; set; }
}