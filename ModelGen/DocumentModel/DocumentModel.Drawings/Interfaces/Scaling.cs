namespace DocumentModel.Drawings;

/// <summary>
/// Scaling.
/// </summary>
public interface Scaling
{
  /// <summary>
  /// Axis Orientation.
  /// </summary>
  public OrientationKind? Orientation { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList4? ExtensionList { get ; set; }
  
}
