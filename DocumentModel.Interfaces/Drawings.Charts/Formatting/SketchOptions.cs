namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines options for the sketch mode configuration of a chart.
/// </summary>
public interface SketchOptions
{
  /// <summary>
  /// Boolean value indicating whether the chart is currently rendered in sketch mode.
  /// </summary>
  public bool? InSketchMode { get; set; }

  /// <summary>
  /// Boolean value specifying if the sketch mode button should be visible in the user interface.
  /// </summary>
  public bool? ShowSketchButton { get; set; }
}