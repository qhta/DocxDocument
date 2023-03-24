namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DataLabelFieldTableCache Class.
/// </summary>
public class DataLabelFieldTableCache: ModelElement
{
  public UInt32? PointCount { get; set; }

  public Collection<StringPoint>? StringPoints { get; set; }

  public StrDataExtensionList? StrDataExtensionList { get; set; }
}