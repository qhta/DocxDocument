namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PageSize Class.
/// </summary>
public interface PageSize
{
  /// <summary>
  /// Page Orientation
  /// </summary>
  public PageOrientationKind? Orient { get ; set; }
  
}
