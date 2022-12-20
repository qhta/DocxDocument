namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the DataLabelsRange Class.
/// </summary>
public partial interface DataLabelsRange
{
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula { get; set; }
  
  /// <summary>
  /// DataLabelsRangeChache.
  /// </summary>
  public DocumentModel.Drawings.Charts.DataLabelsRangeChache? DataLabelsRangeChache { get; set; }
  
}
