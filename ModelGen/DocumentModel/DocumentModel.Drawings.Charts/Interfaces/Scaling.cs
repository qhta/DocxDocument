namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Scaling.
/// </summary>
public interface Scaling
{
  /// <summary>
  /// Logarithmic Base.
  /// </summary>
  public Double? LogBase { get ; set; }
  
  /// <summary>
  /// Axis Orientation.
  /// </summary>
  public DocumentModel.Drawings.Charts.OrientationKind? Orientation { get ; set; }
  
  /// <summary>
  /// Maximum.
  /// </summary>
  public Double? MaxAxisValue { get ; set; }
  
  /// <summary>
  /// Minimum.
  /// </summary>
  public Double? MinAxisValue { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get ; set; }
  
}
