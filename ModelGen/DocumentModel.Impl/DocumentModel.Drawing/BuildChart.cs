namespace DocumentModel.Drawing;

/// <summary>
/// Build Chart.
/// </summary>
public class BuildChart: IBuildChart
{
  /// <summary>
  /// Build
  /// </summary>
  public string? Build
  {
    get;
    set;
  }
  
  /// <summary>
  /// Animate Background
  /// </summary>
  public bool? AnimateBackground
  {
    get;
    set;
  }
  
}
