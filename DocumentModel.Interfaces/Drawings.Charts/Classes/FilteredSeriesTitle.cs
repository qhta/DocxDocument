namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the FilteredSeriesTitle Class.
/// </summary>
public interface FilteredSeriesTitle: IModelElement
{
  /// <summary>
  ///   ChartText.
  /// </summary>
  public ChartText3? ChartText { get; set; }
}