namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the NumberingCache Class.
/// </summary>
public record NumberingCache
{
  public String? FormatCode { get; set; }

  public UInt32? PointCount { get; set; }

  public Collection<NumericPoint>? NumericPoints { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}