namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Legend Entry.
/// </summary>
public partial class LegendEntry
{
  
  /// <summary>
  ///   Index.
  /// </summary>
  public DMDC.Index? Index { get; set; }
  
  public DMDC.Delete? Delete { get; set; }
  
  public DMDC.TextProperties? TextProperties { get; set; }
  
  public DMDC.ExtensionList? ExtensionList { get; set; }
  
}
