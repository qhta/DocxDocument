namespace DocumentModel.Drawings;

/// <summary>
///   Build Chart.
/// </summary>
public record BuildChart
{
  /// <summary>
  ///   Build
  /// </summary>
  public String? Build { get; set; }

  /// <summary>
  ///   Animate Background
  /// </summary>
  public Boolean? AnimateBackground { get; set; }
}