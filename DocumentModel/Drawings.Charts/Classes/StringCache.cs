namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the StringCache Class.
/// </summary>
public record StringCache
{
  public UInt32? PointCount { get; set; }

  public Collection<StringPoint>? StringPoints { get; set; }

  public StrDataExtensionList? StrDataExtensionList { get; set; }
}