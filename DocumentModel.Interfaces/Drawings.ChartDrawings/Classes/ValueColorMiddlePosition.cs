namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the ValueColorMiddlePosition Class.
/// </summary>
public interface ValueColorMiddlePosition: IModelElement
{
  /// <summary>
  ///   NumberColorPosition.
  /// </summary>
  public Double? NumberColorPosition { get; set; }
  /// <summary>
  ///   PercentageColorPosition.
  /// </summary>
  public Double? PercentageColorPosition { get; set; }
}