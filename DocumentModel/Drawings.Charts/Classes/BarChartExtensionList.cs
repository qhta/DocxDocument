namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BarChartExtensionList Class.
/// </summary>
public class BarChartExtensionList: ModelElement
{
  public Collection<BarChartExtension>? BarChartExtensions { get; set; }
}