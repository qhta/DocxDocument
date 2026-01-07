namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the DataLabelsRangeChache Class.
/// </summary>
public interface DataLabelsRangeChache
{
  public UInt32? PointCount { get; set; }
  public StringPoints? StringPoints { get; set; }
  public StrDataExtensionList? StrDataExtensionList { get; set; }
}