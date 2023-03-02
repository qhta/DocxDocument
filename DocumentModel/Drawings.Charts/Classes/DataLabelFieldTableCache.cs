namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the DataLabelFieldTableCache Class.
/// </summary>
public record DataLabelFieldTableCache
{
  public UInt32? PointCount { get; set; }

  public Collection<StringPoint>? StringPoints { get; set; }

  public StrDataExtensionList? StrDataExtensionList { get; set; }
}