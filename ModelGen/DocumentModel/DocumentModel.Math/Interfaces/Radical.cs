namespace DocumentModel.Math;

/// <summary>
/// Radical Function.
/// </summary>
public interface Radical
{
  /// <summary>
  /// Radical Properties.
  /// </summary>
  public DocumentModel.Math.RadicalProperties? RadicalProperties { get ; set; }
  
  /// <summary>
  /// Degree.
  /// </summary>
  public DocumentModel.Math.Degree? Degree { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.Base? Base { get ; set; }
  
}
