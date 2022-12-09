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
  
  public TextProperties1? TextProperties { get ; set; }
  
  public ExtensionList3? ExtensionList { get ; set; }
  
}
