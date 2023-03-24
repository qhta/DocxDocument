namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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