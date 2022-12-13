namespace DocumentModel.Math;

/// <summary>
/// Accent Properties.
/// </summary>
public interface AccentProperties
{
  /// <summary>
  /// Accent Character.
  /// </summary>
  public String? AccentChar { get ; set; }
  
  /// <summary>
  /// Control Properties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties { get ; set; }
  
}
