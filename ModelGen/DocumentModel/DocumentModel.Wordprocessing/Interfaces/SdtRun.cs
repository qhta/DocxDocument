namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtRun Class.
/// </summary>
public interface SdtRun
{
  /// <summary>
  /// Inline-Level Structured Document Tag Content.
  /// </summary>
  public SdtContentRun? SdtContentRun { get ; set; }
  
  public SdtProperties? SdtProperties { get ; set; }
  
  public SdtEndCharProperties? SdtEndCharProperties { get ; set; }
  
}
