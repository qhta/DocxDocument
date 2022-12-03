namespace DocumentModel.Math;

/// <summary>
/// Accent.
/// </summary>
public interface Accent // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Accent Properties.
  /// </summary>
  public AccentProperties? AccentProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public Base? Base { get ; set; }
  
}
