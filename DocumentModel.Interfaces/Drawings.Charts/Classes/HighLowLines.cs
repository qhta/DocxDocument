namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the HighLowLines Class.
/// </summary>
public interface HighLowLines: IModelElement
{
  public ChartShapeProperties? ChartShapeProperties { get; set; }
}