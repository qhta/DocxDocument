namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the DataLabelsRange Class.
/// </summary>
public interface DataLabelsRange
{
  /// <summary>
  ///   Formula.
  /// </summary>
  public string? Formula { get; set; }
  /// <summary>
  ///   DataLabelsRangeChache.
  /// </summary>
  public DataLabelsRangeChache? DataLabelsRangeChache { get; set; }
}