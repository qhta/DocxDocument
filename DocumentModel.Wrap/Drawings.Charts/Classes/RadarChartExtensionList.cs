namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the RadarChartExtensionList Class.
/// </summary>
public class RadarChartExtensionList: ModelElement
{
  public Collection<RadarChartExtension>? RadarChartExtensions { get; set; }
}