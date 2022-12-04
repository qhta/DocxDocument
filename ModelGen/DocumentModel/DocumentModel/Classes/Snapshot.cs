namespace DocumentModel;

/// <summary>
/// Defines the Snapshot Class.
/// </summary>
public class Snapshot
{
  /// <summary>
  /// Compression state for blips.
  /// </summary>
  public DocumentModel.Drawings.BlipCompressionKind? CompressionState
  {
    get;
    set;
  }
  
  public DocumentModel.Drawings.BlipExtensionList? BlipExtensionList
  {
    get;
    set;
  }
  
}
