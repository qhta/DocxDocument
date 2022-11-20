namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the HorizontalMerge Class.
/// </summary>
public class HorizontalMerge: IHorizontalMerge
{
  /// <summary>
  /// Horizontal Merge Type
  /// </summary>
  public MergedCellValues? Val
  {
    get;
    set;
  }
  
}
