namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ChartLinesType Class.
/// </summary>
public interface ChartLinesType: IModelElement
{
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }
}