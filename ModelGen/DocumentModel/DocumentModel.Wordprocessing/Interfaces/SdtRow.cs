namespace DocumentModel.Wordprocessing;

/// <summary>
/// Row-Level Structured Document Tag.
/// </summary>
public interface SdtRow
{
  /// <summary>
  /// Row-Level Structured Document Tag Content.
  /// </summary>
  public SdtContentRow? SdtContentRow { get ; set; }
  
  public SdtProperties? SdtProperties { get ; set; }
  
  public SdtEndCharProperties? SdtEndCharProperties { get ; set; }
  
}
