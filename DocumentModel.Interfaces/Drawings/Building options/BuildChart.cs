namespace DocumentModel.Drawings;

/// <summary>
/// Represents build chart options, including build type, background animation, and additional extension settings for chart elements.
/// </summary>
public interface BuildChart: ExtendableElement
{
  /// <summary>
  /// Build type or sequence for the chart.
  /// </summary>
  public string? Build { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the chart background should be animated.
  /// </summary>
  public bool? AnimateBackground { get; set; }
}