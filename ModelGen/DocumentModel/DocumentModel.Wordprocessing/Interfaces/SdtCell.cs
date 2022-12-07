namespace DocumentModel.Wordprocessing;

/// <summary>
/// Cell-Level Structured Document Tag.
/// </summary>
public interface SdtCell
{
  /// <summary>
  /// Cell-Level Structured Document Tag Content.
  /// </summary>
  public SdtContentCell? SdtContentCell { get ; set; }
  
  public SdtProperties? SdtProperties { get ; set; }
  
  public SdtEndCharProperties? SdtEndCharProperties { get ; set; }
  
}
