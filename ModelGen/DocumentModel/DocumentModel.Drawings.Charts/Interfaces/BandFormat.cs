namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Band Format.
/// </summary>
public interface BandFormat
{
  /// <summary>
  /// Index.
  /// </summary>
  public UInt32? Index { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties { get ; set; }
  
}
