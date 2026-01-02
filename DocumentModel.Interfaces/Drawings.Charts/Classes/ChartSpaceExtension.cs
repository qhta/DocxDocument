namespace DocumentModel.Drawings.Charts;

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