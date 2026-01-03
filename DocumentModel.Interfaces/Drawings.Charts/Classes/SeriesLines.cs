namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the SeriesLines Class.
/// </summary>
public interface SeriesLines: IModelElement
{
  public ChartShapeProperties? ChartShapeProperties { get; set; }
}