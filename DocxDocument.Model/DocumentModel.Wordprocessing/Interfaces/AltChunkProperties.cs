namespace DocumentModel.Wordprocessing;

/// <summary>
/// External Content Import Properties.
/// </summary>
public partial interface AltChunkProperties
{
  /// <summary>
  /// Keep Source Formatting on Import.
  /// </summary>
  public Boolean? MatchSource { get; set; }
  
}
