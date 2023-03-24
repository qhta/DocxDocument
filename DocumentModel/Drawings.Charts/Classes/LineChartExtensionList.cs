namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the LineChartExtensionList Class.
/// </summary>
public class LineChartExtensionList: ModelElement
{
  public Collection<LineChartExtension>? LineChartExtensions { get; set; }
}