namespace DocumentModel.Drawings;

/// <summary>
/// Legend Entry.
/// </summary>
public interface LegendEntry // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Index.
  /// </summary>
  public UInt32? Index { get ; set; }
  
  public Boolean? Delete { get ; set; }
  
  public TextProperties? TextProperties { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
