namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the DataLabelsRange Class.
/// </summary>
public class DataLabelsRange: ModelElement
{
  /// <summary>
  ///   Formula.
  /// </summary>
  public String? Formula { get; set; }

  /// <summary>
  ///   DataLabelsRangeChache.
  /// </summary>
  public DataLabelsRangeChache? DataLabelsRangeChache { get; set; }
}