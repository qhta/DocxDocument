namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Blip Class.
/// </summary>
public class Blip
{
  /// <summary>
  /// Compression state for blips.
  /// </summary>
  public BlipCompressionKind? CompressionState
  {
    get;
    set;
  }
  
  public BlipExtensionList? BlipExtensionList
  {
    get;
    set;
  }
  
}
