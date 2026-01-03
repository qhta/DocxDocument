namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Major Gridlines.
/// </summary>
public interface MajorGridlines: IModelElement
{
  public ChartShapeProperties? ChartShapeProperties { get; set; }
}