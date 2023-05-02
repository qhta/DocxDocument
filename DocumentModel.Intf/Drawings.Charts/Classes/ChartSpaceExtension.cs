namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ChartSpaceExtension Class.
/// </summary>
public class ChartSpaceExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }

  public PivotOptions? PivotOptions { get; set; }

  public SketchOptions? SketchOptions { get; set; }

  public PivotSource3? PivotSource { get; set; }
}