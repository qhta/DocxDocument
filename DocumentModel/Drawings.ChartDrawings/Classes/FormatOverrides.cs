namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the FormatOverrides Class.
/// </summary>
public record FormatOverrides
{
  public Collection<FormatOverride>? Items { get; set; }
}