namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Legend Entry.
/// </summary>
public partial class LegendEntry
{
  
  /// <summary>
  ///   Index.
  /// </summary>
  public DocumentModel.Drawings.Charts.Index? Index { get; set; }
  
  public DocumentModel.Drawings.Charts.Delete? Delete { get; set; }
  
  public DocumentModel.Drawings.Charts.TextProperties? TextProperties { get; set; }
  
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
}
