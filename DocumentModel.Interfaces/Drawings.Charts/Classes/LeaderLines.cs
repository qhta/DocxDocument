namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Leader Lines.
/// </summary>
public interface LeaderLines: IModelElement
{
  public ChartShapeProperties? ChartShapeProperties { get; set; }
}