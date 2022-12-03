namespace DocumentModel.Wordprocessing;

/// <summary>
/// External Content Import Properties.
/// </summary>
public interface AltChunkProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Keep Source Formatting on Import.
  /// </summary>
  public Boolean? MatchSource { get ; set; }
  
}
