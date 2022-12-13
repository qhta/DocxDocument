namespace DocumentModel.Drawings13.Charts;

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
  public DocumentModel.Drawings13.Charts.DataLabelsRangeChache? DataLabelsRangeChache { get ; set; }
  
}
