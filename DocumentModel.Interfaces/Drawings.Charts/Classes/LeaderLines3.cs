namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the LeaderLines Class.
/// </summary>
public interface LeaderLines3: IModelElement
{
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }
}