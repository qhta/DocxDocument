namespace DocumentModel.Drawings;

/// <summary>
/// Legend Entry.
/// </summary>
public interface LegendEntry
{
  public TextProperties1? TextProperties { get ; set; }
  
  public ExtensionList4? ExtensionList { get ; set; }
  
}
