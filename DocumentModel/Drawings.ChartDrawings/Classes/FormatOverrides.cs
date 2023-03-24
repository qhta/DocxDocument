namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the FormatOverrides Class.
/// </summary>
public class FormatOverrides: ModelElement
{
  public Collection<FormatOverride>? Items { get; set; }
}