namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the DataLabelFieldTableCache Class.
/// </summary>
public interface DataLabelFieldTableCache
{
  public UInt32? PointCount { get; set; }
  public StringPoints? StringPoints { get; set; }
  public StrDataExtensionList? StrDataExtensionList { get; set; }
}