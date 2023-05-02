namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PieChartExtensionList Class.
/// </summary>
public class PieChartExtensionList: ModelElement
{
  public Collection<PieChartExtension>? PieChartExtensions { get; set; }
}