namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Drop Lines.
/// </summary>
public interface DropLines: IModelElement
{
  public ChartShapeProperties? ChartShapeProperties { get; set; }
}