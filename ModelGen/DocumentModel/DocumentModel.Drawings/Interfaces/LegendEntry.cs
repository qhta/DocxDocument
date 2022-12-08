namespace DocumentModel.Drawings;

/// <summary>
/// Legend Entry.
/// </summary>
public interface LegendEntry
{
  /// <summary>
  /// Index.
  /// </summary>
  public UInt32? Index { get ; set; }
  
  public Boolean? Delete { get ; set; }
  
  public TextProperties2? TextProperties { get ; set; }
  
  public ExtensionList4? ExtensionList { get ; set; }
  
}
