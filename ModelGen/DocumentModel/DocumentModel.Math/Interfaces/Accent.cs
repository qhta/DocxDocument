namespace DocumentModel.Math;

/// <summary>
/// Accent.
/// </summary>
public interface Accent
{
  /// <summary>
  /// Accent Properties.
  /// </summary>
  public DocumentModel.Math.AccentProperties? AccentProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.Base? Base { get ; set; }
  
}
