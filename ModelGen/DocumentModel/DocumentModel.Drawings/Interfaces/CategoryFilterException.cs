namespace DocumentModel.Drawings;

/// <summary>
/// Defines the CategoryFilterException Class.
/// </summary>
public interface CategoryFilterException
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties8? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public Marker2? Marker { get ; set; }
  
  /// <summary>
  /// DataLabel.
  /// </summary>
  public DataLabel4? DataLabel { get ; set; }
  
}
