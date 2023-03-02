namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ChartSpaceExtension Class.
/// </summary>
public record ChartSpaceExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public PivotOptions? PivotOptions { get; set; }

  public SketchOptions? SketchOptions { get; set; }

  public PivotSource3? PivotSource { get; set; }
}