namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ImageLayer interface.
/// </summary>
public interface ImageLayer
{
  /// <summary>
  ///   embed
  /// </summary>
  public string? Embed { get; set; }
  public Collection<ImageEffect>? ImageEffects { get; set; }
}