namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtRunRuby Class.
/// </summary>
public interface SdtRunRuby
{
  /// <summary>
  /// SdtContentRunRuby.
  /// </summary>
  public SdtContentRunRuby? SdtContentRunRuby { get ; set; }
  
  public SdtProperties? SdtProperties { get ; set; }
  
  public SdtEndCharProperties? SdtEndCharProperties { get ; set; }
  
}
