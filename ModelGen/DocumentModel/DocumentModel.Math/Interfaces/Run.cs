namespace DocumentModel.Math;

/// <summary>
/// Defines the Run Class.
/// </summary>
public interface Run
{
  /// <summary>
  /// Run Properties.
  /// </summary>
  public RunProperties? MathRunProperties { get ; set; }
  
  /// <summary>
  /// Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.RunProperties? RunProperties { get ; set; }
  
}
