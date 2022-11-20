namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the VerticalMerge Class.
/// </summary>
public class VerticalMerge: IVerticalMerge
{
  /// <summary>
  /// Vertical Merge Type
  /// </summary>
  public MergedCellValues? Val
  {
    get;
    set;
  }
  
}
