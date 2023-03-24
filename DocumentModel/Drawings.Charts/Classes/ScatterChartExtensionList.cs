namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ScatterChartExtensionList Class.
/// </summary>
public class ScatterChartExtensionList: ModelElement
{
  public Collection<ScatterChartExtension>? ScatterChartExtensions { get; set; }
}