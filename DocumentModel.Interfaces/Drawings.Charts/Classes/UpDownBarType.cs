namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the UpDownBarType Class.
/// </summary>
public interface UpDownBarType: IModelElement
{
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }
}