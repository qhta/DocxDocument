namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the NumberingCache Class.
/// </summary>
public class NumberingCache: ModelElement
{
  public String? FormatCode { get; set; }

  public UInt32? PointCount { get; set; }

  public Collection<NumericPoint>? NumericPoints { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}