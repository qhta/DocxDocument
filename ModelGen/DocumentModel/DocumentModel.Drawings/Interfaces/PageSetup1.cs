namespace DocumentModel.Drawings;

/// <summary>
/// Page Setup.
/// </summary>
public interface PageSetup1
{
  /// <summary>
  /// Orientation
  /// </summary>
  public PageSetupOrientationKind? Orientation { get ; set; }
  
}
