namespace DocumentModel.Drawings;

/// <summary>
/// Linear Gradient Fill.
/// </summary>
public interface LinearGradientFill
{
  /// <summary>
  /// Angle
  /// </summary>
  public Int32? Angle { get ; set; }
  
  /// <summary>
  /// Scaled
  /// </summary>
  public Boolean? Scaled { get ; set; }
  
}
