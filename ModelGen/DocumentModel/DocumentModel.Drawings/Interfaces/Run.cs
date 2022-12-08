namespace DocumentModel.Drawings;

/// <summary>
/// Text Run.
/// </summary>
public interface Run
{
  /// <summary>
  /// Text Character Properties.
  /// </summary>
  public RunProperties? RunProperties { get ; set; }
  
  /// <summary>
  /// Text String.
  /// </summary>
  public String? Text { get ; set; }
  
}
