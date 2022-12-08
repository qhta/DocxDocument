namespace DocumentModel.Drawings;

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
  public ChartShapeProperties? ChartShapeProperties { get ; set; }
  
}
