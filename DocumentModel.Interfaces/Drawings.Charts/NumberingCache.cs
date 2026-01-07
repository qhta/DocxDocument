namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the NumberingCache Class.
/// </summary>
public interface NumberingCache
{
  public string? FormatCode { get; set; }
  public UInt32? PointCount { get; set; }
  public NumericPoints NumericPoints { get; set; }
  public ExtensionList? ExtensionList { get; set; }
}