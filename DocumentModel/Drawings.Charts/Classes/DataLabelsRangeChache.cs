namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the DataLabelsRangeChache Class.
/// </summary>
public class DataLabelsRangeChache: ModelElement
{
  public UInt32? PointCount { get; set; }

  public Collection<StringPoint>? StringPoints { get; set; }

  public StrDataExtensionList? StrDataExtensionList { get; set; }
}