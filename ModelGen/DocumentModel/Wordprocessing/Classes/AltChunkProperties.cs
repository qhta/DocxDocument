namespace DocumentModel.Wordprocessing;


/// <summary>
///   External Content Import Properties.
/// </summary>
public partial class AltChunkProperties
{
  
  /// <summary>
  ///   Keep Source Formatting on Import.
  /// </summary>
  [Nullable((Byte)2)]
  public Boolean? MatchSource { get; set; }
  
}
