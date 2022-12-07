namespace DocumentModel.Wordprocessing;

/// <summary>
/// Vertically Merged/Split Table Cells.
/// </summary>
public interface CellMerge
{
  /// <summary>
  /// vMerge
  /// </summary>
  public VerticalMergeRevisionKind? VerticalMerge { get ; set; }
  
  /// <summary>
  /// vMergeOrig
  /// </summary>
  public VerticalMergeRevisionKind? VerticalMergeOriginal { get ; set; }
  
}
