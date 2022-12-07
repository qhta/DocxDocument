namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtBlock Class.
/// </summary>
public interface SdtBlock
{
  /// <summary>
  /// Block-Level Structured Document Tag Content.
  /// </summary>
  public SdtContentBlock? SdtContentBlock { get ; set; }
  
  public SdtProperties? SdtProperties { get ; set; }
  
  public SdtEndCharProperties? SdtEndCharProperties { get ; set; }
  
}
