namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataLabelsRange Class.
/// </summary>
public interface DataLabelsRange
{
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula { get ; set; }
  
  /// <summary>
  /// DataLabelsRangeChache.
  /// </summary>
  public DataLabelsRangeChache? DataLabelsRangeChache { get ; set; }
  
}
