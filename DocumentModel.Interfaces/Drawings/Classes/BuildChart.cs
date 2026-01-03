namespace DocumentModel.Drawings;

/// <summary>
///   Build Chart.
/// </summary>
public interface BuildChart: IModelElement
{
  /// <summary>
  ///   Build
  /// </summary>
  public string? Build { get; set; }
  /// <summary>
  ///   Animate Background
  /// </summary>
  public bool? AnimateBackground { get; set; }
}