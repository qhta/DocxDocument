namespace DocumentModel.Drawings;

/// <summary>
/// Linear Gradient Fill.
/// </summary>
public interface LinearGradientFill // : System.Boolean
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
