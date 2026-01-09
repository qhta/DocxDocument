namespace DocumentModel.Drawings;

/// <summary>
/// Describes options for building and animating charts, including the build sequence and background animation settings.
/// </summary>
public interface BuildChart : ExtendableElement
{
  /// <summary>
  /// Specifies the build sequence or type for chart elements during animation or rendering.
  /// </summary>
  public string? Build { get; set; }

  /// <summary>
  /// Indicates whether background elements of the chart should be animated along with chart data.
  /// </summary>
  public bool? AnimateBackground { get; set; }
}