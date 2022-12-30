namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Legend Entry.
/// </summary>
public partial class LegendEntry
{
  /// <summary>
  /// Index.
  /// </summary>
  public UInt32? Index { get; set; }
  
  public Boolean? Delete { get; set; }
  
  public DocumentModel.Drawings.Charts.TextProperties? TextProperties { get; set; }
  
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
}
