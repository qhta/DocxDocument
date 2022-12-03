namespace DocumentModel.Math;

/// <summary>
/// Accent Properties.
/// </summary>
public interface AccentProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Accent Character.
  /// </summary>
  public String? AccentChar { get ; set; }
  
  /// <summary>
  /// Control Properties.
  /// </summary>
  public ControlProperties? ControlProperties { get ; set; }
  
}
